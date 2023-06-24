namespace FileManager
{
    partial class DriveInfoForm
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbLabel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblFreeSpace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 129);
            this.TxtName.MaxLength = 30;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(390, 37);
            this.TxtName.TabIndex = 3;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(307, 252);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(95, 49);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "ایجاد درایو";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام درایو : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(390, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "سایز درایو (کیلوبایت) : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(12, 209);
            this.TxtSize.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.TxtSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(390, 37);
            this.TxtSize.TabIndex = 5;
            this.TxtSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(390, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "درایو : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbLabel
            // 
            this.CmbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLabel.FormattingEnabled = true;
            this.CmbLabel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CmbLabel.Location = new System.Drawing.Point(12, 49);
            this.CmbLabel.Name = "CmbLabel";
            this.CmbLabel.Size = new System.Drawing.Size(390, 37);
            this.CmbLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 258);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(150, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "فضای خالی هارد : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFreeSpace
            // 
            this.LblFreeSpace.Location = new System.Drawing.Point(12, 258);
            this.LblFreeSpace.Name = "LblFreeSpace";
            this.LblFreeSpace.Size = new System.Drawing.Size(133, 37);
            this.LblFreeSpace.TabIndex = 8;
            this.LblFreeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriveInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 303);
            this.Controls.Add(this.CmbLabel);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblFreeSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnCreate);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DriveInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DriceInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblFreeSpace;
    }
}