using BehComponents;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MainWindow : Form
    {
        private readonly Manager _manager;
        private string CurrentPath;
        private string Path;
        private readonly List<int> PathSaver;
        private int CopyFrom = 0;
        private int CutFrom = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            _manager = new Manager();
            PathSaver = new List<int>();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bool read = false;
            Path = $"{Application.StartupPath}/default.dsfs";
            if (System.IO.File.Exists(Path))
            {
                read = _manager.ReadFile(Path);
            }

            if (!read)
            {
                StartUpForm startUp = new StartUpForm
                {
                    IsDefaultFile = true
                };
                if (startUp.ShowDialog() == DialogResult.OK)
                {
                    read = _manager.ReadFile(Path);
                    if (!read)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }

            CurrentPath = $"This Pc({_manager.GetPcName()})";
            PathSaver.Add(1);
            LoadDrives();
        }

        private void LoadDrives()
        {
            BtnCopyFileFromComputer.Enabled = false;
            BtnPaste.Enabled = false;
            BtnCut.Enabled = false;
            BtnCopy.Enabled = false;
            BtnEdit.Enabled = false;
            BtnNewFolder.Enabled = false;
            BtnBack.Enabled = false;
            BtnNewDrive.Enabled = true;
            ListDirectoryAndFiles.Items.Clear();
            LblPath.Text = CurrentPath;
            foreach (var item in _manager.GetDrives())
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = string.Format("{0} ({1}:)", item.Name, item.Label),
                    ImageIndex = 0,
                    Tag = item
                };
                ListDirectoryAndFiles.Items.Add(listitem);
            }
        }

        private void LoadDirectoryAndFiles(int fatherId)
        {
            if (CutFrom != 0 || CopyFrom != 0)
            {
                BtnPaste.Enabled = true;
            }
            BtnCopyFileFromComputer.Enabled = true;
            BtnCut.Enabled = true;
            BtnBack.Enabled = true;
            BtnNewDrive.Enabled = false;
            BtnNewFolder.Enabled = true;
            BtnEdit.Enabled = true;
            BtnCopy.Enabled = true;
            ListDirectoryAndFiles.Items.Clear();
            LblPath.Text = CurrentPath;
            foreach (var item in _manager.GetFileAndFolders(fatherId))
            {
                ListViewItem listitem = new ListViewItem
                {
                    Tag = item,
                    Text = item.Name
                };
                if (item is Folder)
                {
                    listitem.ImageIndex = 1;
                }
                else
                {
                    listitem.ImageIndex = 2;
                }
                ListDirectoryAndFiles.Items.Add(listitem);
            }
        }

        private void BtnNewDrive_Click(object sender, EventArgs e)
        {
            if(new DriveInfoForm(_manager).ShowDialog() == DialogResult.OK)
            {
                LoadDrives();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _manager.WriteFile(Path);
        }

        private void ListDirectoryAndFiles_DoubleClick(object sender, EventArgs e)
        {
            if (ListDirectoryAndFiles.SelectedItems.Count == 0)
            {
                return;
            }
            var item = ListDirectoryAndFiles.SelectedItems[0].Tag;
            if (item is null)
            {
                return;
            }
            if (item is Drive drive)
            {
                PathSaver.Add(drive.Id);
                CurrentPath += $"\\{drive.Name} ({drive.Label}:)";
                LoadDirectoryAndFiles(drive.Id);
            }
            else if (item is Folder folder)
            {
                PathSaver.Add(folder.Id);
                CurrentPath += $"\\{folder.Name}";
                LoadDirectoryAndFiles(folder.Id);
            }
        }

        private void BtnNewFolder_Click(object sender, EventArgs e)
        {
            if (new FolderInfoForm(_manager, PathSaver[PathSaver.Count - 1]).ShowDialog() == DialogResult.OK)
            {
                LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListDirectoryAndFiles.SelectedItems.Count == 0)
            {
                return;
            }
            var item = ListDirectoryAndFiles.SelectedItems[0].Tag;
            if (item is null)
            {
                return;
            }

            if (item is Folder folder)
            {
                if (new FolderInfoForm(_manager, PathSaver[PathSaver.Count - 1], folder).ShowDialog() == DialogResult.OK)
                {
                    LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PathSaver.RemoveAt(PathSaver.Count - 1);
            if (PathSaver[PathSaver.Count - 1] == 1)
            {
                CurrentPath = $"This Pc({_manager.GetPcName()})";
                LoadDrives();
            }
            else
            {
                CurrentPath = CurrentPath.Substring(0, CurrentPath.LastIndexOf('\\'));
                LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
            }
        }

        private void BtnCopyFileFromComputer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (_manager.CheckExistFolderOrFile(PathSaver[PathSaver.Count - 1], open.FileName))
                {
                    MessageBoxFarsi.Show("این فایل در این مسیر وجود دارد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    return;
                }
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(open.FileName);
                if ((fileInfo.Length / 1024) <= _manager.GetDriveFreeSpace(PathSaver[PathSaver.Count - 1]))
                {
                    string path = Guid.NewGuid().ToString().Replace("-", "");
                    if (!string.IsNullOrWhiteSpace(fileInfo.Extension))
                        path += fileInfo.Extension;
                    File newFile = new File()
                    {
                        FatherId = PathSaver[PathSaver.Count - 1],
                        Name = fileInfo.Name,
                        Size = fileInfo.Length / 1024,
                        SystemPath = path
                    };
                    _manager.Add(newFile);
                    if (!System.IO.Directory.Exists($"{Application.StartupPath}\\Files"))
                        System.IO.Directory.CreateDirectory($"{Application.StartupPath}\\Files");
                    System.IO.File.Copy(open.FileName, $"{Application.StartupPath}\\Files\\{path}");
                    MessageBoxFarsi.Show("فایل با موفقیت کپی شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]); 
                }
                else
                {
                    MessageBoxFarsi.Show("فضای کافی در درایو مورد نظر موجود نمی باشد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (ListDirectoryAndFiles.SelectedItems.Count == 0)
            {
                return;
            }
            var item = ListDirectoryAndFiles.SelectedItems[0].Tag;
            if (item is null)
            {
                return;
            }

            if (item is Folder folder)
            {
                CutFrom = 0;
                CopyFrom = folder.Id;
                BtnPaste.Enabled = true;
                MessageBoxFarsi.Show("پوشه انتخاب شد لطفا در محل مورد نظر جایگذاری کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else if (item is File file)
            {
                CutFrom = 0;
                CopyFrom = file.Id;
                BtnPaste.Enabled = true;
                MessageBoxFarsi.Show("فایل انتخاب شد لطفا در محل مورد نظر جایگذاری کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {

            if (ListDirectoryAndFiles.SelectedItems.Count == 0)
            {
                return;
            }
            var item = ListDirectoryAndFiles.SelectedItems[0].Tag;
            if (item is null)
            {
                return;
            }

            if (item is Folder folder)
            {
                CopyFrom = 0;
                CutFrom = folder.Id;
                BtnPaste.Enabled = true;
                MessageBoxFarsi.Show("پوشه انتخاب شد لطفا در محل مورد نظر جایگذاری کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else if (item is File file)
            {
                CopyFrom = 0;
                CutFrom = file.Id;
                BtnPaste.Enabled = true;
                MessageBoxFarsi.Show("فایل انتخاب شد لطفا در محل مورد نظر جایگذاری کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (CopyFrom != 0)
            {
                var item = _manager.GetById(CopyFrom);
                if (item != null)
                {
                    if (_manager.CheckExistFolderOrFile(PathSaver[PathSaver.Count - 1], item.Name))
                    {
                        if (MessageBoxFarsi.Show("فایل یا پوشه همنام در مسیر انتخابی وجود دارد آیا می خواهید اسم فایل یا فولدر مبدا تغییر کنید؟", "پیغام", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Information) != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    if (_manager.Copy(CopyFrom, PathSaver[PathSaver.Count - 1]))
                    {
                        CopyFrom = 0;
                        LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
                        MessageBoxFarsi.Show("کپی با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    }
                    else
                    {
                        MessageBoxFarsi.Show("فضای ذخیره سازی کافی در مکان مورد نظر وجود ندارید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    }
                }
                else
                {
                    CopyFrom = 0;
                    BtnPaste.Enabled = false;
                    MessageBoxFarsi.Show("فایل یا پوشه مورد نظر پاک شده است", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }
            }
            else
            {
                var item = _manager.GetById(CutFrom);
                if (item != null)
                {
                    if (_manager.CheckExistFolderOrFile(PathSaver[PathSaver.Count - 1], item.Name))
                    {
                        if (MessageBoxFarsi.Show("فایل یا پوشه همنام در مسیر انتخابی وجود دارد آیا می خواهید اسم فایل یا فولدر مبدا تغییر کنید؟", "پیغام", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Information) != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    if (_manager.Cut(CutFrom, PathSaver[PathSaver.Count - 1]))
                    {
                        CutFrom = 0;
                        LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
                        MessageBoxFarsi.Show("انتقال با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    }
                    else
                    {
                        MessageBoxFarsi.Show("فضای ذخیره سازی کافی در مکان مورد نظر وجود ندارید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    }
                }
                else
                {
                    CutFrom = 0;
                    BtnPaste.Enabled = false;
                    MessageBoxFarsi.Show("فایل یا پوشه مورد نظر پاک شده است", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (ListDirectoryAndFiles.SelectedItems.Count == 0)
            {
                return;
            }
            var item = ListDirectoryAndFiles.SelectedItems[0].Tag;
            if (item is null)
            {
                return;
            }

            if (item is Folder folder)
            {
                if (MessageBoxFarsi.Show("آیا از حذف پوشه مطمئن هستید؟", "تایید حذف", MessageBoxFarsiButtons.OkCancel, MessageBoxFarsiIcon.Information) == DialogResult.OK)
                {
                    _manager.Delete(folder.Id);
                    LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
                }
            }
            else if (item is File file)
            {
                if (MessageBoxFarsi.Show("آیا از حذف فایل مطمئن هستید؟", "تایید حذف", MessageBoxFarsiButtons.OkCancel, MessageBoxFarsiIcon.Information) == DialogResult.OK)
                {
                    _manager.Delete(file.Id);
                    LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
                }
            }
            else if (item is Drive drive)
            {

                if (MessageBoxFarsi.Show("آیا از حذف درایو مطمئن هستید؟", "تایید حذف", MessageBoxFarsiButtons.OkCancel, MessageBoxFarsiIcon.Information) == DialogResult.OK)
                {
                    _manager.Delete(drive.Id);
                    LoadDrives();
                }
            }
        }
    }
}
