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

        public Ersetzen(TextBox textBox, int maxWörter)
        {
            InitializeComponent();

            this.textBox = textBox;
            this.textBox.SelectionStart = 0;
            this.textBox.SelectionLength = 0;

            this.maxWörter = maxWörter;
        }

        private void btn_Weitersuchen_Click(object sender, EventArgs e)
        {
            this.Suchen();
        }

        private bool Suchen()
        {
            string source = this.textBox.Text;

            string search = this.tb_Suchen.Text;

            if (this.cb_Groß_Kleinschreibung.Checked != true)
            {
                source = source.ToLower();
                search = search.ToLower();
            }

            int x = 0;

            if (this.tb_Suchen.Text != "")
            {
                if (this.textBox.SelectionLength > 0)
                {
                    x = (this.textBox.SelectionStart + this.textBox.SelectionLength);
                }

                if ((source.Length - (this.textBox.SelectionStart + this.textBox.SelectionLength)) < search.Length && this.cb_Von_vorn.Checked == true)
                {
                    x = 0;
                }

                if (source.Substring(x).Contains(search) == false && this.cb_Von_vorn.Checked == true)
                {
                    x = 0;
                }

                for (int i = x; i < source.Length; i++)
                {
                    if (source[i].ToString() == search.Substring(0, 1))
                    {
                        if ((i + search.Length) > source.Length)
                        {

                        }
                        else
                        {
                            if (source.Substring(i, search.Length) == search)
                            {
                                this.textBox.SelectionStart = i;
                                this.textBox.SelectionLength = search.Length;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void btn_Ersetzen_Click(object sender, EventArgs e)
        {
            string source = this.textBox.Text;

            string search = this.tb_Suchen.Text;

            if (this.textBox.SelectionLength == 0)
            {
                this.btn_Weitersuchen.PerformClick();
            }
            else 
            {
                string Anfang = source.Substring(0, this.textBox.SelectionStart);
                string Ende = source.Substring((this.textBox.SelectionStart + this.textBox.SelectionLength));
                this.textBox.Text = Anfang + this.tb_Ersetzen.Text + Ende;
                this.btn_Weitersuchen.PerformClick();
            }
        }

        private void btn_Alle_ersetzen_Click(object sender, EventArgs e)
        {
            string source = this.textBox.Text;

            string search = this.tb_Suchen.Text;

            

            if (this.textBox.SelectionLength == 0)
            {
                this.btn_Weitersuchen.PerformClick();
            }
            else
            {
                int x = 0;

                do
                {
                    this.btn_Ersetzen.PerformClick();
                    x++;
                }
                while (this.Suchen() == true && x <= this.maxWörter);
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
            this.tb_Ersetzen.Text = CaesarEncryption.Verschlüsseln(this.tb_Ersetzen.Text, (int)this.nud_Rotation.Value);
        }

        private void btn_Entschlüsseln_Click(object sender, EventArgs e)
        {
            this.tb_Ersetzen.Text = CaesarEncryption.Entschlüsseln(this.tb_Ersetzen.Text, (int)this.nud_Rotation.Value);
        }
    }
}
