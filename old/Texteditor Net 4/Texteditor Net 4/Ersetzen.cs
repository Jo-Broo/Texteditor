using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texteditor.NET
{
    public partial class Ersetzen : Form
    {
        private TextBox textBox;

        private int maxWörter;

        private Encrypter encrypter;

        public Ersetzen(TextBox textBox, Encrypter encrypter, int maxWörter)
        {
            InitializeComponent();

            this.textBox = textBox;
            this.textBox.SelectionStart = 0;
            this.textBox.SelectionLength = 0;

            this.maxWörter = maxWörter;
            this.encrypter = encrypter;
        }

        private void btn_Weitersuchen_Click(object sender, EventArgs e)
        {
            if (!this.Suchen())
            {
                MessageBox.Show("Es wurde keine weiteren Vorkommen gefunden","Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //private bool Suchen()
        //{
        //    string source = this.textBox.Text;

        //    string search = this.tb_Suchen.Text;

        //    if (this.cb_Groß_Kleinschreibung.Checked != true)
        //    {
        //        source = source.ToLower();
        //        search = search.ToLower();
        //    }

        //    int SearchStartPointer = 0;

        //    if (this.tb_Suchen.Text != "")
        //    {
        //        if (this.textBox.SelectionLength > 0)
        //        {
        //            SearchStartPointer = (this.textBox.SelectionStart + this.textBox.SelectionLength);
        //        }

        //        if ((source.Length - (this.textBox.SelectionStart + this.textBox.SelectionLength)) < search.Length && this.cb_Von_vorn.Checked == true)
        //        {
        //            SearchStartPointer = 0;
        //        }

        //        if (source.Substring(SearchStartPointer).Contains(search) == false && this.cb_Von_vorn.Checked == true)
        //        {
        //            SearchStartPointer = 0;
        //        }

        //        for (int i = SearchStartPointer; i < source.Length; i++)
        //        {
        //            if (source[i].ToString() == search.Substring(0, 1))
        //            {
        //                if ((i + search.Length) > source.Length)
        //                {

        //                }
        //                else
        //                {
        //                    if (source.Substring(i, search.Length) == search)
        //                    {
        //                        this.textBox.SelectionStart = i;
        //                        this.textBox.SelectionLength = search.Length;
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}

        private bool Suchen()
        {
            string source = this.textBox.Text;
            string search = this.tb_Suchen.Text;

            if (string.IsNullOrEmpty(search))
                return false;

            // Groß-/Kleinschreibung
            StringComparison comparison = this.cb_Groß_Kleinschreibung.Checked
                ? StringComparison.CurrentCulture
                : StringComparison.CurrentCultureIgnoreCase;

            // Startposition
            int start = this.textBox.SelectionStart + this.textBox.SelectionLength;

            // Von vorn beginnen, falls nötig
            if ((source.Length - start) < search.Length ||
                !source.Substring(start).Contains(search) && this.cb_Von_vorn.Checked)
            {
                start = 0;
            }

            // Suche starten
            int index = source.IndexOf(search, start, comparison);

            if (index >= 0)
            {
                this.textBox.SelectionStart = index;
                this.textBox.SelectionLength = search.Length;
                return true;
            }

            return false;
        }


        private void btn_Ersetzen_Click(object sender, EventArgs e)
        {
            string source = this.textBox.Text;

            if (this.textBox.SelectionLength == 0)
            {
                this.btn_Weitersuchen.PerformClick();
            }
            else 
            {
                this.ReplaceText(this.tb_Ersetzen.Text);
            }
        }

        private void btn_Alle_ersetzen_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength == 0)
            {
                this.btn_Weitersuchen.PerformClick();
            }
            
            int ersetzenCounter = 0;

            do
            {
                this.btn_Ersetzen.PerformClick();
                this.btn_Weitersuchen.PerformClick();
                ersetzenCounter++;
            }
            while (this.Suchen() == true && ersetzenCounter <= this.maxWörter);
        }

        private void ReplaceText(string newText, bool placeCursorBehindText = false)
        {
            if (this.textBox.SelectionLength == 0)
                throw new InvalidOperationException("No text to replace");

            int selectionStart = this.textBox.SelectionStart;

            this.textBox.SelectedText = newText;

            if (placeCursorBehindText)
            {
                this.textBox.SelectionStart = selectionStart + newText.Length;
                this.textBox.SelectionLength = 0;
            }
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ersetzen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btn_Verschlüsseln_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedText = this.textBox.SelectedText;
                string chiffre = this.encrypter.Encrypt(selectedText, (int)this.nud_Rotation.Value);

                this.ReplaceText(chiffre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Entschlüsseln_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedText = this.textBox.SelectedText;
                string text = this.encrypter.Decrpyt(selectedText, (int)this.nud_Rotation.Value);

                this.ReplaceText(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
