using System.Drawing.Printing;
using Texteditor.Encryptions;
using Texteditor.Encryptions.GUIs;
using Texteditor.Encryptions.Strategies;
using Texteditor.Extensions;

namespace Texteditor
{
    public partial class Main : Form
    {
        private const string VERSION = "1.0.0";
        private bool _saved = true;
        private string _fileName = string.Empty;
        private readonly Font _standardFont;
        private string GetTitle => $"Texteditor .NET - {this._fileName}";

        private string _printText = string.Empty;
        private int _pageCounter = 0;
        private int _currentCharIndex = 0;

        private readonly Replace _replace;

        private readonly Encrypter _encrypter;

        public Main()
        {
            this.InitializeComponent();
            this.Text = this.GetTitle;

            this._replace = new(this.tb_Editor);

            this._standardFont = this.tb_Editor.Font;

            this.UpdatePositionLabel();
            this.UpdateTextInfoLabel();

            #region Encryper Setup
            this._encrypter = new();
            this._encrypter.Strategies = new()
            {
                new Tuple<Encryptions.Interfaces.IEncryptionStrategie, Form>(new CaesarStrategie(),new Caesar(this._replace,this._encrypter)),
            };
            this.SetupEncryptionStrategies();
            #endregion
        }

        #region MenuItems

