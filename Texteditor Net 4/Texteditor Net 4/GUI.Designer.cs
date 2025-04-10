namespace Texteditor.NET
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.ts_Hauptmenü = new System.Windows.Forms.MenuStrip();
            this.tsmi_Datei = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Neu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Öffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Speichern_unter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Seite_einrichten = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Drucken = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Bearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Uhreit_Datum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Suchen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ersetzen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Zeilenumbruch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Schriftart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Hintergrundfarbe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Schriftfarbe = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Symbolleiste = new System.Windows.Forms.ToolStrip();
            this.tsb_Neu = new System.Windows.Forms.ToolStripButton();
            this.tsb_Öffnen = new System.Windows.Forms.ToolStripButton();
            this.tsb_Speichern = new System.Windows.Forms.ToolStripButton();
            this.tsb_Drucken = new System.Windows.Forms.ToolStripButton();
            this.tsb_Druckvorschau = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Info = new System.Windows.Forms.ToolStripButton();
            this.ss_Statusleiste = new System.Windows.Forms.StatusStrip();
            this.lbl_Anzahl_Zeichen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Wörter = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Platzhalter = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Zeile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Spalte = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_Editor = new System.Windows.Forms.TextBox();
            this.psd_Seite_einrichten = new System.Windows.Forms.PageSetupDialog();
            this.pd_Druckseite = new System.Drawing.Printing.PrintDocument();
            this.pd_Drucken = new System.Windows.Forms.PrintDialog();
            this.ppd_Druckvorschau = new System.Windows.Forms.PrintPreviewDialog();
            this.ft_Schriftart = new System.Windows.Forms.FontDialog();
            this.cd_Farbe = new System.Windows.Forms.ColorDialog();
            this.ts_Hauptmenü.SuspendLayout();
            this.ts_Symbolleiste.SuspendLayout();
            this.ss_Statusleiste.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Hauptmenü
            // 
            this.ts_Hauptmenü.GripMargin = new System.Windows.Forms.Padding(0);
            this.ts_Hauptmenü.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts_Hauptmenü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Datei,
            this.tsmi_Bearbeiten,
            this.tsmi_Format});
            this.ts_Hauptmenü.Location = new System.Drawing.Point(0, 0);
            this.ts_Hauptmenü.Name = "ts_Hauptmenü";
            this.ts_Hauptmenü.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.ts_Hauptmenü.Size = new System.Drawing.Size(653, 24);
            this.ts_Hauptmenü.TabIndex = 0;
            this.ts_Hauptmenü.Text = "Hauptmenü";
            // 
            // tsmi_Datei
            // 
            this.tsmi_Datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Neu,
            this.toolStripMenuItem1,
            this.tsmi_Öffnen,
            this.tsmi_Speichern,
            this.tsmi_Speichern_unter,
            this.toolStripMenuItem2,
            this.tsmi_Seite_einrichten,
            this.tsmi_Drucken,
            this.toolStripMenuItem3,
            this.tsmi_Beenden});
            this.tsmi_Datei.Name = "tsmi_Datei";
            this.tsmi_Datei.Size = new System.Drawing.Size(46, 22);
            this.tsmi_Datei.Text = "&Datei";
            // 
            // tsmi_Neu
            // 
            this.tsmi_Neu.Name = "tsmi_Neu";
            this.tsmi_Neu.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Neu.Text = "&Neu";
            this.tsmi_Neu.Click += new System.EventHandler(this.CreateNewDocument);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmi_Öffnen
            // 
            this.tsmi_Öffnen.Name = "tsmi_Öffnen";
            this.tsmi_Öffnen.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Öffnen.Text = "&Öffnen...";
            this.tsmi_Öffnen.Click += new System.EventHandler(this.OpenDocument);
            // 
            // tsmi_Speichern
            // 
            this.tsmi_Speichern.Name = "tsmi_Speichern";
            this.tsmi_Speichern.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Speichern.Text = "&Speichern";
            this.tsmi_Speichern.Click += new System.EventHandler(this.SaveDocument);
            // 
            // tsmi_Speichern_unter
            // 
            this.tsmi_Speichern_unter.Name = "tsmi_Speichern_unter";
            this.tsmi_Speichern_unter.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Speichern_unter.Text = "Speichern &unter...";
            this.tsmi_Speichern_unter.Click += new System.EventHandler(this.SaveDocumentAs);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmi_Seite_einrichten
            // 
            this.tsmi_Seite_einrichten.Name = "tsmi_Seite_einrichten";
            this.tsmi_Seite_einrichten.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Seite_einrichten.Text = "Seite einricht&en...";
            this.tsmi_Seite_einrichten.Click += new System.EventHandler(this.tsmi_Seite_einrichten_Click);
            // 
            // tsmi_Drucken
            // 
            this.tsmi_Drucken.Name = "tsmi_Drucken";
            this.tsmi_Drucken.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Drucken.Text = "&Drucken...";
            this.tsmi_Drucken.Click += new System.EventHandler(this.tsmi_Drucken_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmi_Beenden
            // 
            this.tsmi_Beenden.Name = "tsmi_Beenden";
            this.tsmi_Beenden.Size = new System.Drawing.Size(166, 22);
            this.tsmi_Beenden.Text = "&Beenden";
            this.tsmi_Beenden.Click += new System.EventHandler(this.CloseApplication);
            // 
            // tsmi_Bearbeiten
            // 
            this.tsmi_Bearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Uhreit_Datum,
            this.tsmi_Suchen,
            this.tsmi_Ersetzen});
            this.tsmi_Bearbeiten.Name = "tsmi_Bearbeiten";
            this.tsmi_Bearbeiten.Size = new System.Drawing.Size(75, 22);
            this.tsmi_Bearbeiten.Text = "Bearbeiten";
            // 
            // tsmi_Uhreit_Datum
            // 
            this.tsmi_Uhreit_Datum.Name = "tsmi_Uhreit_Datum";
            this.tsmi_Uhreit_Datum.Size = new System.Drawing.Size(158, 22);
            this.tsmi_Uhreit_Datum.Text = "&Uhrzeit / Datum";
            this.tsmi_Uhreit_Datum.Click += new System.EventHandler(this.uhrzeitToolStripMenuItem_Click);
            // 
            // tsmi_Suchen
            // 
            this.tsmi_Suchen.Name = "tsmi_Suchen";
            this.tsmi_Suchen.Size = new System.Drawing.Size(158, 22);
            this.tsmi_Suchen.Text = "Suchen";
            this.tsmi_Suchen.Click += new System.EventHandler(this.tsmi_Suchen_Click);
            // 
            // tsmi_Ersetzen
            // 
            this.tsmi_Ersetzen.Name = "tsmi_Ersetzen";
            this.tsmi_Ersetzen.Size = new System.Drawing.Size(158, 22);
            this.tsmi_Ersetzen.Text = "Ersetzen";
            this.tsmi_Ersetzen.Click += new System.EventHandler(this.tsmi_Ersetzen_Click);
            // 
            // tsmi_Format
            // 
            this.tsmi_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Zeilenumbruch,
            this.tsmi_Schriftart,
            this.toolStripMenuItem4,
            this.tsmi_Hintergrundfarbe,
            this.tsmi_Schriftfarbe});
            this.tsmi_Format.Name = "tsmi_Format";
            this.tsmi_Format.Size = new System.Drawing.Size(57, 22);
            this.tsmi_Format.Text = "&Format";
            // 
            // tsmi_Zeilenumbruch
            // 
            this.tsmi_Zeilenumbruch.Checked = true;
            this.tsmi_Zeilenumbruch.CheckOnClick = true;
            this.tsmi_Zeilenumbruch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_Zeilenumbruch.Name = "tsmi_Zeilenumbruch";
            this.tsmi_Zeilenumbruch.Size = new System.Drawing.Size(175, 22);
            this.tsmi_Zeilenumbruch.Text = "Zeilen&umbruch";
            this.tsmi_Zeilenumbruch.Click += new System.EventHandler(this.SwitchWordwrap);
            // 
            // tsmi_Schriftart
            // 
            this.tsmi_Schriftart.Name = "tsmi_Schriftart";
            this.tsmi_Schriftart.Size = new System.Drawing.Size(175, 22);
            this.tsmi_Schriftart.Text = "&Schriftart...";
            this.tsmi_Schriftart.Click += new System.EventHandler(this.ChangeFont);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmi_Hintergrundfarbe
            // 
            this.tsmi_Hintergrundfarbe.Name = "tsmi_Hintergrundfarbe";
            this.tsmi_Hintergrundfarbe.Size = new System.Drawing.Size(175, 22);
            this.tsmi_Hintergrundfarbe.Text = "&Hintergrundfarbe...";
            this.tsmi_Hintergrundfarbe.Click += new System.EventHandler(this.ChangeBackgroundColor);
            // 
            // tsmi_Schriftfarbe
            // 
            this.tsmi_Schriftfarbe.Name = "tsmi_Schriftfarbe";
            this.tsmi_Schriftfarbe.Size = new System.Drawing.Size(175, 22);
            this.tsmi_Schriftfarbe.Text = "Schrift&farbe...";
            this.tsmi_Schriftfarbe.Click += new System.EventHandler(this.ChangeForegroundColor);
            // 
            // ts_Symbolleiste
            // 
            this.ts_Symbolleiste.GripMargin = new System.Windows.Forms.Padding(0);
            this.ts_Symbolleiste.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts_Symbolleiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Neu,
            this.tsb_Öffnen,
            this.tsb_Speichern,
            this.tsb_Drucken,
            this.tsb_Druckvorschau,
            this.toolStripSeparator,
            this.tsb_Info});
            this.ts_Symbolleiste.Location = new System.Drawing.Point(0, 24);
            this.ts_Symbolleiste.Name = "ts_Symbolleiste";
            this.ts_Symbolleiste.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts_Symbolleiste.Size = new System.Drawing.Size(653, 31);
            this.ts_Symbolleiste.TabIndex = 1;
            this.ts_Symbolleiste.Text = "Symbolleiste";
            // 
            // tsb_Neu
            // 
            this.tsb_Neu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Neu.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Neu.Image")));
            this.tsb_Neu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Neu.Name = "tsb_Neu";
            this.tsb_Neu.Size = new System.Drawing.Size(28, 28);
            this.tsb_Neu.Text = "&Neu";
            this.tsb_Neu.Click += new System.EventHandler(this.CreateNewDocument);
            // 
            // tsb_Öffnen
            // 
            this.tsb_Öffnen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Öffnen.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Öffnen.Image")));
            this.tsb_Öffnen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Öffnen.Name = "tsb_Öffnen";
            this.tsb_Öffnen.Size = new System.Drawing.Size(28, 28);
            this.tsb_Öffnen.Text = "Ö&ffnen";
            this.tsb_Öffnen.Click += new System.EventHandler(this.OpenDocument);
            // 
            // tsb_Speichern
            // 
            this.tsb_Speichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Speichern.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Speichern.Image")));
            this.tsb_Speichern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Speichern.Name = "tsb_Speichern";
            this.tsb_Speichern.Size = new System.Drawing.Size(28, 28);
            this.tsb_Speichern.Text = "&Speichern";
            this.tsb_Speichern.Click += new System.EventHandler(this.SaveDocument);
            // 
            // tsb_Drucken
            // 
            this.tsb_Drucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Drucken.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Drucken.Image")));
            this.tsb_Drucken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Drucken.Name = "tsb_Drucken";
            this.tsb_Drucken.Size = new System.Drawing.Size(28, 28);
            this.tsb_Drucken.Text = "&Drucken";
            this.tsb_Drucken.Click += new System.EventHandler(this.tsmi_Drucken_Click);
            // 
            // tsb_Druckvorschau
            // 
            this.tsb_Druckvorschau.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Druckvorschau.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Druckvorschau.Image")));
            this.tsb_Druckvorschau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Druckvorschau.Name = "tsb_Druckvorschau";
            this.tsb_Druckvorschau.Size = new System.Drawing.Size(28, 28);
            this.tsb_Druckvorschau.Text = "Druckvorschau";
            this.tsb_Druckvorschau.Click += new System.EventHandler(this.tsb_Druckvorschau_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_Info
            // 
            this.tsb_Info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Info.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Info.Image")));
            this.tsb_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Info.Name = "tsb_Info";
            this.tsb_Info.Size = new System.Drawing.Size(28, 28);
            this.tsb_Info.Text = "&Info";
            this.tsb_Info.Click += new System.EventHandler(this.tsb_Info_Click);
            // 
            // ss_Statusleiste
            // 
            this.ss_Statusleiste.GripMargin = new System.Windows.Forms.Padding(0);
            this.ss_Statusleiste.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ss_Statusleiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Anzahl_Zeichen,
            this.lbl_Wörter,
            this.lbl_Platzhalter,
            this.lbl_Zeile,
            this.lbl_Spalte});
            this.ss_Statusleiste.Location = new System.Drawing.Point(0, 597);
            this.ss_Statusleiste.Name = "ss_Statusleiste";
            this.ss_Statusleiste.Size = new System.Drawing.Size(653, 22);
            this.ss_Statusleiste.TabIndex = 2;
            this.ss_Statusleiste.Text = "Statuszeile";
            // 
            // lbl_Anzahl_Zeichen
            // 
            this.lbl_Anzahl_Zeichen.Name = "lbl_Anzahl_Zeichen";
            this.lbl_Anzahl_Zeichen.Size = new System.Drawing.Size(98, 17);
            this.lbl_Anzahl_Zeichen.Text = "Zeichenanzahl : 0";
            // 
            // lbl_Wörter
            // 
            this.lbl_Wörter.Name = "lbl_Wörter";
            this.lbl_Wörter.Size = new System.Drawing.Size(58, 17);
            this.lbl_Wörter.Text = "Wörter : 0";
            // 
            // lbl_Platzhalter
            // 
            this.lbl_Platzhalter.Name = "lbl_Platzhalter";
            this.lbl_Platzhalter.Size = new System.Drawing.Size(381, 17);
            this.lbl_Platzhalter.Spring = true;
            // 
            // lbl_Zeile
            // 
            this.lbl_Zeile.Name = "lbl_Zeile";
            this.lbl_Zeile.Size = new System.Drawing.Size(47, 17);
            this.lbl_Zeile.Text = "Zeile : 1";
            // 
            // lbl_Spalte
            // 
            this.lbl_Spalte.Name = "lbl_Spalte";
            this.lbl_Spalte.Size = new System.Drawing.Size(54, 17);
            this.lbl_Spalte.Text = "Spalte : 1";
            // 
            // tb_Editor
            // 
            this.tb_Editor.AcceptsTab = true;
            this.tb_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Editor.HideSelection = false;
            this.tb_Editor.Location = new System.Drawing.Point(0, 55);
            this.tb_Editor.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Editor.Multiline = true;
            this.tb_Editor.Name = "tb_Editor";
            this.tb_Editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Editor.Size = new System.Drawing.Size(653, 542);
            this.tb_Editor.TabIndex = 3;
            this.tb_Editor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Editor_MouseClick);
            this.tb_Editor.TextChanged += new System.EventHandler(this.tb_Editor_TextChanged);
            this.tb_Editor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Editor_KeyDown);
            this.tb_Editor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Editor_KeyPress);
            this.tb_Editor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Editor_KeyUp);
            // 
            // psd_Seite_einrichten
            // 
            this.psd_Seite_einrichten.Document = this.pd_Druckseite;
            this.psd_Seite_einrichten.EnableMetric = true;
            // 
            // pd_Druckseite
            // 
            this.pd_Druckseite.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_Druckseite_PrintPage);
            // 
            // pd_Drucken
            // 
            this.pd_Drucken.AllowCurrentPage = true;
            this.pd_Drucken.AllowSelection = true;
            this.pd_Drucken.AllowSomePages = true;
            this.pd_Drucken.Document = this.pd_Druckseite;
            this.pd_Drucken.UseEXDialog = true;
            // 
            // ppd_Druckvorschau
            // 
            this.ppd_Druckvorschau.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd_Druckvorschau.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd_Druckvorschau.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd_Druckvorschau.Document = this.pd_Druckseite;
            this.ppd_Druckvorschau.Enabled = true;
            this.ppd_Druckvorschau.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd_Druckvorschau.Icon")));
            this.ppd_Druckvorschau.Name = "ppd_Druckvorschau";
            this.ppd_Druckvorschau.Visible = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 619);
            this.Controls.Add(this.tb_Editor);
            this.Controls.Add(this.ss_Statusleiste);
            this.Controls.Add(this.ts_Symbolleiste);
            this.Controls.Add(this.ts_Hauptmenü);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.ts_Hauptmenü;
            this.Name = "GUI";
            this.Text = "Texteditor.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
            this.ts_Hauptmenü.ResumeLayout(false);
            this.ts_Hauptmenü.PerformLayout();
            this.ts_Symbolleiste.ResumeLayout(false);
            this.ts_Symbolleiste.PerformLayout();
            this.ss_Statusleiste.ResumeLayout(false);
            this.ss_Statusleiste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ts_Hauptmenü;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Datei;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Neu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Öffnen;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Speichern;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Speichern_unter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Seite_einrichten;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Format;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Drucken;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Beenden;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Zeilenumbruch;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Schriftart;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Hintergrundfarbe;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Schriftfarbe;
        private System.Windows.Forms.ToolStrip ts_Symbolleiste;
        private System.Windows.Forms.ToolStripButton tsb_Neu;
        private System.Windows.Forms.ToolStripButton tsb_Öffnen;
        private System.Windows.Forms.ToolStripButton tsb_Speichern;
        private System.Windows.Forms.ToolStripButton tsb_Drucken;
        private System.Windows.Forms.ToolStripButton tsb_Druckvorschau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_Info;
        private System.Windows.Forms.StatusStrip ss_Statusleiste;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Anzahl_Zeichen;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Platzhalter;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Zeile;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Spalte;
        private System.Windows.Forms.TextBox tb_Editor;
        private System.Windows.Forms.PageSetupDialog psd_Seite_einrichten;
        private System.Windows.Forms.PrintDialog pd_Drucken;
        private System.Windows.Forms.PrintPreviewDialog ppd_Druckvorschau;
        private System.Drawing.Printing.PrintDocument pd_Druckseite;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Wörter;
        private System.Windows.Forms.FontDialog ft_Schriftart;
        private System.Windows.Forms.ColorDialog cd_Farbe;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Bearbeiten;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Uhreit_Datum;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Suchen;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ersetzen;
    }
}

