namespace PSP_Tools_2
{
    partial class SaveDataEditorForm
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
            saveDataList = new ListBox();
            saveIcon0 = new PictureBox();
            gameName = new Label();
            saveName = new Label();
            saveDesc = new Label();
            saveDeleteButton = new Button();
            button1 = new Button();
            saveCat = new Label();
            textBG = new PictureBox();
            revealInExplorer = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)saveIcon0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // saveDataList
            // 
            saveDataList.FormattingEnabled = true;
            saveDataList.Location = new Point(12, 12);
            saveDataList.Name = "saveDataList";
            saveDataList.Size = new Size(329, 424);
            saveDataList.TabIndex = 0;
            saveDataList.SelectedIndexChanged += SaveDataList_SelectedIndexChanged;
            // 
            // saveIcon0
            // 
            saveIcon0.BackColor = SystemColors.ActiveBorder;
            saveIcon0.ErrorImage = Properties.Resources.noneselected;
            saveIcon0.Image = Properties.Resources.noneselected;
            saveIcon0.InitialImage = Properties.Resources.noneselected;
            saveIcon0.Location = new Point(356, 34);
            saveIcon0.Name = "saveIcon0";
            saveIcon0.Size = new Size(432, 240);
            saveIcon0.SizeMode = PictureBoxSizeMode.Zoom;
            saveIcon0.TabIndex = 1;
            saveIcon0.TabStop = false;
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.BackColor = Color.FromArgb(183, 183, 183);
            gameName.ForeColor = SystemColors.ActiveCaptionText;
            gameName.Location = new Point(354, 7);
            gameName.Name = "gameName";
            gameName.Size = new Size(127, 20);
            gameName.TabIndex = 2;
            gameName.Text = "Save Game Name";
            gameName.Click += gameName_Click;
            // 
            // saveName
            // 
            saveName.AutoSize = true;
            saveName.BackColor = Color.FromArgb(183, 183, 183);
            saveName.FlatStyle = FlatStyle.Popup;
            saveName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveName.ForeColor = SystemColors.ActiveCaptionText;
            saveName.Location = new Point(371, 295);
            saveName.Name = "saveName";
            saveName.Size = new Size(74, 20);
            saveName.TabIndex = 3;
            saveName.Text = "Save Title";
            saveName.Click += saveName_Click;
            // 
            // saveDesc
            // 
            saveDesc.AutoSize = true;
            saveDesc.BackColor = Color.FromArgb(183, 183, 183);
            saveDesc.ForeColor = SystemColors.ActiveCaptionText;
            saveDesc.Location = new Point(371, 326);
            saveDesc.Name = "saveDesc";
            saveDesc.Size = new Size(115, 20);
            saveDesc.TabIndex = 4;
            saveDesc.Text = "Save Desciption";
            saveDesc.Click += saveDesc_Click;
            // 
            // saveDeleteButton
            // 
            saveDeleteButton.FlatStyle = FlatStyle.Popup;
            saveDeleteButton.Location = new Point(633, 3);
            saveDeleteButton.Name = "saveDeleteButton";
            saveDeleteButton.Size = new Size(155, 29);
            saveDeleteButton.TabIndex = 5;
            saveDeleteButton.Text = "Delete Save";
            saveDeleteButton.UseVisualStyleBackColor = false;
            saveDeleteButton.Click += saveDeleteButton_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(650, 407);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 6;
            button1.Text = "Edit Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // saveCat
            // 
            saveCat.AutoSize = true;
            saveCat.BackColor = Color.FromArgb(183, 183, 183);
            saveCat.ForeColor = SystemColors.ControlDarkDark;
            saveCat.Location = new Point(371, 416);
            saveCat.Name = "saveCat";
            saveCat.Size = new Size(189, 20);
            saveCat.TabIndex = 7;
            saveCat.Text = "Catagory: MS (Game Save) ";
            // 
            // textBG
            // 
            textBG.BackColor = Color.Transparent;
            textBG.BackgroundImageLayout = ImageLayout.None;
            textBG.Image = Properties.Resources.icon_back;
            textBG.Location = new Point(326, -16);
            textBG.Name = "textBG";
            textBG.Size = new Size(485, 474);
            textBG.SizeMode = PictureBoxSizeMode.StretchImage;
            textBG.TabIndex = 8;
            textBG.TabStop = false;
            textBG.Click += textBG_Click;
            // 
            // revealInExplorer
            // 
            revealInExplorer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            revealInExplorer.FlatStyle = FlatStyle.Popup;
            revealInExplorer.Image = Properties.Resources.file_explorer_folder_libraries_icon_182982;
            revealInExplorer.Location = new Point(755, 372);
            revealInExplorer.Name = "revealInExplorer";
            revealInExplorer.Size = new Size(33, 29);
            revealInExplorer.TabIndex = 9;
            revealInExplorer.UseVisualStyleBackColor = false;
            revealInExplorer.Click += revealInExplorer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.icon_back;
            pictureBox1.Location = new Point(334, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // SaveDataEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.noneselected;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(revealInExplorer);
            Controls.Add(saveCat);
            Controls.Add(button1);
            Controls.Add(saveDeleteButton);
            Controls.Add(saveDesc);
            Controls.Add(saveName);
            Controls.Add(gameName);
            Controls.Add(saveIcon0);
            Controls.Add(saveDataList);
            Controls.Add(textBG);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveDataEditorForm";
            Text = "SaveDataEditorForm";
            Load += SaveDataEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)saveIcon0).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox saveDataList;
        private PictureBox saveIcon0;
        private Label gameName;
        private Label saveName;
        private Label saveDesc;
        private Button saveDeleteButton;
        private Button button1;
        private Label saveCat;
        private PictureBox textBG;
        private Button revealInExplorer;
        private PictureBox pictureBox1;
    }
}