        private void OnNewClick(object sender, EventArgs e)
        {
            if (this._saved == false)
            {
                switch (ShowSaveDialog(this._fileName))
                {
                    case DialogResult.Yes:
                        this.tsmi_Save.PerformClick();
                        if (this._saved == true)
                        {
                            this.tsmi_New.PerformClick();
                        }
                        break;

                    case DialogResult.No:
                        this._saved = true;
                        this.tsmi_New.PerformClick();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                this.tb_Editor.Clear();
                this._saved = true;
                this._fileName = string.Empty;
                this.SetTitle();
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            if (this._saved == false)
            {
                switch (ShowSaveDialog(this._fileName))
                {
                    case DialogResult.Yes:
                        this.tsmi_Save.PerformClick();
                        if (this._saved == true)
                        {
                            this.tsmi_Open.PerformClick();
                        }
                        break;

                    case DialogResult.No:
                        this._saved = true;
                        this.tsmi_Open.PerformClick();
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
                        this.tb_Editor.Text = File.ReadAllText(ofd_Dialog.FileName);
                        this._fileName = ofd_Dialog.FileName;
                        this._saved = true;
                        this.SetTitle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this._saved = false;
                }
            }
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (string.Equals(string.Empty, this._fileName))
            {
                this.tsmi_SaveAs.PerformClick();
            }
            else
            {
                try
                {
                    File.WriteAllText(this._fileName, this.tb_Editor.Text);
                    this._saved = true;
                    this.SetTitle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnSaveAsClick(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new())
            {
                sfd.Filter = "Textdateien (*.txt)|*.txt|CSV-Datein (*.csv)|*.csv|Alle Dateien|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this._fileName = sfd.FileName;
                    this.tsmi_Save.PerformClick();
                }
            }
        }

        private void OnSetupPageClick(object sender, EventArgs e)
        {
            this.psd_PageSetup.ShowDialog();
        }

        private void OnPrintClick(object sender, EventArgs e)
        {
            try
            {
                this._printText = this.tb_Editor.Text;
                this._currentCharIndex = 0;
                this._pageCounter = 0;

                if (this.pd_PrintDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pd_PrintDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Printing failed with [{ex.Message}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnDateTimeClick(object sender, EventArgs e)
        {
            this.tb_Editor.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            this.tb_Editor.SelectionStart = this.tb_Editor.Text.Length;
        }

        private void OnReplaceClick(object sender, EventArgs e)
        {
            this.UpdateBounds();

            this._replace.Location = this.CalculateStartPosition(this._replace);
            this._replace.Show();
        }

        private void OnWordWrapClick(object sender, EventArgs e)
        {
            this.tb_Editor.WordWrap = !this.tb_Editor.WordWrap;
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            using (FontDialog fd = new())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.tb_Editor.Font = fd.Font;
                }
            }
        }

        private void OnBackgroundColorClick(object sender, EventArgs e)
        {
            using (ColorDialog cd = new())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.tb_Editor.BackColor = cd.Color;
                }
            }
        }

        private void OnFontColorClick(object sender, EventArgs e)
        {
            using (ColorDialog cd = new())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.tb_Editor.ForeColor = cd.Color;
                }
            }
        }

        private void OnResetFormatClick(object sender, EventArgs e)
        {
            this.tb_Editor.BackColor = Color.White;
            this.tb_Editor.ForeColor = Color.Black;
            this.tb_Editor.Font = this._standardFont;
        }

        private void OnPrintPreviewClick(object sender, EventArgs e)
        {
            try
            {
                this._printText = this.tb_Editor.Text;

                this.ppd_PreviewDialog.Height = 500;
                this.ppd_PreviewDialog.Width = 500;
                this.ppd_PreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print Preview failed with [{ex.Message}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnInfoClick(object sender, EventArgs e)
        {
            using (Info info = new(VERSION))
            {
                info.Location = this.CalculateStartPosition(info);
                info.ShowDialog();
            }
        }

        #endregion

        #region Window
        private void Main_KeyDown(object sender, KeyEventArgs e)
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
                    this.tsmi_DateTime.PerformClick();
                    break;
                case Keys.F:
                    if (e.Control)
                    {
                        this.tsmi_Replace.PerformClick();
                    }
                    break;
                case Keys.H:
                    if (e.Control)
                    {
                        this.tsmi_Replace.PerformClick();
                    }
                    break;
                case Keys.S:
                    if (e.Control)
                    {
                        this.tsmi_Save.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._saved == false)
            {
                switch (ShowSaveDialog(this._fileName))
                {
                    case DialogResult.Yes:
                        this.tsmi_Save.PerformClick();
                        if (this._saved == false)
                        {
                            // Das Schließen Event wird abgebrochen
                            e.Cancel = true;
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
        #endregion

        #region Editor
        private void OnEditorTextChanged(object sender, EventArgs e)
        {
            this._saved = false;
            this.UpdatePositionLabel();
            this.UpdateTextInfoLabel();
        }
        private void OnEditorKeyDown(object sender, KeyEventArgs e)
        {
            this.UpdatePositionLabel();
        }

        private void OnEditorKeyPress(object sender, KeyPressEventArgs e)
        {
            this.UpdatePositionLabel();
        }

        private void OnEditorKeyUp(object sender, KeyEventArgs e)
        {
            this.UpdatePositionLabel();
        }
        private void OnEditorMouseClick(object sender, MouseEventArgs e)
        {
            this.UpdatePositionLabel();
        }
        #endregion

        #region Helpers
        private void UpdatePositionLabel()
        {
            this.tssl_CursorInfo.Text = $"Spalte : {this.tb_Editor.SelectionStart - this.tb_Editor.GetFirstCharIndexOfCurrentLine() + 1} Zeile : {this.tb_Editor.GetLineFromCharIndex(this.tb_Editor.GetFirstCharIndexOfCurrentLine()) + 1}";
        }
        private static DialogResult ShowSaveDialog(string Dateiname)
        {
            return MessageBox.Show(
                    $"Möchten sie die Änderungen an {Dateiname} speichern ?",
                    "Achtung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information
                    );
        }
        private void SetTitle()
        {
            this.Text = this.GetTitle;
        }
        private void UpdateTextInfoLabel()
        {
            var info = this.tb_Editor.GetTextInfo();

            this.tssl_TextInfo.Text = $"Zeiche : {info.Item1} Wörter: {info.Item2}";
        }
        /// <summary>
        /// I speficially honour D. Eismann from the EBZ for this Function.
        /// Link: https://ebz-verbund.de
        /// </summary>
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iZeichenanzahl = 0;

                int iFromPage = e.PageSettings.PrinterSettings.FromPage;
                int iToPage = e.PageSettings.PrinterSettings.ToPage;

                if (e.PageSettings.PrinterSettings.PrintRange == PrintRange.SomePages)
                {
                    if (this._pageCounter < iFromPage)
                    {
                        for (int i = 1; i < iFromPage; i++)
                        {
                            e.Graphics.MeasureString(
                                this._printText, this.tb_Editor.Font, e.MarginBounds.Size,
                                StringFormat.GenericDefault, out iZeichenanzahl, out _
                            );

                            this._printText = this._printText.Substring(iZeichenanzahl);

                            this._pageCounter++;
                        }
                    }

                    e.Graphics.DrawString(this._printText, this.tb_Editor.Font, new SolidBrush(this.tb_Editor.ForeColor), e.MarginBounds);

                    e.Graphics.MeasureString(
                        this._printText, this.tb_Editor.Font, e.MarginBounds.Size,
                        StringFormat.GenericDefault, out iZeichenanzahl, out _
                    );

                    this._printText = this._printText.Substring(iZeichenanzahl);

                    if (this._pageCounter < iToPage && this._printText.Length > 0)
                        e.HasMorePages = true;

                    this._pageCounter++;
                }
                else
                {
                    e.Graphics.DrawString(this._printText, this.tb_Editor.Font, new SolidBrush(this.tb_Editor.ForeColor), e.MarginBounds);

                    e.Graphics.MeasureString(
                        this._printText, this.tb_Editor.Font, e.MarginBounds.Size,
                        StringFormat.GenericDefault, out iZeichenanzahl, out _
                    );

                    this._printText = this._printText.Substring(iZeichenanzahl);

                    if (this._printText.Length > 0)
                        e.HasMorePages = true;
                }

                this._pageCounter = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Printpage failed with [{ex.Message}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.HasMorePages = false;
            }
        }
        private void SetupEncryptionStrategies()
        {
            var strategies = this._encrypter.Strategies;

            foreach (var strategy in strategies)
            {
                var item = new ToolStripMenuItem
                {
                    Text = strategy.Item1.GetDisplayName(),
                    Tag = strategy.Item1,
                    CheckOnClick = false
                };

                item.Click += (_, _) =>
                {
                    this._encrypter.SetStrategy(strategy.Item1);

                    foreach (ToolStripMenuItem menuItem in this.tsmi_Strategies.DropDownItems)
                    {
                        menuItem.Checked = ReferenceEquals(menuItem.Tag, strategy);
                    }

                    strategy.Item2.Location = this.CalculateStartPosition(strategy.Item2);

                    strategy.Item2.Show();
                };

                this.tsmi_Strategies.DropDownItems.Add(item);
            }
        }
        #endregion

        
    }
}
