using BehComponents;
using FileManager.Models;
using System;
using System.Windows.Forms;

namespace FileManager
{
    public partial class FolderInfoForm : Form
    {
        private readonly Manager _manager;
        private readonly Folder _folder;
        private readonly int _fatherId;

        public FolderInfoForm(Manager manager, int fatherId, Folder folder = null)
        {
            InitializeComponent();
            _manager = manager;
            _folder = folder;
            _fatherId = fatherId;
        }

        private void FolderInfoForm_Load(object sender, EventArgs e)
        {
            if (_folder != null)
            {
                TxtName.Text = _folder.Name;
                BtnCreateOrEdit.Text = "ویرایش پوشه";
            }
        }

        private void BtnCreateOrEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.Focus();
                MessageBoxFarsi.Show("", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else
            {
                if (_manager.CheckExistFolderOrFile(_fatherId, TxtName.Text.Trim()))
                {
                    TxtName.Focus();
                    MessageBoxFarsi.Show("", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }
                else
                {
                    Folder folder = new Folder()
                    {
                        FatherId = _fatherId,
                        Name = TxtName.Text.Trim()
                    };
                    if (_folder is null)
                    {
                        _manager.Add(folder);
                        MessageBoxFarsi.Show("پوشه با موفقیت ایجاد شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                        DialogResult = DialogResult.OK; 
                    }
                    else
                    {
                        folder.Id = _folder.Id;
                        _manager.Edit(folder);
                        MessageBoxFarsi.Show("پوشه با موفقیت ویرایش شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
