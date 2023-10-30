namespace TextEditorApp
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            wordWrapOffToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            increaseFontSizeToolStripMenuItem = new ToolStripMenuItem();
            decreaseFontSizeToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            txtContent = new RichTextBox();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(143, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(143, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(143, 26);
            saveAsToolStripMenuItem.Text = "&Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 26);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordWrapOffToolStripMenuItem, toolStripSeparator1, increaseFontSizeToolStripMenuItem, decreaseFontSizeToolStripMenuItem, resetToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "&Format";
            // 
            // wordWrapOffToolStripMenuItem
            // 
            wordWrapOffToolStripMenuItem.Name = "wordWrapOffToolStripMenuItem";
            wordWrapOffToolStripMenuItem.Size = new Size(224, 26);
            wordWrapOffToolStripMenuItem.Text = "&Word Wrap(Off)";
            wordWrapOffToolStripMenuItem.Click += wordWrapOffToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // increaseFontSizeToolStripMenuItem
            // 
            increaseFontSizeToolStripMenuItem.Name = "increaseFontSizeToolStripMenuItem";
            increaseFontSizeToolStripMenuItem.Size = new Size(224, 26);
            increaseFontSizeToolStripMenuItem.Text = "&Increase Font Size";
            increaseFontSizeToolStripMenuItem.Click += increaseFontSizeToolStripMenuItem_Click;
            // 
            // decreaseFontSizeToolStripMenuItem
            // 
            decreaseFontSizeToolStripMenuItem.Name = "decreaseFontSizeToolStripMenuItem";
            decreaseFontSizeToolStripMenuItem.Size = new Size(224, 26);
            decreaseFontSizeToolStripMenuItem.Text = "&Decrease Font Size";
            decreaseFontSizeToolStripMenuItem.Click += decreaseFontSizeToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(224, 26);
            resetToolStripMenuItem.Text = "&Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(168, 20);
            lblStatus.Text = "Welcome to Text Editor!";
            // 
            // txtContent
            // 
            txtContent.Dock = DockStyle.Fill;
            txtContent.Location = new Point(0, 28);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(800, 396);
            txtContent.TabIndex = 3;
            txtContent.Text = "";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "Text Files(*.txt)|*.txt";
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.Filter = "Text Files(*.txt)|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContent);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Text Editor";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem wordWrapOffToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem increaseFontSizeToolStripMenuItem;
        private ToolStripMenuItem decreaseFontSizeToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private RichTextBox txtContent;
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
    }
}