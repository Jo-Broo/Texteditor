namespace Texteditor.Encryptions.GUIs
{
    partial class Caesar
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
            this.nud_Rotation = new NumericUpDown();
            this.btn_Encrypt = new Button();
            this.btn_Decrypt = new Button();
            this.lbl_Rotation = new Label();
            ((System.ComponentModel.ISupportInitialize)this.nud_Rotation).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Rotation
            // 
            this.nud_Rotation.Location = new Point(73, 7);
            this.nud_Rotation.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            this.nud_Rotation.Name = "nud_Rotation";
            this.nud_Rotation.Size = new Size(40, 23);
            this.nud_Rotation.TabIndex = 0;
            this.nud_Rotation.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new Point(12, 36);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new Size(97, 23);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Verschlüsseln";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += this.OnEncryptClick;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new Point(115, 36);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new Size(97, 23);
            this.btn_Decrypt.TabIndex = 2;
            this.btn_Decrypt.Text = "Entschlüsseln";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += this.OnDecryptClick;
            // 
            // lbl_Rotation
            // 
            this.lbl_Rotation.AutoSize = true;
            this.lbl_Rotation.Location = new Point(12, 9);
            this.lbl_Rotation.Name = "lbl_Rotation";
            this.lbl_Rotation.Size = new Size(55, 15);
            this.lbl_Rotation.TabIndex = 3;
            this.lbl_Rotation.Text = "Rotation:";
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(222, 71);
            this.Controls.Add(this.lbl_Rotation);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.nud_Rotation);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Caesar";
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Caesar";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)this.nud_Rotation).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private NumericUpDown nud_Rotation;
        private Button btn_Encrypt;
        private Button btn_Decrypt;
        private Label lbl_Rotation;
    }
}