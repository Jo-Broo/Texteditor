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
    public partial class Suchen : Form
    {
        private TextBox textBox;

        public Suchen(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            this.textBox.SelectionStart = 0;
            this.textBox.SelectionLength = 0;
        }

        private void btn_Weitersuchen_Click(object sender, EventArgs e)
        {
            string source = this.textBox.Text;

            string search = this.tb_Suchen.Text;

            if (this.cb_Groß_Kleinschreibung.Checked != true)
            {
                source = source.ToLower();
                search = search.ToLower();
            }

            if (this.rb_Nach_unten.Checked == true)
            {
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
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                int x = source.Length;

                if (search != "")
                {
                    if (this.textBox.SelectionLength > 0) { x = (this.textBox.SelectionStart - 1); if (x < 0) { x = 0; } }

                   
                    if ((x == 0 && this.cb_Von_vorn.Checked == true))
                    {
                        x = source.Length;
                    }

                    if (source.Substring(0, x).Length < search.Length && this.cb_Von_vorn.Checked == true)
                    {
                        x = source.Length;
                    }

                    if (source.Substring(0, x).Contains(search) == false && this.cb_Von_vorn.Checked == true)
                    {
                        x = source.Length;
                    }

                    for (int i = x; i >= 0; i--)
                    {
                        if ((i + search.Length) > source.Length)
                        {

                        }
                        else
                        {
                            if (source[i].ToString() == search.Substring(0, 1))
                            {
                                if (source.Substring(i, search.Length) == search)
                                {
                                this.textBox.SelectionStart = i;
                                this.textBox.SelectionLength = search.Length;
                                break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Selection(object sender, EventArgs e)
        {
            this.textBox.SelectionLength = 0;
        }

        private void Suchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            //GUI parent = (GUI)this.Owner;
            //parent.Update_Standart_Suchen(this.tb_Suchen.Text,this.cb_Groß_Kleinschreibung.Checked,this.cb_Von_vorn.Checked,(this.rb_Nach_unten.Checked == true)?true:false);
        }
    }
}
