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
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnCut = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPaste = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNewFolder = new System.Windows.Forms.Button();
            this.BtnCopyFileFromComputer = new System.Windows.Forms.Button();
            this.BtnNewDrive = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListDirectoryAndFiles = new System.Windows.Forms.ListView();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPath);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 157);
            this.panel1.TabIndex = 4;
            // 
            // LblPath
            // 
            this.LblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPath.BackColor = System.Drawing.Color.Transparent;
            this.LblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPath.Location = new System.Drawing.Point(55, 110);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(795, 41);
            this.LblPath.TabIndex = 1;
            this.LblPath.Text = "label1";
            this.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnBack
            // 
            this.BtnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Image = global::FileManager.Properties.Resources.back_30px;
            this.BtnBack.Location = new System.Drawing.Point(8, 110);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(41, 41);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBack.TabIndex = 3;
            this.BtnBack.TabStop = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnCopy);
            this.flowLayoutPanel1.Controls.Add(this.BtnCut);
            this.flowLayoutPanel1.Controls.Add(this.BtnDelete);
            this.flowLayoutPanel1.Controls.Add(this.BtnPaste);
            this.flowLayoutPanel1.Controls.Add(this.BtnEdit);
            this.flowLayoutPanel1.Controls.Add(this.BtnNewFolder);
            this.flowLayoutPanel1.Controls.Add(this.BtnCopyFileFromComputer);
            this.flowLayoutPanel1.Controls.Add(this.BtnNewDrive);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 104);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnCopy
            // 
            this.BtnCopy.Image = global::FileManager.Properties.Resources.icons8_copy_50px_1;
            this.BtnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCopy.Location = new System.Drawing.Point(8, 8);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(69, 87);
            this.BtnCopy.TabIndex = 9;
            this.BtnCopy.Text = "کپی";
            this.BtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnCut
            // 
            this.BtnCut.Image = global::FileManager.Properties.Resources.icons8_cut_50px;
            this.BtnCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCut.Location = new System.Drawing.Point(83, 8);
            this.BtnCut.Name = "BtnCut";
            this.BtnCut.Size = new System.Drawing.Size(69, 87);
            this.BtnCut.TabIndex = 10;
            this.BtnCut.Text = "بریدن";
            this.BtnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCut.UseVisualStyleBackColor = true;
            this.BtnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::FileManager.Properties.Resources.icons8_Delete_50px;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDelete.Location = new System.Drawing.Point(158, 8);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(69, 87);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnPaste
            // 
            this.BtnPaste.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaste.Image = global::FileManager.Properties.Resources.icons8_Paste_50px_1;
            this.BtnPaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPaste.Location = new System.Drawing.Point(233, 8);
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(69, 87);
            this.BtnPaste.TabIndex = 11;
            this.BtnPaste.Text = "جای گذاری";
            this.BtnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPaste.UseVisualStyleBackColor = true;
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::FileManager.Properties.Resources.icons8_edit_property_50px_1;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(308, 8);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(69, 87);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNewFolder
            // 
            this.BtnNewFolder.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewFolder.Image = global::FileManager.Properties.Resources.icons8_folder_50px;
            this.BtnNewFolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNewFolder.Location = new System.Drawing.Point(383, 8);
            this.BtnNewFolder.Name = "BtnNewFolder";
            this.BtnNewFolder.Size = new System.Drawing.Size(69, 87);
            this.BtnNewFolder.TabIndex = 12;
            this.BtnNewFolder.Text = "پوشه جدید";
            this.BtnNewFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewFolder.UseVisualStyleBackColor = true;
            this.BtnNewFolder.Click += new System.EventHandler(this.BtnNewFolder_Click);
            // 
            // BtnCopyFileFromComputer
            // 
            this.BtnCopyFileFromComputer.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyFileFromComputer.Image = global::FileManager.Properties.Resources.icons8_file_50px;
            this.BtnCopyFileFromComputer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCopyFileFromComputer.Location = new System.Drawing.Point(458, 8);
            this.BtnCopyFileFromComputer.Name = "BtnCopyFileFromComputer";
            this.BtnCopyFileFromComputer.Size = new System.Drawing.Size(69, 87);
            this.BtnCopyFileFromComputer.TabIndex = 12;
            this.BtnCopyFileFromComputer.Text = "فایل جدید";
            this.BtnCopyFileFromComputer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCopyFileFromComputer.UseVisualStyleBackColor = true;
            this.BtnCopyFileFromComputer.Click += new System.EventHandler(this.BtnCopyFileFromComputer_Click);
            // 
            // BtnNewDrive
            // 
            this.BtnNewDrive.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewDrive.Image = global::FileManager.Properties.Resources.icons8_C_Drive_50px_1;
            this.BtnNewDrive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNewDrive.Location = new System.Drawing.Point(533, 8);
            this.BtnNewDrive.Name = "BtnNewDrive";
            this.BtnNewDrive.Size = new System.Drawing.Size(69, 87);
            this.BtnNewDrive.TabIndex = 13;
            this.BtnNewDrive.Text = "درایو جدید";
            this.BtnNewDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewDrive.UseVisualStyleBackColor = true;
            this.BtnNewDrive.Click += new System.EventHandler(this.BtnNewDrive_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "FileIcon.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ListDirectoryAndFiles);
            this.panel3.Controls.Add(this.TxtInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 331);
            this.panel3.TabIndex = 6;
            // 
            // ListDirectoryAndFiles
            // 
            this.ListDirectoryAndFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDirectoryAndFiles.HideSelection = false;
            this.ListDirectoryAndFiles.LargeImageList = this.imageList1;
            this.ListDirectoryAndFiles.Location = new System.Drawing.Point(0, 0);
            this.ListDirectoryAndFiles.Name = "ListDirectoryAndFiles";
            this.ListDirectoryAndFiles.Size = new System.Drawing.Size(613, 331);
            this.ListDirectoryAndFiles.SmallImageList = this.imageList1;
            this.ListDirectoryAndFiles.TabIndex = 2;
            this.ListDirectoryAndFiles.UseCompatibleStateImageBehavior = false;
            this.ListDirectoryAndFiles.DoubleClick += new System.EventHandler(this.ListDirectoryAndFiles_DoubleClick);
            // 
            // TxtInfo
            // 
            this.TxtInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.TxtInfo.Location = new System.Drawing.Point(613, 0);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ReadOnly = true;
            this.TxtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInfo.Size = new System.Drawing.Size(240, 331);
            this.TxtInfo.TabIndex = 3;
            this.TxtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.PictureBox BtnBack;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnCut;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNewFolder;
        private System.Windows.Forms.Button BtnCopyFileFromComputer;
        private System.Windows.Forms.Button BtnNewDrive;
        private System.Windows.Forms.Button BtnPaste;
    }
}