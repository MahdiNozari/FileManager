namespace FileManager
{
    partial class FolderInfoForm
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
            this.BtnCreateOrEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 49);
            this.TxtName.MaxLength = 30;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(390, 37);
            this.TxtName.TabIndex = 3;
            // 
            // BtnCreateOrEdit
            // 
            this.BtnCreateOrEdit.Location = new System.Drawing.Point(255, 92);
            this.BtnCreateOrEdit.Name = "BtnCreateOrEdit";
            this.BtnCreateOrEdit.Size = new System.Drawing.Size(147, 49);
            this.BtnCreateOrEdit.TabIndex = 6;
            this.BtnCreateOrEdit.Text = "ایجاد پوشه";
            this.BtnCreateOrEdit.UseVisualStyleBackColor = true;
            this.BtnCreateOrEdit.Click += new System.EventHandler(this.BtnCreateOrEdit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام پوشه : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnCreateOrEdit);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FolderInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnCreateOrEdit;
        private System.Windows.Forms.Label label1;
    }
}