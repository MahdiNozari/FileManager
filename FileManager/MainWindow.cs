using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MainWindow : Form
    {
        private readonly Manager manager;

        public MainWindow()
        {
            InitializeComponent();
            manager = new Manager();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bool read = false;
            if (File.Exists("default.dsfs"))
            {
                read = manager.ReadFile($"{Application.StartupPath}/default.dsfs");
            }

            if (!read)
            {
                StartUpForm startUp = new StartUpForm
                {
                    IsDefaultFile = true
                };
                if (!(startUp.ShowDialog() == DialogResult.OK))
                {
                    Application.Exit();
                }
            }

            LoadDrives();
        }

        private void LoadDrives()
        {
            foreach (var item in manager.GetDrives())
            {
                ListViewItem listitem = new ListViewItem();
                listitem.Text = string.Format("{0}", item.Name);
                listitem.ImageIndex = 0;
                listitem.Tag = item;
                ListDirectoryAndFiles.Items.Add(listitem);
            }
        }
    }
}
