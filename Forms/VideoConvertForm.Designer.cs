
namespace PSP_Tools_2.Forms
{
    partial class VideoConvertForm
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
            inputVideoView = new LibVLCSharp.WinForms.VideoView();
            label1 = new Label();
            inputFilesBox = new ListBox();
            playPauseButton = new Button();
            importFile = new Button();
            removeFile = new Button();
            openFileDialog = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            outputMode = new ComboBox();
            folderSelectedBox = new TextBox();
            selectOutputFolderButton = new Button();
            outputFolderBrowserDialog = new FolderBrowserDialog();
            ConvertVideos = new Button();
            ((System.ComponentModel.ISupportInitialize)inputVideoView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // inputVideoView
            // 
            inputVideoView.BackColor = Color.Black;
            inputVideoView.ForeColor = SystemColors.ButtonHighlight;
            inputVideoView.Location = new Point(12, 205);
            inputVideoView.MediaPlayer = null;
            inputVideoView.Name = "inputVideoView";
            inputVideoView.Size = new Size(320, 171);
            inputVideoView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Input File(s)";
            label1.Click += label1_Click;
            // 
            // inputFilesBox
            // 
            inputFilesBox.AllowDrop = true;
            inputFilesBox.FormattingEnabled = true;
            inputFilesBox.Items.AddRange(new object[] { "(No files, you can drag & drop here aswell.)" });
            inputFilesBox.Location = new Point(31, 38);
            inputFilesBox.Name = "inputFilesBox";
            inputFilesBox.Size = new Size(281, 124);
            inputFilesBox.TabIndex = 2;
            inputFilesBox.SelectedIndexChanged += inputFilesBox_SelectedIndexChanged;
            inputFilesBox.DragDrop += InputFilesBox_DragDrop;
            inputFilesBox.DragEnter += InputFilesBox_DragEnter;
            // 
            // playPauseButton
            // 
            playPauseButton.Location = new Point(12, 382);
            playPauseButton.Name = "playPauseButton";
            playPauseButton.Size = new Size(320, 29);
            playPauseButton.TabIndex = 3;
            playPauseButton.Text = "&Play/Pause";
            playPauseButton.UseVisualStyleBackColor = true;
            playPauseButton.Click += playPauseButton_Click;
            // 
            // importFile
            // 
            importFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importFile.Location = new Point(31, 171);
            importFile.Name = "importFile";
            importFile.Size = new Size(181, 29);
            importFile.TabIndex = 4;
            importFile.Text = "&Import";
            importFile.UseVisualStyleBackColor = true;
            importFile.Click += importFile_Click;
            // 
            // removeFile
            // 
            removeFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeFile.Location = new Point(218, 171);
            removeFile.Name = "removeFile";
            removeFile.Size = new Size(94, 29);
            removeFile.TabIndex = 5;
            removeFile.Text = "&Remove";
            removeFile.UseVisualStyleBackColor = true;
            removeFile.Click += removeFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Video Files (*.*)|*.*";
            openFileDialog.InitialDirectory = "%HOMEPATH%\\Videos";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open Supported File(s)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(359, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 405);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 15);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 7;
            label2.Text = "Output method";
            // 
            // outputMode
            // 
            outputMode.DropDownStyle = ComboBoxStyle.DropDownList;
            outputMode.FormattingEnabled = true;
            outputMode.Items.AddRange(new object[] { "Straight to PSP", "To Folder" });
            outputMode.Location = new Point(504, 38);
            outputMode.Name = "outputMode";
            outputMode.Size = new Size(267, 28);
            outputMode.TabIndex = 8;
            outputMode.SelectedIndexChanged += outputMode_SelectedIndexChanged;
            // 
            // folderSelectedBox
            // 
            folderSelectedBox.Enabled = false;
            folderSelectedBox.Location = new Point(504, 87);
            folderSelectedBox.Name = "folderSelectedBox";
            folderSelectedBox.Size = new Size(234, 27);
            folderSelectedBox.TabIndex = 9;
            folderSelectedBox.Text = "(No Folder Selected)";
            // 
            // selectOutputFolderButton
            // 
            selectOutputFolderButton.Enabled = false;
            selectOutputFolderButton.Location = new Point(744, 87);
            selectOutputFolderButton.Name = "selectOutputFolderButton";
            selectOutputFolderButton.Size = new Size(27, 27);
            selectOutputFolderButton.TabIndex = 10;
            selectOutputFolderButton.Text = "...";
            selectOutputFolderButton.UseVisualStyleBackColor = true;
            // 
            // outputFolderBrowserDialog
            // 
            outputFolderBrowserDialog.Description = "Open Output Folder";
            outputFolderBrowserDialog.SelectedPath = "%HOMEPATH%";
            // 
            // ConvertVideos
            // 
            ConvertVideos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConvertVideos.Location = new Point(504, 171);
            ConvertVideos.Name = "ConvertVideos";
            ConvertVideos.Size = new Size(267, 29);
            ConvertVideos.TabIndex = 11;
            ConvertVideos.Text = "&Convert";
            ConvertVideos.UseVisualStyleBackColor = true;
            ConvertVideos.Click += ConvertVideos_Click;
            // 
            // VideoConvertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(ConvertVideos);
            Controls.Add(selectOutputFolderButton);
            Controls.Add(folderSelectedBox);
            Controls.Add(outputMode);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(removeFile);
            Controls.Add(importFile);
            Controls.Add(playPauseButton);
            Controls.Add(inputFilesBox);
            Controls.Add(label1);
            Controls.Add(inputVideoView);
            Name = "VideoConvertForm";
            Text = "Convert Video for PSP";
            Load += VideoConvertForm_Load;
            ((System.ComponentModel.ISupportInitialize)inputVideoView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private LibVLCSharp.WinForms.VideoView inputVideoView;
        private Label label1;
        private ListBox inputFilesBox;
        private Button playPauseButton;
        private Button importFile;
        private Button removeFile;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox outputMode;
        private TextBox folderSelectedBox;
        private Button selectOutputFolderButton;
        private FolderBrowserDialog outputFolderBrowserDialog;
        private Button ConvertVideos;
    }
}