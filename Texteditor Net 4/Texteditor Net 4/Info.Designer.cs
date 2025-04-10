namespace Texteditor.NET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lbl_Programname = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.btn_Schließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Programname
            // 
            this.lbl_Programname.AutoSize = true;
            this.lbl_Programname.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Programname.Location = new System.Drawing.Point(75, 19);
            this.lbl_Programname.Name = "lbl_Programname";
            this.lbl_Programname.Size = new System.Drawing.Size(131, 24);
            this.lbl_Programname.TabIndex = 0;
            this.lbl_Programname.Text = "Texteditor.NET";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.Location = new System.Drawing.Point(89, 53);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(103, 24);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "Version 1.0";
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyright.Location = new System.Drawing.Point(13, 87);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(247, 24);
            this.lbl_Copyright.TabIndex = 2;
            this.lbl_Copyright.Text = "Copyright © 2023 Jonas Wolf";
            // 
            // btn_Schließen
            // 
            this.btn_Schließen.Location = new System.Drawing.Point(103, 121);
            this.btn_Schließen.Name = "btn_Schließen";
            this.btn_Schließen.Size = new System.Drawing.Size(75, 23);
            this.btn_Schließen.TabIndex = 3;
            this.btn_Schließen.Text = "Schließen";
            this.btn_Schließen.UseVisualStyleBackColor = true;
            this.btn_Schließen.Click += new System.EventHandler(this.btn_Schließen_Click);
            // 
            // Info
            // 
            this.AcceptButton = this.btn_Schließen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 162);
            this.Controls.Add(this.btn_Schließen);
            this.Controls.Add(this.lbl_Copyright);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Programname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Programname;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Button btn_Schließen;
    }
}