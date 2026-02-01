using System;
using System.Windows.Forms;

namespace Texteditor.NET
{
    public partial class Info : Form
    {

        public string Version;

        public Info()
        {
            InitializeComponent();
        }

        private void btn_Schließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lbl_Version.Text = $"Version {Version}";
        }
    }
}
