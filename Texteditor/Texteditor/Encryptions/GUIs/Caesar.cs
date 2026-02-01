namespace Texteditor.Encryptions.GUIs
{
    public partial class Caesar : Form
    {
        // with the replace reference it is super easy to replace Text in the main Editor
        private Replace replace;

        // the encrypter handels the Encrypt and Decrypt according to the set Strategy
        private Encrypter encrypter;

        public Caesar(Replace replace, Encrypter encrypter)
        {
            this.InitializeComponent();
            this.replace = replace;
            this.encrypter = encrypter;
        }

        private void OnEncryptClick(object sender, EventArgs e)
        {
            if(this.replace.textBox.SelectionLength == 0)
            {
                MessageBox.Show("Es ist kein Text zum verschlüsseln ausgewählt", "Error");
                return;
            }
            
            this.replace.ReplaceText(this.encrypter.Encrypt(this.replace.textBox.SelectedText,(int)this.nud_Rotation.Value));
        }

        private void OnDecryptClick(object sender, EventArgs e)
        {
            if (this.replace.textBox.SelectionLength == 0)
            {
                MessageBox.Show("Es ist kein Text zum entschlüsseln ausgewählt", "Error");
                return;
            }

            this.replace.ReplaceText(this.encrypter.Decrypt(this.replace.textBox.SelectedText, (int)this.nud_Rotation.Value));
        }
    }
}
