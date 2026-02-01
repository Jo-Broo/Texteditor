namespace Texteditor.NET
{
    partial class Suchen
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
            this.lbl_Suchen_nach = new System.Windows.Forms.Label();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gp_Suchrichtung = new System.Windows.Forms.GroupBox();
            this.rb_Nach_unten = new System.Windows.Forms.RadioButton();
            this.rb_Nach_oben = new System.Windows.Forms.RadioButton();
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.btn_Weitersuchen = new System.Windows.Forms.Button();
            this.cb_Von_vorn = new System.Windows.Forms.CheckBox();
            this.cb_Groß_Kleinschreibung = new System.Windows.Forms.CheckBox();
            this.gp_Suchrichtung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Suchen_nach
            // 
            this.lbl_Suchen_nach.AutoSize = true;
            this.lbl_Suchen_nach.Location = new System.Drawing.Point(29, 29);
            this.lbl_Suchen_nach.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.lbl_Suchen_nach.Name = "lbl_Suchen_nach";
            this.lbl_Suchen_nach.Size = new System.Drawing.Size(107, 20);
            this.lbl_Suchen_nach.TabIndex = 0;
            this.lbl_Suchen_nach.Text = "Suchen nach:";
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Location = new System.Drawing.Point(142, 23);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(487, 26);
            this.tb_Suchen.TabIndex = 1;
            // 
            // gp_Suchrichtung
            // 
            this.gp_Suchrichtung.Controls.Add(this.rb_Nach_unten);
            this.gp_Suchrichtung.Controls.Add(this.rb_Nach_oben);
            this.gp_Suchrichtung.Location = new System.Drawing.Point(350, 85);
            this.gp_Suchrichtung.Name = "gp_Suchrichtung";
            this.gp_Suchrichtung.Size = new System.Drawing.Size(279, 80);
            this.gp_Suchrichtung.TabIndex = 2;
            this.gp_Suchrichtung.TabStop = false;
            this.gp_Suchrichtung.Text = "Suchrichtung";
            // 
            // rb_Nach_unten
            // 
            this.rb_Nach_unten.AutoSize = true;
            this.rb_Nach_unten.Checked = true;
            this.rb_Nach_unten.Location = new System.Drawing.Point(147, 42);
            this.rb_Nach_unten.Name = "rb_Nach_unten";
            this.rb_Nach_unten.Size = new System.Drawing.Size(116, 24);
            this.rb_Nach_unten.TabIndex = 1;
            this.rb_Nach_unten.TabStop = true;
            this.rb_Nach_unten.Text = "Nach unten";
            this.rb_Nach_unten.UseVisualStyleBackColor = true;
            // 
            // rb_Nach_oben
            // 
            this.rb_Nach_oben.AutoSize = true;
            this.rb_Nach_oben.Location = new System.Drawing.Point(30, 42);
            this.rb_Nach_oben.Name = "rb_Nach_oben";
            this.rb_Nach_oben.Size = new System.Drawing.Size(111, 24);
            this.rb_Nach_oben.TabIndex = 0;
            this.rb_Nach_oben.Text = "Nach oben";
            this.rb_Nach_oben.UseVisualStyleBackColor = true;
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Location = new System.Drawing.Point(665, 55);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(145, 38);
            this.btn_abbrechen.TabIndex = 7;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // btn_Weitersuchen
            // 
            this.btn_Weitersuchen.Location = new System.Drawing.Point(665, 11);
            this.btn_Weitersuchen.Name = "btn_Weitersuchen";
            this.btn_Weitersuchen.Size = new System.Drawing.Size(145, 38);
            this.btn_Weitersuchen.TabIndex = 6;
            this.btn_Weitersuchen.Text = "Weitersuchen";
            this.btn_Weitersuchen.UseVisualStyleBackColor = true;
            this.btn_Weitersuchen.Click += new System.EventHandler(this.btn_Weitersuchen_Click);
            // 
            // cb_Von_vorn
            // 
            this.cb_Von_vorn.AutoSize = true;
            this.cb_Von_vorn.Checked = true;
            this.cb_Von_vorn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Von_vorn.Location = new System.Drawing.Point(33, 141);
            this.cb_Von_vorn.Name = "cb_Von_vorn";
            this.cb_Von_vorn.Size = new System.Drawing.Size(243, 24);
            this.cb_Von_vorn.TabIndex = 9;
            this.cb_Von_vorn.Text = "Am Ende von vorne beginnen";
            this.cb_Von_vorn.UseVisualStyleBackColor = true;
            this.cb_Von_vorn.CheckedChanged += new System.EventHandler(this.Reset_Selection);
            // 
            // cb_Groß_Kleinschreibung
            // 
            this.cb_Groß_Kleinschreibung.AutoSize = true;
            this.cb_Groß_Kleinschreibung.Location = new System.Drawing.Point(33, 111);
            this.cb_Groß_Kleinschreibung.Name = "cb_Groß_Kleinschreibung";
            this.cb_Groß_Kleinschreibung.Size = new System.Drawing.Size(193, 24);
            this.cb_Groß_Kleinschreibung.TabIndex = 8;
            this.cb_Groß_Kleinschreibung.Text = "Groß-/Kleinschreibung";
            this.cb_Groß_Kleinschreibung.UseVisualStyleBackColor = true;
            this.cb_Groß_Kleinschreibung.CheckedChanged += new System.EventHandler(this.Reset_Selection);
            // 
            // Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 193);
            this.Controls.Add(this.cb_Von_vorn);
            this.Controls.Add(this.cb_Groß_Kleinschreibung);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.btn_Weitersuchen);
            this.Controls.Add(this.gp_Suchrichtung);
            this.Controls.Add(this.tb_Suchen);
            this.Controls.Add(this.lbl_Suchen_nach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suchen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suchen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Suchen_FormClosing);
            this.gp_Suchrichtung.ResumeLayout(false);
            this.gp_Suchrichtung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Suchen_nach;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.GroupBox gp_Suchrichtung;
        private System.Windows.Forms.RadioButton rb_Nach_unten;
        private System.Windows.Forms.RadioButton rb_Nach_oben;
        private System.Windows.Forms.Button btn_abbrechen;
        private System.Windows.Forms.Button btn_Weitersuchen;
        private System.Windows.Forms.CheckBox cb_Von_vorn;
        private System.Windows.Forms.CheckBox cb_Groß_Kleinschreibung;
    }
}