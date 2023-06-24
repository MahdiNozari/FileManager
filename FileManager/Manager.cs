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

        public void Add(Base @base)
        {
            int id = 1;
            if (myPc.Count > 0)
            {
                id = myPc[myPc.Count - 1].Id + 1;
            }
            @base.Id = id;
            myPc.Add(@base);
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
            catch(Exception ex)
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
    }
}
