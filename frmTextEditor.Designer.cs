namespace Simple_Text_Editor
{
    partial class frmTextEditor
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
            mstEditorStrip = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            focusToolStripMenuItem = new ToolStripMenuItem();
            warmUpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mstEditorStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mstEditorStrip
            // 
            mstEditorStrip.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem, focusToolStripMenuItem, warmUpToolStripMenuItem, helpToolStripMenuItem });
            mstEditorStrip.Location = new Point(0, 0);
            mstEditorStrip.Name = "mstEditorStrip";
            mstEditorStrip.Size = new Size(1085, 24);
            mstEditorStrip.TabIndex = 0;
            mstEditorStrip.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, newWindowToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(37, 20);
            fToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(180, 22);
            newWindowToolStripMenuItem.Text = "New &Window";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open....";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // focusToolStripMenuItem
            // 
            focusToolStripMenuItem.Name = "focusToolStripMenuItem";
            focusToolStripMenuItem.Size = new Size(84, 20);
            focusToolStripMenuItem.Text = "Focus &Mode";
            // 
            // warmUpToolStripMenuItem
            // 
            warmUpToolStripMenuItem.Name = "warmUpToolStripMenuItem";
            warmUpToolStripMenuItem.Size = new Size(69, 20);
            warmUpToolStripMenuItem.Text = "&Warm Up";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1085, 623);
            textBox1.TabIndex = 1;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &As....";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "S&ettings";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // frmTextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 647);
            Controls.Add(textBox1);
            Controls.Add(mstEditorStrip);
            MainMenuStrip = mstEditorStrip;
            Name = "frmTextEditor";
            Text = "KPad";
            mstEditorStrip.ResumeLayout(false);
            mstEditorStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mstEditorStrip;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem focusToolStripMenuItem;
        private TextBox textBox1;
        private ToolStripMenuItem warmUpToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
