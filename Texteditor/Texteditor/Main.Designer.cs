namespace Texteditor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ms_MenusStrip = new MenuStrip();
            this.tsmi_File = new ToolStripMenuItem();
            this.tsmi_New = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.tsmi_Open = new ToolStripMenuItem();
            this.tsmi_Save = new ToolStripMenuItem();
            this.tsmi_SaveAs = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.tsmi_PageSetup = new ToolStripMenuItem();
            this.tsmi_Print = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.tsmi_Exit = new ToolStripMenuItem();
            this.tsmi_Edit = new ToolStripMenuItem();
            this.tsmi_DateTime = new ToolStripMenuItem();
            this.tsmi_Replace = new ToolStripMenuItem();
            this.tsmi_Format = new ToolStripMenuItem();
            this.tsmi_WordWrap = new ToolStripMenuItem();
            this.tsmi_Font = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.tsmi_BackgroundColor = new ToolStripMenuItem();
            this.tsmi_FontColor = new ToolStripMenuItem();
            this.tsmi_ResetFormat = new ToolStripMenuItem();
            this.tsmi_Encryption = new ToolStripMenuItem();
            this.tsmi_Strategies = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.ts_ToolStrip = new ToolStrip();
            this.tsb_New = new ToolStripButton();
            this.tsb_Open = new ToolStripButton();
            this.tsb_Save = new ToolStripButton();
            this.tsb_Print = new ToolStripButton();
            this.tsb_PrintPreview = new ToolStripButton();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.tsb_Info = new ToolStripButton();
            this.ss_StatusStrip = new StatusStrip();
            this.tssl_TextInfo = new ToolStripStatusLabel();
            this.tssl_Spring = new ToolStripStatusLabel();
            this.tssl_CursorInfo = new ToolStripStatusLabel();
            this.tb_Editor = new TextBox();
            this.psd_PageSetup = new PageSetupDialog();
            this.pd_PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.pd_PrintDialog = new PrintDialog();
            this.ppd_PreviewDialog = new PrintPreviewDialog();
            this.fd_FontDialog = new FontDialog();
            this.cd_ColorDialog = new ColorDialog();
            this.ms_MenusStrip.SuspendLayout();
            this.ts_ToolStrip.SuspendLayout();
            this.ss_StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MenusStrip
            // 
            resources.ApplyResources(this.ms_MenusStrip, "ms_MenusStrip");
            this.ms_MenusStrip.Items.AddRange(new ToolStripItem[] { this.tsmi_File, this.tsmi_Edit, this.tsmi_Format, this.tsmi_Encryption });
            this.ms_MenusStrip.Name = "ms_MenusStrip";
            // 
            // tsmi_File
            // 
            resources.ApplyResources(this.tsmi_File, "tsmi_File");
            this.tsmi_File.DropDownItems.AddRange(new ToolStripItem[] { this.tsmi_New, this.toolStripSeparator1, this.tsmi_Open, this.tsmi_Save, this.tsmi_SaveAs, this.toolStripSeparator6, this.tsmi_PageSetup, this.tsmi_Print, this.toolStripSeparator2, this.tsmi_Exit });
            this.tsmi_File.Name = "tsmi_File";
            // 
            // tsmi_New
            // 
            resources.ApplyResources(this.tsmi_New, "tsmi_New");
            this.tsmi_New.Name = "tsmi_New";
            this.tsmi_New.Click += this.OnNewClick;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsmi_Open
            // 
            resources.ApplyResources(this.tsmi_Open, "tsmi_Open");
            this.tsmi_Open.Name = "tsmi_Open";
            this.tsmi_Open.Click += this.OnOpenClick;
            // 
            // tsmi_Save
            // 
            resources.ApplyResources(this.tsmi_Save, "tsmi_Save");
            this.tsmi_Save.Name = "tsmi_Save";
            this.tsmi_Save.Click += this.OnSaveClick;
            // 
            // tsmi_SaveAs
            // 
            resources.ApplyResources(this.tsmi_SaveAs, "tsmi_SaveAs");
            this.tsmi_SaveAs.Name = "tsmi_SaveAs";
            this.tsmi_SaveAs.Click += this.OnSaveAsClick;
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // tsmi_PageSetup
            // 
            resources.ApplyResources(this.tsmi_PageSetup, "tsmi_PageSetup");
            this.tsmi_PageSetup.Name = "tsmi_PageSetup";
            this.tsmi_PageSetup.Click += this.OnSetupPageClick;
            // 
            // tsmi_Print
            // 
            resources.ApplyResources(this.tsmi_Print, "tsmi_Print");
            this.tsmi_Print.Name = "tsmi_Print";
            this.tsmi_Print.Click += this.OnPrintClick;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsmi_Exit
            // 
            resources.ApplyResources(this.tsmi_Exit, "tsmi_Exit");
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Click += this.OnExitClick;
            // 
            // tsmi_Edit
            // 
            resources.ApplyResources(this.tsmi_Edit, "tsmi_Edit");
            this.tsmi_Edit.DropDownItems.AddRange(new ToolStripItem[] { this.tsmi_DateTime, this.tsmi_Replace });
            this.tsmi_Edit.Name = "tsmi_Edit";
            // 
            // tsmi_DateTime
            // 
            resources.ApplyResources(this.tsmi_DateTime, "tsmi_DateTime");
            this.tsmi_DateTime.Name = "tsmi_DateTime";
            this.tsmi_DateTime.Click += this.OnDateTimeClick;
            // 
            // tsmi_Replace
            // 
            resources.ApplyResources(this.tsmi_Replace, "tsmi_Replace");
            this.tsmi_Replace.Name = "tsmi_Replace";
            this.tsmi_Replace.Click += this.OnReplaceClick;
            // 
            // tsmi_Format
            // 
            resources.ApplyResources(this.tsmi_Format, "tsmi_Format");
            this.tsmi_Format.DropDownItems.AddRange(new ToolStripItem[] { this.tsmi_WordWrap, this.tsmi_Font, this.toolStripSeparator5, this.tsmi_BackgroundColor, this.tsmi_FontColor, this.tsmi_ResetFormat });
            this.tsmi_Format.Name = "tsmi_Format";
            // 
            // tsmi_WordWrap
            // 
            resources.ApplyResources(this.tsmi_WordWrap, "tsmi_WordWrap");
            this.tsmi_WordWrap.Checked = true;
            this.tsmi_WordWrap.CheckOnClick = true;
            this.tsmi_WordWrap.CheckState = CheckState.Checked;
            this.tsmi_WordWrap.Name = "tsmi_WordWrap";
            this.tsmi_WordWrap.Click += this.OnWordWrapClick;
            // 
            // tsmi_Font
            // 
            resources.ApplyResources(this.tsmi_Font, "tsmi_Font");
            this.tsmi_Font.Name = "tsmi_Font";
            this.tsmi_Font.Click += this.OnFontClick;
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // tsmi_BackgroundColor
            // 
            resources.ApplyResources(this.tsmi_BackgroundColor, "tsmi_BackgroundColor");
            this.tsmi_BackgroundColor.Name = "tsmi_BackgroundColor";
            this.tsmi_BackgroundColor.Click += this.OnBackgroundColorClick;
            // 
            // tsmi_FontColor
            // 
            resources.ApplyResources(this.tsmi_FontColor, "tsmi_FontColor");
            this.tsmi_FontColor.Name = "tsmi_FontColor";
            this.tsmi_FontColor.Click += this.OnFontColorClick;
            // 
            // tsmi_ResetFormat
            // 
            resources.ApplyResources(this.tsmi_ResetFormat, "tsmi_ResetFormat");
            this.tsmi_ResetFormat.Name = "tsmi_ResetFormat";
            this.tsmi_ResetFormat.Click += this.OnResetFormatClick;
            // 
            // tsmi_Encryption
            // 
            resources.ApplyResources(this.tsmi_Encryption, "tsmi_Encryption");
            this.tsmi_Encryption.DropDownItems.AddRange(new ToolStripItem[] { this.tsmi_Strategies });
            this.tsmi_Encryption.Name = "tsmi_Encryption";
            // 
            // tsmi_Strategies
            // 
            resources.ApplyResources(this.tsmi_Strategies, "tsmi_Strategies");
            this.tsmi_Strategies.Name = "tsmi_Strategies";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // ts_ToolStrip
            // 
            resources.ApplyResources(this.ts_ToolStrip, "ts_ToolStrip");
            this.ts_ToolStrip.Items.AddRange(new ToolStripItem[] { this.tsb_New, this.tsb_Open, this.tsb_Save, this.tsb_Print, this.tsb_PrintPreview, this.toolStripSeparator4, this.tsb_Info });
            this.ts_ToolStrip.Name = "ts_ToolStrip";
            // 
            // tsb_New
            // 
            resources.ApplyResources(this.tsb_New, "tsb_New");
            this.tsb_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_New.Image = Properties.Resources.blank_page;
            this.tsb_New.Name = "tsb_New";
            this.tsb_New.Click += this.OnNewClick;
            // 
            // tsb_Open
            // 
            resources.ApplyResources(this.tsb_Open, "tsb_Open");
            this.tsb_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_Open.Image = Properties.Resources.folder;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Click += this.OnOpenClick;
            // 
            // tsb_Save
            // 
            resources.ApplyResources(this.tsb_Save, "tsb_Save");
            this.tsb_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_Save.Image = Properties.Resources.diskette;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Click += this.OnSaveClick;
            // 
            // tsb_Print
            // 
            resources.ApplyResources(this.tsb_Print, "tsb_Print");
            this.tsb_Print.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_Print.Image = Properties.Resources.computer_printer;
            this.tsb_Print.Name = "tsb_Print";
            this.tsb_Print.Click += this.OnPrintClick;
            // 
            // tsb_PrintPreview
            // 
            resources.ApplyResources(this.tsb_PrintPreview, "tsb_PrintPreview");
            this.tsb_PrintPreview.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_PrintPreview.Image = Properties.Resources.preview;
            this.tsb_PrintPreview.Name = "tsb_PrintPreview";
            this.tsb_PrintPreview.Click += this.OnPrintPreviewClick;
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // tsb_Info
            // 
            resources.ApplyResources(this.tsb_Info, "tsb_Info");
            this.tsb_Info.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsb_Info.Name = "tsb_Info";
            this.tsb_Info.Click += this.OnInfoClick;
            // 
            // ss_StatusStrip
            // 
            resources.ApplyResources(this.ss_StatusStrip, "ss_StatusStrip");
            this.ss_StatusStrip.Items.AddRange(new ToolStripItem[] { this.tssl_TextInfo, this.tssl_Spring, this.tssl_CursorInfo });
            this.ss_StatusStrip.Name = "ss_StatusStrip";
            // 
            // tssl_TextInfo
            // 
            resources.ApplyResources(this.tssl_TextInfo, "tssl_TextInfo");
            this.tssl_TextInfo.Name = "tssl_TextInfo";
            // 
            // tssl_Spring
            // 
            resources.ApplyResources(this.tssl_Spring, "tssl_Spring");
            this.tssl_Spring.Name = "tssl_Spring";
            this.tssl_Spring.Spring = true;
            // 
            // tssl_CursorInfo
            // 
            resources.ApplyResources(this.tssl_CursorInfo, "tssl_CursorInfo");
            this.tssl_CursorInfo.Name = "tssl_CursorInfo";
            // 
            // tb_Editor
            // 
            resources.ApplyResources(this.tb_Editor, "tb_Editor");
            this.tb_Editor.HideSelection = false;
            this.tb_Editor.Name = "tb_Editor";
            this.tb_Editor.MouseClick += this.OnEditorMouseClick;
            this.tb_Editor.TextChanged += this.OnEditorTextChanged;
            this.tb_Editor.KeyDown += this.OnEditorKeyDown;
            this.tb_Editor.KeyPress += this.OnEditorKeyPress;
            this.tb_Editor.KeyUp += this.OnEditorKeyUp;
            // 
            // psd_PageSetup
            // 
            this.psd_PageSetup.Document = this.pd_PrintDocument;
            // 
            // pd_PrintDocument
            // 
            this.pd_PrintDocument.PrintPage += this.PrintPage;
            // 
            // pd_PrintDialog
            // 
            this.pd_PrintDialog.Document = this.pd_PrintDocument;
            this.pd_PrintDialog.UseEXDialog = true;
            // 
            // ppd_PreviewDialog
            // 
            resources.ApplyResources(this.ppd_PreviewDialog, "ppd_PreviewDialog");
            this.ppd_PreviewDialog.Document = this.pd_PrintDocument;
            this.ppd_PreviewDialog.Name = "ppd_PreviewDialog";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tb_Editor);
            this.Controls.Add(this.ss_StatusStrip);
            this.Controls.Add(this.ts_ToolStrip);
            this.Controls.Add(this.ms_MenusStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.ms_MenusStrip;
            this.Name = "Main";
            this.FormClosing += this.Main_FormClosing;
            this.KeyDown += this.Main_KeyDown;
            this.ms_MenusStrip.ResumeLayout(false);
            this.ms_MenusStrip.PerformLayout();
            this.ts_ToolStrip.ResumeLayout(false);
            this.ts_ToolStrip.PerformLayout();
            this.ss_StatusStrip.ResumeLayout(false);
            this.ss_StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private MenuStrip ms_MenusStrip;
        private ToolStripMenuItem tsmi_File;
        private ToolStripMenuItem tsmi_New;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStrip ts_ToolStrip;
        private StatusStrip ss_StatusStrip;
        private ToolStripMenuItem tsmi_Open;
        private ToolStripMenuItem tsmi_Save;
        private ToolStripMenuItem tsmi_SaveAs;
        private ToolStripMenuItem tsmi_Print;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmi_Exit;
        private ToolStripMenuItem tsmi_Edit;
        private ToolStripMenuItem tsmi_DateTime;
        private ToolStripMenuItem tsmi_Replace;
        private ToolStripMenuItem verschlüsselnToolStripMenuItem;
        private ToolStripMenuItem zeilenumbruchToolStripMenuItem;
        private ToolStripMenuItem schriftartToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem hintergrundfarbeToolStripMenuItem;
        private ToolStripMenuItem schriftfarbeToolStripMenuItem;
        private ToolStripButton tsb_New;
        private ToolStripButton tsb_Open;
        private ToolStripButton tsb_Save;
        private ToolStripButton tsb_Print;
        private ToolStripButton tsb_PrintPreview;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripStatusLabel tssl_WordCount;
        private ToolStripStatusLabel tssl_Spring;
        private ToolStripStatusLabel tssl_CursorInfo;
        private TextBox tb_Editor;
        private ToolStripMenuItem tsmi_Format;
        private ToolStripMenuItem tsmi_WordWrap;
        private ToolStripMenuItem tsmi_Font;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem tsmi_BackgroundColor;
        private ToolStripMenuItem tsmi_FontColor;
        private ToolStripButton tsb_Info;
        private PageSetupDialog psd_PageSetup;
        private PrintDialog pd_PrintDialog;
        private PrintPreviewDialog ppd_PreviewDialog;
        private System.Drawing.Printing.PrintDocument pd_PrintDocument;
        private FontDialog fd_FontDialog;
        private ColorDialog cd_ColorDialog;
        private ToolStripStatusLabel tssl_TextInfo;
        private ToolStripMenuItem tsmi_ResetFormat;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem tsmi_PageSetup;
        private ToolStripMenuItem tsmi_Encryption;
        private ToolStripMenuItem tsmi_Strategies;
    }
}
