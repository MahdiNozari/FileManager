namespace FileManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPath = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.ListDirectoryAndFiles = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnNewDrive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LblPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 88);
            this.panel1.TabIndex = 4;
            // 
            // LblPath
            // 
            this.LblPath.BackColor = System.Drawing.Color.Transparent;
            this.LblPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblPath.Location = new System.Drawing.Point(0, 41);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(798, 47);
            this.LblPath.TabIndex = 1;
            this.LblPath.Text = "label1";
            this.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtInfo);
            this.panel3.Controls.Add(this.ListDirectoryAndFiles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 333);
            this.panel3.TabIndex = 6;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInfo.Location = new System.Drawing.Point(558, 0);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ReadOnly = true;
            this.TxtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInfo.Size = new System.Drawing.Size(240, 333);
            this.TxtInfo.TabIndex = 3;
            this.TxtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListDirectoryAndFiles
            // 
            this.ListDirectoryAndFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListDirectoryAndFiles.HideSelection = false;
            this.ListDirectoryAndFiles.LargeImageList = this.imageList1;
            this.ListDirectoryAndFiles.Location = new System.Drawing.Point(0, 0);
            this.ListDirectoryAndFiles.Name = "ListDirectoryAndFiles";
            this.ListDirectoryAndFiles.Size = new System.Drawing.Size(558, 333);
            this.ListDirectoryAndFiles.SmallImageList = this.imageList1;
            this.ListDirectoryAndFiles.TabIndex = 2;
            this.ListDirectoryAndFiles.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnHome);
            this.flowLayoutPanel1.Controls.Add(this.BtnBack);
            this.flowLayoutPanel1.Controls.Add(this.BtnCopy);
            this.flowLayoutPanel1.Controls.Add(this.BtnNewDrive);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 44);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(3, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 35);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "خانه";
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(84, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 35);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(165, 3);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 35);
            this.BtnCopy.TabIndex = 8;
            this.BtnCopy.Text = "کپی";
            this.BtnCopy.UseVisualStyleBackColor = true;
            // 
            // BtnNewDrive
            // 
            this.BtnNewDrive.Location = new System.Drawing.Point(246, 3);
            this.BtnNewDrive.Name = "BtnNewDrive";
            this.BtnNewDrive.Size = new System.Drawing.Size(149, 35);
            this.BtnNewDrive.TabIndex = 9;
            this.BtnNewDrive.Text = "ساخت درایو جدید";
            this.BtnNewDrive.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.ListView ListDirectoryAndFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnNewDrive;
    }
}