using BehComponents;
using FileManager.Models;
using System;
using System.Windows.Forms;

namespace FileManager
{
    public partial class StartUpForm : Form
    {
        public string Path { get; set; }
        public bool IsDefaultFile { get; set; }

        public StartUpForm()
        {
            InitializeComponent();
        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {
            if (IsDefaultFile)
            {
                TxtFileName.Text = "default";
                TxtFileName.ReadOnly = true;
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFileName.Text))
            {
                TxtFileName.Focus();
                MessageBoxFarsi.Show("نام فایل را وارد کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "Manager File|*.dsfs",
                    FileName = TxtFileName.Text.Trim()
                };
                if (!IsDefaultFile)
                {
                    if (save.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    Path = save.FileName;
                }
                else
                {
                    Path = Application.StartupPath + "/" + TxtFileName.Text + ".dsfs";
                }
                Manager manager = new Manager();
                manager.Add(new Pc
                {
                    Name = TxtFileName.Text.Trim(),
                    Size = Convert.ToInt64(TxtFileSize.Value)
                });
                if (manager.WriteFile(Path))
                {
                    MessageBoxFarsi.Show("فایل با موفقیت ایجاد شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
