namespace Texteditor
{
    partial class Replace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
            this.lbl_Search = new Label();
            this.lbl_Replace = new Label();
            this.cb_CaseSensitiv = new CheckBox();
            this.cb_SearchWrap = new CheckBox();
            this.btn_Search = new Button();
            this.btn_Replace = new Button();
            this.btn_ReplaceAll = new Button();
            this.btn_Abort = new Button();
            this.tb_Search = new TextBox();
            this.tb_Replace = new TextBox();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            resources.ApplyResources(this.lbl_Search, "lbl_Search");
            this.lbl_Search.Name = "lbl_Search";
            // 
            // lbl_Replace
            // 
            resources.ApplyResources(this.lbl_Replace, "lbl_Replace");
            this.lbl_Replace.Name = "lbl_Replace";
            // 
            // cb_CaseSensitiv
            // 
            resources.ApplyResources(this.cb_CaseSensitiv, "cb_CaseSensitiv");
            this.cb_CaseSensitiv.Name = "cb_CaseSensitiv";
            this.cb_CaseSensitiv.UseVisualStyleBackColor = true;
            // 
            // cb_SearchWrap
            // 
            resources.ApplyResources(this.cb_SearchWrap, "cb_SearchWrap");
            this.cb_SearchWrap.Name = "cb_SearchWrap";
            this.cb_SearchWrap.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            resources.ApplyResources(this.btn_Search, "btn_Search");
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += this.OnSearchClick;
            // 
            // btn_Replace
            // 
            resources.ApplyResources(this.btn_Replace, "btn_Replace");
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += this.OnReplaceClick;
            // 
            // btn_ReplaceAll
            // 
            resources.ApplyResources(this.btn_ReplaceAll, "btn_ReplaceAll");
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += this.OnReplaceAllClick;
            // 
            // btn_Abort
            // 
            resources.ApplyResources(this.btn_Abort, "btn_Abort");
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += this.OnAbortClick;
            // 
            // tb_Search
            // 
            resources.ApplyResources(this.tb_Search, "tb_Search");
            this.tb_Search.Name = "tb_Search";
            // 
            // tb_Replace
            // 
            resources.ApplyResources(this.tb_Replace, "tb_Replace");
            this.tb_Replace.Name = "tb_Replace";
            // 
            // Replace
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tb_Replace);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_ReplaceAll);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_SearchWrap);
            this.Controls.Add(this.cb_CaseSensitiv);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.lbl_Search);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replace";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += this.OnFormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lbl_Search;
        private Label lbl_Replace;
        private CheckBox cb_CaseSensitiv;
        private CheckBox cb_SearchWrap;
        private Button btn_Search;
        private Button btn_Replace;
        private Button btn_ReplaceAll;
        private Button btn_Abort;
        private TextBox tb_Search;
        private TextBox tb_Replace;
    }
}