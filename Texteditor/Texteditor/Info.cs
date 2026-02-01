namespace Texteditor
{
    public partial class Info : Form
    {
        public Info(string versionstring)
        {
            this.InitializeComponent();
            this.lbl_Version.Text = $"Version: {versionstring}";
            this.lbl_CopyRight.Text = "Copyright © 2025 Jonas Wolf";
        }
    }
}
