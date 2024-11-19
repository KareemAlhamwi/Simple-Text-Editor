namespace Simple_Text_Editor {
    public partial class frmTextEditor : Form {
        bool wordWrapConverter = true;
        //! get the current font from the style the user used .. it's not always fixed to be 14
        float currentFontSize = 14;

        public frmTextEditor() {
            InitializeComponent();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e) {
            if (wordWrapConverter) {
                wordWrapToolStripMenuItem.Checked = true;
                textBox.WordWrap = true;
                wordWrapConverter = false;
            }
            else {
                wordWrapToolStripMenuItem.Checked = false;
                textBox.WordWrap = false;
                wordWrapConverter = true;
            }
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e) {
            currentFontSize += 2;
            textBox.Font = new Font(textBox.Font.FontFamily, currentFontSize);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) {
            currentFontSize -= 2;
            textBox.Font = new Font(textBox.Font.FontFamily, currentFontSize);
        }

        private void restoreDefToolStripMenuItem_Click(object sender, EventArgs e) {
            //! same as before
            currentFontSize = 14;
            textBox.Font = new Font(textBox.Font.FontFamily, currentFontSize);
        }
    }
}