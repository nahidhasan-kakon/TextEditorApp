namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        Font defaultFont;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            lblStatus.Text = "New Text Document";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            txtContent.WordWrap = false;
            wordWrapOffToolStripMenuItem.Text = "Word Wrap (Off)";

            defaultFont = txtContent.Font;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgOpenFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileToOpen = @dlgOpenFile.FileName;

                try
                {
                    string textcontent = File.ReadAllText(@fileToOpen);
                    txtContent.Text = textcontent;
                    lblStatus.Text = "Opened file: " + fileToOpen;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Message", ex.Message);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgSaveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileToSave = @dlgSaveFile.FileName;
                try
                {
                    File.WriteAllText(@fileToSave, txtContent.Text);
                    lblStatus.Text = "File saved as: " + @fileToSave;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Message", ex.Message);
                }
            }
        }

        private void wordWrapOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContent.WordWrap)
            {
                txtContent.WordWrap = false;
                wordWrapOffToolStripMenuItem.Text = "Word Wrap (Off)";
            }
            else
            {
                txtContent.WordWrap = true;
                wordWrapOffToolStripMenuItem.Text = "Word Wrap (On)";
            }
        }

        private void increaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContent.Font.Size < 18)
            {
                txtContent.Font = new Font(txtContent.Font.FontFamily, txtContent.Font.Size + 2);
            }
        }

        private void decreaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContent.Font.Size > 10)
            {
                txtContent.Font = new Font(txtContent.Font.FontFamily, txtContent.Font.Size - 2);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Font = defaultFont;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Sample Text Editor App build in .NET Winforms Demo", "About the Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}