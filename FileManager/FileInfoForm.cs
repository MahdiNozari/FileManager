using BehComponents;
using FileManager.Models;
using System;
using System.Windows.Forms;

namespace FileManager
{
    public partial class FileInfoForm : Form
    {
        private readonly Manager _manager;
        private readonly File _file;

        public FileInfoForm(Manager manager, File file)
        {
            InitializeComponent();
            _manager = manager;
            _file = file;
        }

        private void FileInfoForm_Load(object sender, EventArgs e)
        {
            TxtName.Text = _file.Name;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.Focus();
                MessageBoxFarsi.Show("نام فایل نمی تواند خالی باشد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else
            {
                _file.Name = TxtName.Text.Trim();
                _manager.Edit(_file);
                MessageBoxFarsi.Show("فایل با موفقیت ویرایش شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
