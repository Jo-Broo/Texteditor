namespace Texteditor
{
    partial class Info
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
            this.lbl_Version = new Label();
            this.lbl_CopyRight = new Label();
            this.SuspendLayout();
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new Font("Segoe UI", 15F);
            this.lbl_Version.Location = new Point(12, 9);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new Size(141, 28);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "Version: 0.0.0.0";
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.Font = new Font("Segoe UI", 15F);
            this.lbl_CopyRight.Location = new Point(12, 47);
            this.lbl_CopyRight.Margin = new Padding(3, 10, 3, 0);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new Size(271, 28);
            this.lbl_CopyRight.TabIndex = 1;
            this.lbl_CopyRight.Text = "Copyright © 2023 Jonas Wolf";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(295, 92);
            this.Controls.Add(this.lbl_CopyRight);
            this.Controls.Add(this.lbl_Version);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lbl_Version;
        private Label lbl_CopyRight;
    }
}