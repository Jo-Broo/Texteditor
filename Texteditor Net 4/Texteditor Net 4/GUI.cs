using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Texteditor.NET
{
    public partial class GUI : Form
    {

        private const string VERSION = "1.0.0"; // Globale Versions Konstante
        private const string PLACEHOLDER = "unbenannt"; // Globale Dateinamen Konstante
        private bool Gespeichert = true; // Globale Status Variable
        private string Dateiname = PLACEHOLDER; // Globale Dateinamen Variable
        private string Drucktext = "";

        private int Seitenzähler = 0;

        Suchen Suchen;
        Ersetzen Ersetzen;

        public GUI()
        {
            InitializeComponent();
            Titel();
        }

        #region Menü Schaltflächen 

        private void CreateNewDocument(object sender, EventArgs e)
        {
            if (Gespeichert == false)
            {
                switch (Speicher_Dialog(Dateiname))
                {
                    case DialogResult.Yes:
                        tsmi_Speichern.PerformClick();
                        if (Gespeichert == true)
                        {
                            tsmi_Neu.PerformClick();
                        }
                        break;

                    case DialogResult.No:
                        Gespeichert = true;
                        tsmi_Neu.PerformClick();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                tb_Editor.Clear();
                Gespeichert = true;
                Dateiname = PLACEHOLDER;
                Titel();
            }
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            if (Gespeichert == false)
            {
                switch (Speicher_Dialog(Dateiname))
                {
                    case DialogResult.Yes:
                        tsmi_Speichern.PerformClick();
                        if (Gespeichert == true)
                        {
                            tsmi_Öffnen.PerformClick();
                        }
                        break;

                    case DialogResult.No:
                        Gespeichert = true;
                        tsmi_Öffnen.PerformClick();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                OpenFileDialog ofd_Dialog = new OpenFileDialog();
                ofd_Dialog.Filter = "Textdateien (*.txt)|*.txt|CSV-Datein (*.csv)|*.csv|Alle Dateien|*.*";
                if (ofd_Dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tb_Editor.Text = File.ReadAllText(ofd_Dialog.FileName);
                        Dateiname = ofd_Dialog.FileName;
                        Gespeichert = true;
                        Titel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Gespeichert = false;
                }
            }
        }

        private void SaveDocument(object sender, EventArgs e)
        {

            if (Dateiname == PLACEHOLDER)
            {
                tsmi_Speichern_unter.PerformClick();
                if (Dateiname != PLACEHOLDER)
                {
                    tsmi_Speichern.PerformClick();
                }
            }
            else
            {
                try
                {
                    File.WriteAllText(Dateiname, tb_Editor.Text);
                    Gespeichert = true;
                    Titel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SaveDocumentAs(object sender, EventArgs e)
        {
            SaveFileDialog sfd_Dialog = new SaveFileDialog();
            sfd_Dialog.Filter = "Textdateien (*.txt)|*.txt|CSV-Datein (*.csv)|*.csv|Alle Dateien|*.*";


            if (sfd_Dialog.ShowDialog() == DialogResult.OK)
            {
                Dateiname = sfd_Dialog.FileName;
                tsmi_Speichern.PerformClick();
            }
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchWordwrap(object sender, EventArgs e)
        {
            tb_Editor.WordWrap = !tb_Editor.WordWrap;
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            FontDialog fd_Dialog = new FontDialog();

            if (fd_Dialog.ShowDialog() == DialogResult.OK)
            {
                tb_Editor.Font = fd_Dialog.Font;
            }

        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            ColorDialog cd_Dialog = new ColorDialog();

            if (cd_Dialog.ShowDialog() == DialogResult.OK)
            {
                tb_Editor.BackColor = cd_Dialog.Color;
            }
        }

        private void ChangeForegroundColor(object sender, EventArgs e)
        {
            ColorDialog cd_Dialog = new ColorDialog();
            if (cd_Dialog.ShowDialog() == DialogResult.OK)
            {
                tb_Editor.ForeColor = cd_Dialog.Color;
            }
        }

        #region Drucken

        private void tsmi_Seite_einrichten_Click(object sender, EventArgs e)
        {
            psd_Seite_einrichten.ShowDialog();
        }

        private void tsmi_Drucken_Click(object sender, EventArgs e)
        {
            try
            {
                Drucktext = tb_Editor.Text;
                if (pd_Drucken.ShowDialog() == DialogResult.OK)
                {
                    pd_Druckseite.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Achtung");
            }
        }

        private void tsb_Druckvorschau_Click(object sender, EventArgs e)
        {
            try
            {
                Drucktext = tb_Editor.Text;

                ppd_Druckvorschau.Height = 500;
                ppd_Druckvorschau.Width = 500;
                ppd_Druckvorschau.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Achtung");
            }

        }

        private void pd_Druckseite_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int iZeichenanzahl = 0;

            int iFromPage = e.PageSettings.PrinterSettings.FromPage;
            int iToPage = e.PageSettings.PrinterSettings.ToPage;

            if (e.PageSettings.PrinterSettings.PrintRange == PrintRange.SomePages)
            {
                if (Seitenzähler < iFromPage)
                {
                    for (int i = 1; i < iFromPage; i++)
                    {
                        e.Graphics.MeasureString(
                            Drucktext, tb_Editor.Font, e.MarginBounds.Size,
                            StringFormat.GenericDefault, out iZeichenanzahl, out _
                        );

                        Drucktext = Drucktext.Substring(iZeichenanzahl);

                        Seitenzähler++;
                    }
                }

                e.Graphics.DrawString(Drucktext, tb_Editor.Font, new SolidBrush(tb_Editor.ForeColor), e.MarginBounds);

                e.Graphics.MeasureString(
                    Drucktext, tb_Editor.Font, e.MarginBounds.Size,
                    StringFormat.GenericDefault, out iZeichenanzahl, out _
                );

                Drucktext = Drucktext.Substring(iZeichenanzahl);

                if (Seitenzähler < iToPage && Drucktext.Length > 0)
                    e.HasMorePages = true;

                Seitenzähler++;
            }
            else
            {
                e.Graphics.DrawString(Drucktext, tb_Editor.Font, new SolidBrush(tb_Editor.ForeColor), e.MarginBounds);

                e.Graphics.MeasureString(
                    Drucktext, tb_Editor.Font, e.MarginBounds.Size,
                    StringFormat.GenericDefault, out iZeichenanzahl, out _
                );

                Drucktext = Drucktext.Substring(iZeichenanzahl);

                if (Drucktext.Length > 0)
                    e.HasMorePages = true;
            }

            Seitenzähler = 0;
        }

        #endregion

        #endregion

        #region Fenster Funktionen

        private void tsb_Info_Click(object sender, EventArgs e)
        {
            Info fmInfo = new Info();
            fmInfo.Version = GUI.VERSION;
            fmInfo.ShowDialog();
        }

        private void GUI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.tsb_Info.PerformClick();
                    break;
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F5:
                    this.tsmi_Uhreit_Datum.PerformClick();
                    break;
                case Keys.F:
                    if(e.Control == true)
                    {
                        this.tsmi_Suchen.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Gespeichert == false)
            {
                switch (Speicher_Dialog(Dateiname))
                {
                    case DialogResult.Yes:
                        tsmi_Speichern.PerformClick();
                        if (Gespeichert == false)
                        {
                            e.Cancel = true; // Das Schließen Event wird abgebrochen
                        }
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private void tb_Editor_TextChanged(object sender, EventArgs e)
        {
            Gespeichert = false;
            Get_Zeichen();
        }
        
        private void tb_Editor_MouseClick(object sender, MouseEventArgs e)
        {
            this.Get_Position();
        }

        private void tb_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            this.Get_Position();
        }

        private void tb_Editor_KeyUp(object sender, KeyEventArgs e)
        {
            this.Get_Position();
        }

        private void uhrzeitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tb_Editor.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            this.tb_Editor.SelectionStart = this.tb_Editor.Text.Length;
        }

        private void tsmi_Suchen_Click(object sender, EventArgs e)
        {
            if(this.Suchen == null)
            {
                this.Suchen = new Suchen(this.tb_Editor);
            }

            if(this.Suchen != null && this.Suchen.Visible == false)
            {
                this.Suchen.Location = new Point(((this.Size.Width / 2) - (this.Suchen.Width / 2)),(this.Height / 2) - (this.Suchen.Height / 2));
                this.Suchen.Visible = true;
            }
        }

        private void tsmi_Ersetzen_Click(object sender, EventArgs e)
        {
            if(this.Ersetzen == null)
            {
                this.Ersetzen = new Ersetzen(this.tb_Editor, this.Get_Wörter(this.tb_Editor.Text));
            }
            
            if(this.Ersetzen != null && this.Ersetzen.Visible == false)
            {
                this.Ersetzen.Location = new Point(((this.Size.Width / 2) - (this.Ersetzen.Width / 2)), (this.Height / 2) - (this.Ersetzen.Height / 2));
                this.Ersetzen.Visible = true;
            }
            
        }

        #endregion

        #region eigene Funktionen

        private void Get_Position()
        {
            lbl_Spalte.Text = $"Spalte : {tb_Editor.SelectionStart - tb_Editor.GetFirstCharIndexOfCurrentLine() + 1}";
            lbl_Zeile.Text = $"Zeile : {tb_Editor.GetLineFromCharIndex(tb_Editor.GetFirstCharIndexOfCurrentLine()) + 1}";
        }

        private void Titel()
        {
            Text = $"Texteditor.NET - {Dateiname}";
        }

        private DialogResult Speicher_Dialog(string Dateiname)
        {
            return MessageBox.Show(
                    $"Möchten sie die Änderungen an {Dateiname} speichern ?",
                    "Achtung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information
                    );
        }

        private void Get_Zeichen()
        {
            string Text = tb_Editor.Text;
            string Zeichen = Text.Replace("\r", "");
            Zeichen = Text.Replace("\n", "");
            lbl_Anzahl_Zeichen.Text = $"Zeichenanzahl : {Zeichen.Length}";
            Get_Wörter(Text);
        }

        private int Get_Wörter(string text)
        {
            // Entferne Sonderzeichen und trenne den Text in Wörter
            string[] wörter = Regex.Split(text, @"\W+");

            // Zähle die nicht leeren Wörter
            int anzahl = wörter.Count(wort => !string.IsNullOrWhiteSpace(wort));

            // Aktualisiere das Label im GUI
            lbl_Wörter.Text = $"Wörter: {anzahl}";

            return anzahl;
        }

        private void tb_Editor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        #endregion

        
    }
}