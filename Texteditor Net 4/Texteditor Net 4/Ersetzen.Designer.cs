namespace Texteditor.NET
{
    partial class Ersetzen
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
            this.lbl_Suche_nach = new System.Windows.Forms.Label();
            this.lbl_Ersetzen_durch = new System.Windows.Forms.Label();
            this.btn_Weitersuchen = new System.Windows.Forms.Button();
            this.btn_Ersetzen = new System.Windows.Forms.Button();
            this.btn_Alle_ersetzen = new System.Windows.Forms.Button();
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.cb_Groß_Kleinschreibung = new System.Windows.Forms.CheckBox();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.tb_Ersetzen = new System.Windows.Forms.TextBox();
            this.cb_Von_vorn = new System.Windows.Forms.CheckBox();
            this.btn_Verschlüsseln = new System.Windows.Forms.Button();
            this.btn_Entschlüsseln = new System.Windows.Forms.Button();
            this.nud_Rotation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Suche_nach
            // 
            this.lbl_Suche_nach.AutoSize = true;
            this.lbl_Suche_nach.Location = new System.Drawing.Point(19, 19);
            this.lbl_Suche_nach.Margin = new System.Windows.Forms.Padding(13, 13, 2, 0);
            this.lbl_Suche_nach.Name = "lbl_Suche_nach";
            this.lbl_Suche_nach.Size = new System.Drawing.Size(71, 13);
            this.lbl_Suche_nach.TabIndex = 0;
            this.lbl_Suche_nach.Text = "Suche nach :";
            // 
            // lbl_Ersetzen_durch
            // 
            this.lbl_Ersetzen_durch.AutoSize = true;
            this.lbl_Ersetzen_durch.Location = new System.Drawing.Point(19, 45);
            this.lbl_Ersetzen_durch.Margin = new System.Windows.Forms.Padding(13, 13, 2, 0);
            this.lbl_Ersetzen_durch.Name = "lbl_Ersetzen_durch";
            this.lbl_Ersetzen_durch.Size = new System.Drawing.Size(87, 13);
            this.lbl_Ersetzen_durch.TabIndex = 1;
            this.lbl_Ersetzen_durch.Text = "Ersetzen durch : ";
            // 
            // btn_Weitersuchen
            // 
            this.btn_Weitersuchen.Location = new System.Drawing.Point(362, 15);
            this.btn_Weitersuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Weitersuchen.Name = "btn_Weitersuchen";
            this.btn_Weitersuchen.Size = new System.Drawing.Size(97, 25);
            this.btn_Weitersuchen.TabIndex = 2;
            this.btn_Weitersuchen.Text = "Weitersuchen";
            this.btn_Weitersuchen.UseVisualStyleBackColor = true;
            this.btn_Weitersuchen.Click += new System.EventHandler(this.btn_Weitersuchen_Click);
            // 
            // btn_Ersetzen
            // 
            this.btn_Ersetzen.Location = new System.Drawing.Point(362, 44);
            this.btn_Ersetzen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ersetzen.Name = "btn_Ersetzen";
            this.btn_Ersetzen.Size = new System.Drawing.Size(97, 25);
            this.btn_Ersetzen.TabIndex = 3;
            this.btn_Ersetzen.Text = "Ersetzen";
            this.btn_Ersetzen.UseVisualStyleBackColor = true;
            this.btn_Ersetzen.Click += new System.EventHandler(this.btn_Ersetzen_Click);
            // 
            // btn_Alle_ersetzen
            // 
            this.btn_Alle_ersetzen.Location = new System.Drawing.Point(362, 72);
            this.btn_Alle_ersetzen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Alle_ersetzen.Name = "btn_Alle_ersetzen";
            this.btn_Alle_ersetzen.Size = new System.Drawing.Size(97, 25);
            this.btn_Alle_ersetzen.TabIndex = 4;
            this.btn_Alle_ersetzen.Text = "Alle ersetzen";
            this.btn_Alle_ersetzen.UseVisualStyleBackColor = true;
            this.btn_Alle_ersetzen.Click += new System.EventHandler(this.btn_Alle_ersetzen_Click);
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Location = new System.Drawing.Point(362, 119);
            this.btn_abbrechen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(97, 25);
            this.btn_abbrechen.TabIndex = 5;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // cb_Groß_Kleinschreibung
            // 
            this.cb_Groß_Kleinschreibung.AutoSize = true;
            this.cb_Groß_Kleinschreibung.Location = new System.Drawing.Point(22, 106);
            this.cb_Groß_Kleinschreibung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Groß_Kleinschreibung.Name = "cb_Groß_Kleinschreibung";
            this.cb_Groß_Kleinschreibung.Size = new System.Drawing.Size(180, 17);
            this.cb_Groß_Kleinschreibung.TabIndex = 6;
            this.cb_Groß_Kleinschreibung.Text = "Groß-/Kleinschreibung beachten";
            this.cb_Groß_Kleinschreibung.UseVisualStyleBackColor = true;
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Location = new System.Drawing.Point(109, 15);
            this.tb_Suchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(250, 20);
            this.tb_Suchen.TabIndex = 8;
            // 
            // tb_Ersetzen
            // 
            this.tb_Ersetzen.Location = new System.Drawing.Point(109, 41);
            this.tb_Ersetzen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Ersetzen.Name = "tb_Ersetzen";
            this.tb_Ersetzen.Size = new System.Drawing.Size(250, 20);
            this.tb_Ersetzen.TabIndex = 9;
            // 
            // cb_Von_vorn
            // 
            this.cb_Von_vorn.AutoSize = true;
            this.cb_Von_vorn.Checked = true;
            this.cb_Von_vorn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Von_vorn.Location = new System.Drawing.Point(22, 127);
            this.cb_Von_vorn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Von_vorn.Name = "cb_Von_vorn";
            this.cb_Von_vorn.Size = new System.Drawing.Size(167, 17);
            this.cb_Von_vorn.TabIndex = 10;
            this.cb_Von_vorn.Text = "Am Ende von vorne beginnen";
            this.cb_Von_vorn.UseVisualStyleBackColor = true;
            // 
            // btn_Verschlüsseln
            // 
            this.btn_Verschlüsseln.Location = new System.Drawing.Point(109, 65);
            this.btn_Verschlüsseln.Name = "btn_Verschlüsseln";
            this.btn_Verschlüsseln.Size = new System.Drawing.Size(97, 25);
            this.btn_Verschlüsseln.TabIndex = 11;
            this.btn_Verschlüsseln.Text = "Verschlüsseln";
            this.btn_Verschlüsseln.UseVisualStyleBackColor = true;
            this.btn_Verschlüsseln.Click += new System.EventHandler(this.btn_Verschlüsseln_Click);
            // 
            // btn_Entschlüsseln
            // 
            this.btn_Entschlüsseln.Location = new System.Drawing.Point(212, 66);
            this.btn_Entschlüsseln.Name = "btn_Entschlüsseln";
            this.btn_Entschlüsseln.Size = new System.Drawing.Size(97, 25);
            this.btn_Entschlüsseln.TabIndex = 12;
            this.btn_Entschlüsseln.Text = "Entschlüsseln";
            this.btn_Entschlüsseln.UseVisualStyleBackColor = true;
            this.btn_Entschlüsseln.Click += new System.EventHandler(this.btn_Entschlüsseln_Click);
            // 
            // nud_Rotation
            // 
            this.nud_Rotation.Location = new System.Drawing.Point(57, 70);
            this.nud_Rotation.Name = "nud_Rotation";
            this.nud_Rotation.Size = new System.Drawing.Size(46, 20);
            this.nud_Rotation.TabIndex = 15;
            // 
            // Ersetzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 157);
            this.Controls.Add(this.nud_Rotation);
            this.Controls.Add(this.btn_Entschlüsseln);
            this.Controls.Add(this.btn_Verschlüsseln);
            this.Controls.Add(this.cb_Von_vorn);
            this.Controls.Add(this.tb_Ersetzen);
            this.Controls.Add(this.tb_Suchen);
            this.Controls.Add(this.cb_Groß_Kleinschreibung);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.btn_Alle_ersetzen);
            this.Controls.Add(this.btn_Ersetzen);
            this.Controls.Add(this.btn_Weitersuchen);
            this.Controls.Add(this.lbl_Ersetzen_durch);
            this.Controls.Add(this.lbl_Suche_nach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ersetzen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ersetzen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ersetzen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Suche_nach;
        private System.Windows.Forms.Label lbl_Ersetzen_durch;
        private System.Windows.Forms.Button btn_Weitersuchen;
        private System.Windows.Forms.Button btn_Ersetzen;
        private System.Windows.Forms.Button btn_Alle_ersetzen;
        private System.Windows.Forms.Button btn_abbrechen;
        private System.Windows.Forms.CheckBox cb_Groß_Kleinschreibung;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.TextBox tb_Ersetzen;
        private System.Windows.Forms.CheckBox cb_Von_vorn;
        private System.Windows.Forms.Button btn_Verschlüsseln;
        private System.Windows.Forms.Button btn_Entschlüsseln;
        private System.Windows.Forms.NumericUpDown nud_Rotation;
    }
}