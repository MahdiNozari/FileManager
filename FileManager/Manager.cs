using BehComponents;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager
{
    public class Manager
    {
        private List<Base> myPc;

        public Manager()
        {
            myPc = new List<Base>();
        }

        public int Add(Base @base)
        {
            int id = 1;
            if (myPc.Count > 0)
            {
                id = myPc[myPc.Count - 1].Id + 1;
            }
            @base.Id = id;
            myPc.Add(@base);
            return id;
        }

        public void Edit(Base @base)
        {
            var item = myPc.FirstOrDefault(x => x.Id == @base.Id);
            if (item != null)
            {
                if (item is Folder folder)
                {
                    folder.Name = @base.Name;
                }
            }
        }

        public bool ReadFile(string path)
        {
            try
            {
                using (Stream stream = System.IO.File.Open(path, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    myPc = (List<Base>)bformatter.Deserialize(stream);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                return false;
            }
        }

        public string GetPcName()
        {
            return myPc[0].Name;
        }

        public Base GetById(int id)
        {
            return myPc.FirstOrDefault(x => x.Id == id);
        }

        public bool WriteFile(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                using (Stream stream = System.IO.File.Open(path, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, myPc);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                return false;
            }
        }

        public List<Drive> GetDrives()
        {
            var drives = new List<Drive>();
            foreach (var item in myPc)
            {
                if (item is Drive)
                {
                    drives.Add(item as Drive);
                }
            }
            return drives;
        }

        public long GetHardFreeSpace()
        {
            long freeSpace = (myPc[0] as Pc).Size;
            var drives = GetDrives();
            return freeSpace - drives.Sum(x => x.Size);
        }

        public bool CheckExistDriveLabel(string label)
        {
            foreach (var item in myPc)
            {
                if (item is Drive drive)
                {
                    if (drive.Label == label)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Base> GetFileAndFolders(int fatherId)
        {
            var result = new List<Base>();
            foreach (var item in myPc)
            {
                if ((item is Folder folder && folder.FatherId == fatherId) ||
                    (item is Models.File file && file.FatherId == fatherId))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public bool CheckExistFolderOrFile(int fatherId, string name)
        {
            foreach (var item in GetFileAndFolders(fatherId))
            {
                if (item is Folder folder)
                {
                    if (folder.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                else if (item is Models.File file)
                {
                    if (file.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public long GetFolderSize(int id)
        {
            long sum = 0;
            foreach (var item in GetFileAndFolders(id))
            {
                if (item is Models.File file)
                {
                    sum += file.Size;
                }
                else if (item is Folder folder)
                {
                    sum += GetFolderSize(folder.Id);
                }
            }
            return sum;
        }

        public long GetDriveFreeSpace(int id)
        {
            var item = myPc.FirstOrDefault(x => x.Id == id);
            if (item is null)
            {
                return 0;
            }
            else if (item is Folder folder)
            {
                return GetDriveFreeSpace(folder.FatherId);
            }
            else if (item is Drive drive)
            {
                return drive.Size - GetFolderSize(drive.Id);
            }
            else
            {
                return 0;
            }
        }

        public bool Copy(int fromId, int toId)
        {
            var fromLocation = myPc.FirstOrDefault(x => x.Id == fromId);
            var toLocation = myPc.FirstOrDefault(x => x.Id == toId);
            if (fromLocation is null || toLocation is null)
            {
                return false;
            }
            long toLocationFreeSpace = GetDriveFreeSpace(toLocation.Id);
            if (fromLocation is Folder folder)
            {
                long folderSize = GetFolderSize(folder.Id);
                if (folderSize > toLocationFreeSpace)
                {
                    return false;
                }

                string newName = folder.Name;
                int counter = 1;

                while (CheckExistFolderOrFile(toId, newName))
                {
                    newName = $"{newName}({counter})";
                    counter++;
                }

                Folder newFolder = new Folder()
                {
                    FatherId = toId,
                    Name = newName
                };

                newFolder.Id = Add(newFolder);

                foreach (var item in GetFileAndFolders(folder.Id))
                {
                    Copy(item.Id, newFolder.Id);
                }

                return true;
            }
            else if (fromLocation is Models.File file)
            {
                if (file.Size > toLocationFreeSpace)
                {
                    return false;
                }

                string newName = file.Name;
                int counter = 1;

                while (CheckExistFolderOrFile(toId, newName))
                {
                    int index = newName.LastIndexOf('.');
                    if (index == -1)
                        newName = $"{newName}({counter})";
                    else
                        newName = $"{newName}({counter}){Path.GetExtension(newName)}";
                    counter++;
                }

                Models.File newFile = new Models.File()
                {
                    FatherId = toLocation.Id,
                    Name = newName,
                    Size = file.Size,
                    SystemPath = file.SystemPath
                };
                Add(newFile);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cut(int fromId, int toId)
        {
            var fromLocation = myPc.FirstOrDefault(x => x.Id == fromId);
            var toLocation = myPc.FirstOrDefault(x => x.Id == toId);
            if (fromLocation is null || toLocation is null)
            {
                return false;
            }
            long toLocationFreeSpace = GetDriveFreeSpace(toLocation.Id);
            if (fromLocation is Folder folder)
            {
                long folderSize = GetFolderSize(folder.Id);
                if (folderSize > toLocationFreeSpace)
                {
                    return false;
                }

                string newName = folder.Name;
                int counter = 1;

                while (CheckExistFolderOrFile(toId, newName))
                {
                    newName = $"{newName}({counter})";
                    counter++;
                }

                folder.Name = newName;
                folder.FatherId = toId;
                return true;
            }
            else if (fromLocation is Models.File file)
            {
                if (file.Size > toLocationFreeSpace)
                {
                    return false;
                }

                string newName = file.Name;
                int counter = 1;

                while (CheckExistFolderOrFile(toId, newName))
                {
                    int index = newName.LastIndexOf('.');
                    if (index == -1)
                        newName = $"{newName}({counter})";
                    else
                        newName = $"{newName}({counter}){Path.GetExtension(newName)}";
                    counter++;
                }

                file.FatherId = toId;
                file.Name = newName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var deleteItem = myPc.FirstOrDefault(x => x.Id == id);
            if (deleteItem is null)
            {
                return;
            }
            if (deleteItem is Folder folder)
            {
                foreach (var item in GetFileAndFolders(folder.Id))
                {
                    Delete(item.Id);
                }
            }
            else if (deleteItem is Drive drive)
            {
                foreach (var item in GetFileAndFolders(drive.Id))
                {
                    Delete(item.Id);
                }
            }
            else if (deleteItem is Models.File file)
            {
                myPc.RemoveAll(x => x.Id == file.Id);
            }
        }
    }
}
