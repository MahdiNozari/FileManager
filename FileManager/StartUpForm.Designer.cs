namespace FileManager
{
    partial class StartUpForm
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
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFileSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFileSize)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(12, 49);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(390, 37);
            this.TxtFileName.TabIndex = 1;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(277, 172);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(125, 49);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "ایجاد فایل جدید";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام فایل : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(390, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "سایز فایل (کیلوبایت) : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFileSize
            // 
            this.TxtFileSize.Location = new System.Drawing.Point(12, 129);
            this.TxtFileSize.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.TxtFileSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TxtFileSize.Name = "TxtFileSize";
            this.TxtFileSize.Size = new System.Drawing.Size(390, 37);
            this.TxtFileSize.TabIndex = 3;
            this.TxtFileSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 226);
            this.Controls.Add(this.TxtFileSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.BtnCreate);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtFileSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtFileSize;
    }
}