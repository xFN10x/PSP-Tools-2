namespace PSP_Tools_2
{
    partial class PSPSelectionForm
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
            pspSelectionTypeBox = new TabControl();
            byDrivePage = new TabPage();
            selectButton = new Button();
            label1 = new Label();
            driveSelection = new ComboBox();
            byFolderPage = new TabPage();
            byFolderSelect = new Button();
            label3 = new Label();
            isoFolderSelectButton = new Button();
            isoFolderPath = new TextBox();
            label2 = new Label();
            pspFolderSelectButton = new Button();
            pspFolderPath = new TextBox();
            folderBrowserDialog = new FolderBrowserDialog();
            pspSelectionTypeBox.SuspendLayout();
            byDrivePage.SuspendLayout();
            byFolderPage.SuspendLayout();
            SuspendLayout();
            // 
            // pspSelectionTypeBox
            // 
            pspSelectionTypeBox.Anchor = AnchorStyles.Top;
            pspSelectionTypeBox.Controls.Add(byDrivePage);
            pspSelectionTypeBox.Controls.Add(byFolderPage);
            pspSelectionTypeBox.Location = new Point(12, 12);
            pspSelectionTypeBox.Name = "pspSelectionTypeBox";
            pspSelectionTypeBox.SelectedIndex = 0;
            pspSelectionTypeBox.Size = new Size(438, 186);
            pspSelectionTypeBox.TabIndex = 0;
            // 
            // byDrivePage
            // 
            byDrivePage.Controls.Add(selectButton);
            byDrivePage.Controls.Add(label1);
            byDrivePage.Controls.Add(driveSelection);
            byDrivePage.Location = new Point(4, 29);
            byDrivePage.Name = "byDrivePage";
            byDrivePage.Padding = new Padding(3);
            byDrivePage.Size = new Size(430, 153);
            byDrivePage.TabIndex = 0;
            byDrivePage.Text = "by Drive";
            byDrivePage.ToolTipText = "Select PSP by the Drive.";
            byDrivePage.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(6, 118);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(418, 29);
            selectButton.TabIndex = 2;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 1;
            label1.Text = "Will use C:/PSP and C:/ISO Folder";
            // 
            // driveSelection
            // 
            driveSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            driveSelection.FormattingEnabled = true;
            driveSelection.ImeMode = ImeMode.NoControl;
            driveSelection.Location = new Point(6, 27);
            driveSelection.Name = "driveSelection";
            driveSelection.Size = new Size(418, 28);
            driveSelection.TabIndex = 0;
            // 
            // byFolderPage
            // 
            byFolderPage.Controls.Add(byFolderSelect);
            byFolderPage.Controls.Add(label3);
            byFolderPage.Controls.Add(isoFolderSelectButton);
            byFolderPage.Controls.Add(isoFolderPath);
            byFolderPage.Controls.Add(label2);
            byFolderPage.Controls.Add(pspFolderSelectButton);
            byFolderPage.Controls.Add(pspFolderPath);
            byFolderPage.Location = new Point(4, 29);
            byFolderPage.Name = "byFolderPage";
            byFolderPage.Padding = new Padding(3);
            byFolderPage.Size = new Size(430, 153);
            byFolderPage.TabIndex = 1;
            byFolderPage.Text = "by Folder";
            byFolderPage.ToolTipText = "Select Folder for PSP";
            byFolderPage.UseVisualStyleBackColor = true;
            // 
            // byFolderSelect
            // 
            byFolderSelect.Location = new Point(6, 118);
            byFolderSelect.Name = "byFolderSelect";
            byFolderSelect.Size = new Size(418, 29);
            byFolderSelect.TabIndex = 6;
            byFolderSelect.Text = "Select";
            byFolderSelect.UseVisualStyleBackColor = true;
            byFolderSelect.Click += byFolderSelect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "ISO Folder";
            // 
            // isoFolderSelectButton
            // 
            isoFolderSelectButton.Location = new Point(386, 77);
            isoFolderSelectButton.Name = "isoFolderSelectButton";
            isoFolderSelectButton.Size = new Size(38, 27);
            isoFolderSelectButton.TabIndex = 4;
            isoFolderSelectButton.Text = "...";
            isoFolderSelectButton.UseVisualStyleBackColor = true;
            isoFolderSelectButton.Click += isoFolderSelectButton_Click;
            // 
            // isoFolderPath
            // 
            isoFolderPath.Location = new Point(6, 77);
            isoFolderPath.Name = "isoFolderPath";
            isoFolderPath.Size = new Size(374, 27);
            isoFolderPath.TabIndex = 3;
            isoFolderPath.Text = "(No Folder Selected)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "PSP Folder";
            label2.Click += label2_Click;
            // 
            // pspFolderSelectButton
            // 
            pspFolderSelectButton.Location = new Point(389, 26);
            pspFolderSelectButton.Name = "pspFolderSelectButton";
            pspFolderSelectButton.Size = new Size(38, 27);
            pspFolderSelectButton.TabIndex = 1;
            pspFolderSelectButton.Text = "...";
            pspFolderSelectButton.UseVisualStyleBackColor = true;
            pspFolderSelectButton.Click += pspFolderSelectButton_Click;
            // 
            // pspFolderPath
            // 
            pspFolderPath.Location = new Point(9, 26);
            pspFolderPath.Name = "pspFolderPath";
            pspFolderPath.Size = new Size(374, 27);
            pspFolderPath.TabIndex = 0;
            pspFolderPath.Text = "(No Folder Selected)";
            pspFolderPath.TextChanged += textBox1_TextChanged;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.AddToRecent = false;
            folderBrowserDialog.ShowHiddenFiles = true;
            folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // PSPSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 210);
            Controls.Add(pspSelectionTypeBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PSPSelectionForm";
            Text = "Select PSP";
            TopMost = true;
            Load += PSPSelectionForm_Load;
            pspSelectionTypeBox.ResumeLayout(false);
            byDrivePage.ResumeLayout(false);
            byDrivePage.PerformLayout();
            byFolderPage.ResumeLayout(false);
            byFolderPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl pspSelectionTypeBox;
        private TabPage byDrivePage;
        private TabPage byFolderPage;
        private ComboBox driveSelection;
        private Button selectButton;
        private Label label1;
        private TextBox pspFolderPath;
        private FolderBrowserDialog folderBrowserDialog;
        private Button pspFolderSelectButton;
        private Label label2;
        private Label label3;
        private Button isoFolderSelectButton;
        private TextBox isoFolderPath;
        private Button byFolderSelect;
    }
}