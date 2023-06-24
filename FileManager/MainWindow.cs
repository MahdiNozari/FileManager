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
        private List<int> PathSaver;

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

            CurrentPath = _manager.GetPcName();
            PathSaver.Add(1);
            LoadDrives();
        }

        private void LoadDrives()
        {
            BtnEdit.Enabled = false;
            BtnNewFolder.Enabled = false;
            BtnBack.Enabled = false;
            BtnNewDrive.Enabled = true;
            BtnCopy.Enabled = false;
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
                CurrentPath = _manager.GetPcName();
                LoadDrives();
            }
            else
            {
                CurrentPath = CurrentPath.Substring(0, CurrentPath.LastIndexOf('\\'));
                LoadDirectoryAndFiles(PathSaver[PathSaver.Count - 1]);
            }
        }
    }
}
