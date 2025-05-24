using System.Diagnostics;
using FFmpeg.NET;

namespace PSP_Tools_2.Forms
{
    public partial class VideoConvertForm : Form
    {
        public LibVLCSharp.Shared.LibVLC lib = new();
        public bool PlayButtonPlay = true;
        public List<String> files = [];
        public VideoConvertForm()
        {
            InitializeComponent();

        }

        private void VideoConvertForm_Load(object sender, EventArgs e)
        {

            inputVideoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(lib);

        }

        private void removeFile_Click(object sender, EventArgs e)
        {
            if ((string)inputFilesBox.SelectedItem == "(No files selected)" || inputFilesBox.SelectedItem == null) return;

            Debug.Print("removing file" + files[inputFilesBox.SelectedIndex]);
            files.RemoveAt(inputFilesBox.SelectedIndex);
            inputFilesBox.Items.Remove(inputFilesBox.SelectedItem);
        }

        private void importFile_Click(object sender, EventArgs e)
        {
            var open = openFileDialog.ShowDialog();
            if (open != DialogResult.OK) return;

            inputFilesBox.Items.Remove("(No files selected)");



            foreach (var file in openFileDialog.FileNames)
            {
                files.Add(file);
            }

            foreach (var file in openFileDialog.SafeFileNames)
            {
                inputFilesBox.Items.Add(file);
            }





        }

        private void inputFilesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayButtonPlay = true;
            if (files.Count <= 0) return;
            Debug.WriteLine(files.Count);
            if (inputVideoView.MediaPlayer == null) return;
            if (inputFilesBox.SelectedIndex == null && inputFilesBox.SelectedIndex <= files.Count && inputFilesBox.SelectedIndex >= 0) return;
            try
            {
                inputVideoView.MediaPlayer.Media = new LibVLCSharp.Shared.Media(
                lib,
                files[inputFilesBox.SelectedIndex],
                LibVLCSharp.Shared.FromType.FromPath,
                options: null
                );
            }
            catch
            {
                return;
            }
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (inputVideoView.MediaPlayer == null) return;
            if (inputVideoView.MediaPlayer.Position == 1)
            {
                inputVideoView.MediaPlayer.Position = 0;
                PlayButtonPlay = true;
                inputVideoView.MediaPlayer.Play();
                return;
            }
            if (PlayButtonPlay)
            {
                PlayButtonPlay = false;
                inputVideoView.MediaPlayer.Play();
            }
            else
            {
                PlayButtonPlay = true;
                inputVideoView.MediaPlayer.Pause();
            }

        }


        private void InputFilesBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) return;

            var file = e.Data.GetData(DataFormats.FileDrop);

            if (file == null) return;

            Debug.WriteLine(file.GetType().ToString());
        }

        private void InputFilesBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            e.Effect = DragDropEffects.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputMode.SelectedIndex == 0)
            {
                folderSelectedBox.Enabled = false;
                selectOutputFolderButton.Enabled = false;
            }
            else
            {
                folderSelectedBox.Enabled = true;
                selectOutputFolderButton.Enabled = true;
            }
        }

        private void ConvertVideos_Click(object sender, EventArgs e)
        {
            var ffmpeg = new Engine(PSPTools.FileRes + @"\programs\");

            foreach (var item in files)
            {

            }
        }
    }
}
