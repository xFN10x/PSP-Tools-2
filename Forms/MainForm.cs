using System.Diagnostics;
using Ini.Net;
using PSP_Tools_2.Forms;

namespace PSP_Tools_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveEditorButton_Click(object sender, EventArgs e)
        {
            if (PSPTools.PSPSelected)
            {
                PSPTools.ShowModal(new SaveDataEditorForm());
            }
            else
            {
                var resault = MessageBox.Show(PSPTools.MainForm, "No PSP folder selected. Select one?", "No PSP Selected", MessageBoxButtons.YesNo);
                if (resault == DialogResult.No) return;

                PSPTools.ShowModal(new PSPSelectionForm());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentlySelectedCPSPToolStripMenuItem.Text = "Currently Selected: " + PSPTools.PSPFolder;
        }

        private void ReselectPSPitem_Click(object sender, EventArgs e)
        {
            PSPTools.ShowModal(new PSPSelectionForm());
        }

        private async void removeBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                "Are you sure you want to delete all backups? (This includes saves, and games.) They will be gone for a while...",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;

            var taskForm = new taskForm("Deleting", false);
            taskForm.Show(this);
            await Task.Delay(1000);

            foreach (var item in Directory.GetFiles(PSPTools.SaveFileLocation + @"\backups"))
            {
                Debug.WriteLine($"deleting {item}");
                File.Delete(item);
            }

            taskForm.SetTask("Erasing all traces..");

            var iniFile = new IniFile("settings.ini");
            iniFile.DeleteSection("Backups");

            MessageBox.Show(this, "Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            taskForm.IClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var taskForm = new taskForm("Loading...", true);
            taskForm.Show();
            Task.Delay(1000);

            var form = new VideoConvertForm();

            taskForm.Close();

            PSPTools.ShowModal(form);
        }
    }
}
