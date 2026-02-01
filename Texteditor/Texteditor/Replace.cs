using Texteditor.Extensions;

namespace Texteditor
{
    public partial class Replace : Form
    {
        public readonly TextBox textBox;

        public Replace(TextBox textbox)
        {
            this.InitializeComponent();

            this.textBox = textbox;
            this.textBox.SelectionStart = 0;
            this.textBox.SelectionLength = 0;
        }

        #region Buttons
        private void OnSearchClick(object sender, EventArgs e)
        {
            if (!this.Search())
            {
                MessageBox.Show("Es wurde keine weiteren Vorkommen gefunden", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnReplaceClick(object sender, EventArgs e)
        {
            if(string.Equals(string.Empty, this.tb_Search.Text))
            {
                MessageBox.Show("Bitte geben sie einen Suchtext ein", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.btn_Search.PerformClick();

                this.ReplaceText(this.tb_Replace.Text);
            }
        }

        private void OnReplaceAllClick(object sender, EventArgs e)
        {
            int replaceCount = 0;
            int wordCount = this.textBox.GetTextInfo().Item2;
            while (this.Search() && (replaceCount < wordCount))
            {
                this.btn_Replace.PerformClick();
                this.btn_Search.PerformClick();
                replaceCount++;
            }
        }

        private void OnAbortClick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Window
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        #endregion

        #region Helpers
        /// <summary>
        /// 
        /// </summary>
        /// <returns>True if a Match is found, else False</returns>
        private bool Search()
        {
            string source = this.textBox.Text;
            string search = this.tb_Search.Text;

            if (string.IsNullOrEmpty(search))
                return false;

            StringComparison comparison = this.cb_CaseSensitiv.Checked
                ? StringComparison.CurrentCulture
                : StringComparison.CurrentCultureIgnoreCase;

            int start = this.textBox.SelectionStart + this.textBox.SelectionLength;

            if ((source.Length - start) < search.Length ||
                !source.Substring(start).Contains(search) && !this.cb_SearchWrap.Checked)
            {
                start = 0;
            }

            int index = source.IndexOf(search, start, comparison);

            if (index >= 0)
            {
                this.textBox.SelectionStart = index;
                this.textBox.SelectionLength = search.Length;
                return true;
            }

            return false;
        }

        public void ReplaceText(string newText)
        {
            if (this.textBox.SelectionLength == 0)
            {
                return;
            }

            this.textBox.SelectedText = newText;
        }
        #endregion
    }
}
