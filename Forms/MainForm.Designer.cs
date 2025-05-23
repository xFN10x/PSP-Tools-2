namespace PSP_Tools_2
{
    partial class MainForm
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
            saveEditorButton = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            fdsfToolStripMenuItem = new ToolStripMenuItem();
            reselectPspButton = new ToolStripMenuItem();
            currentlySelectedCPSPToolStripMenuItem = new ToolStripMenuItem();
            removeBackupsToolStripMenuItem = new ToolStripMenuItem();
            vcxbxToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // saveEditorButton
            // 
            saveEditorButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveEditorButton.Image = Properties.Resources.saveDataEditor1;
            saveEditorButton.Location = new Point(25, 31);
            saveEditorButton.Name = "saveEditorButton";
            saveEditorButton.Size = new Size(132, 106);
            saveEditorButton.TabIndex = 0;
            saveEditorButton.Text = "Save Editor";
            saveEditorButton.UseVisualStyleBackColor = true;
            saveEditorButton.Click += SaveEditorButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.video;
            button2.Location = new Point(25, 172);
            button2.Name = "button2";
            button2.Size = new Size(132, 106);
            button2.TabIndex = 3;
            button2.Text = "Video Converter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fdsfToolStripMenuItem, vcxbxToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(605, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fdsfToolStripMenuItem
            // 
            fdsfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reselectPspButton, currentlySelectedCPSPToolStripMenuItem, removeBackupsToolStripMenuItem });
            fdsfToolStripMenuItem.Name = "fdsfToolStripMenuItem";
            fdsfToolStripMenuItem.Size = new Size(46, 24);
            fdsfToolStripMenuItem.Text = "&File";
            // 
            // reselectPspButton
            // 
            reselectPspButton.Name = "reselectPspButton";
            reselectPspButton.ShortcutKeys = Keys.Control | Keys.R;
            reselectPspButton.Size = new Size(261, 26);
            reselectPspButton.Text = "Re-select PSP";
            reselectPspButton.Click += ReselectPSPitem_Click;
            // 
            // currentlySelectedCPSPToolStripMenuItem
            // 
            currentlySelectedCPSPToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            currentlySelectedCPSPToolStripMenuItem.Enabled = false;
            currentlySelectedCPSPToolStripMenuItem.Name = "currentlySelectedCPSPToolStripMenuItem";
            currentlySelectedCPSPToolStripMenuItem.Size = new Size(261, 26);
            currentlySelectedCPSPToolStripMenuItem.Text = "Currently Selected: C:\\PSP";
            // 
            // removeBackupsToolStripMenuItem
            // 
            removeBackupsToolStripMenuItem.Name = "removeBackupsToolStripMenuItem";
            removeBackupsToolStripMenuItem.Size = new Size(261, 26);
            removeBackupsToolStripMenuItem.Text = "Remove Backups";
            removeBackupsToolStripMenuItem.Click += removeBackupsToolStripMenuItem_Click;
            // 
            // vcxbxToolStripMenuItem
            // 
            vcxbxToolStripMenuItem.Name = "vcxbxToolStripMenuItem";
            vcxbxToolStripMenuItem.Size = new Size(60, 24);
            vcxbxToolStripMenuItem.Text = "vcxbx";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(605, 290);
            Controls.Add(button2);
            Controls.Add(saveEditorButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "PSP Tools 2";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveEditorButton;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fdsfToolStripMenuItem;
        private ToolStripMenuItem reselectPspButton;
        private ToolStripMenuItem vcxbxToolStripMenuItem;
        private ToolStripMenuItem currentlySelectedCPSPToolStripMenuItem;
        private ToolStripMenuItem removeBackupsToolStripMenuItem;
    }
}
