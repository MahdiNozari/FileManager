using BehComponents;
using FileManager.Models;
using System;
using System.Windows.Forms;

namespace FileManager
{
    public partial class DriveInfoForm : Form
    {
        private readonly Manager _manager;
        private long maxSize;

        public DriveInfoForm(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void DriceInfoForm_Load(object sender, EventArgs e)
        {
            CmbLabel.SelectedIndex = 0;
            maxSize = _manager.GetHardFreeSpace();
            TxtSize.Maximum = maxSize;
            LblFreeSpace.Text = maxSize.ToString();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.Focus();
                MessageBoxFarsi.Show("نام درایو را وارد کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else if (TxtSize.Value == 0)
            {
                TxtSize.Focus();
                MessageBoxFarsi.Show("سایز درایو را وارد کنید", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else if (TxtSize.Value > maxSize)
            {
                TxtSize.Focus();
                MessageBoxFarsi.Show("سایز درایو نمی تواند بیشتر از سایز خالی باشد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
            }
            else
            {
                if (_manager.CheckExistDriveLabel(CmbLabel.Text))
                {
                    CmbLabel.Focus();
                    MessageBoxFarsi.Show("این درایو قبلا ثبت شده است", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }
                else
                {
                    Drive drive = new Drive()
                    {
                        Label = CmbLabel.Text,
                        Name = TxtName.Text.Trim(),
                        Size = Convert.ToInt64(TxtSize.Value)
                    };
                    _manager.Add(drive);
                    MessageBoxFarsi.Show("درایو با موفقیت ایجاد شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
