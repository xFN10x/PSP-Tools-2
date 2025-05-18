using System.Diagnostics;
using System.IO.Compression;
using Ini.Net;

namespace PSP_Tools_2
{
    public partial class SaveDataEditorForm : Form
    {
        private SFOReader reader;
        public SaveDataEditorForm()
        {
            InitializeComponent();
            textBG.BackColor = Color.Transparent;
        }

        private void SaveDataEditorForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Directory.GetDirectories(Program.PSPFolder + @"\SAVEDATA\"))
            {
                this.saveDataList.Items.Add(Path.GetFileName(item));
            }
            this.saveDataList.SelectedIndex = 0;
        }

        private string GetSelectedSaveFolder()
        {
            return Program.PSPFolder + @"\SAVEDATA\" + saveDataList.SelectedItem.ToString();
        }

        private void SaveDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saveDataList.SelectedItem != null)
            {
                var icon1loc = GetSelectedSaveFolder() + @"\PIC1.PNG";
                var icon0loc = GetSelectedSaveFolder() + @"\ICON0.PNG";

                if (File.Exists(icon1loc)) this.BackgroundImage = Image.FromFile(icon1loc);
                if (File.Exists(icon0loc)) saveIcon0.Image = Image.FromFile(icon0loc);

                reader = Program.ReadSFO(GetSelectedSaveFolder() + @"\PARAM.SFO");
                saveCat.Text = "Category: " + reader.GetFromKey("CATEGORY").ToString();
                saveDesc.Text = reader.GetFromKey("SAVEDATA_DETAIL").ToString();
                saveName.Text = reader.GetFromKey("SAVEDATA_TITLE").ToString();
                gameName.Text = reader.GetFromKey("TITLE").ToString();
            }
            else return;

        }

        private void saveName_Click(object sender, EventArgs e)
        {

        }

        private void gameName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveDesc_Click(object sender, EventArgs e)
        {

        }

        private void textBG_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void revealInExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", GetSelectedSaveFolder());
        }

        private void saveDeleteButton_Click(object sender, EventArgs e)
        {
            deleteConfirmDialog confirm = new("Confirm Delete", $"Are you sure you want to delete {reader.GetFromKey("SAVEDATA_TITLE")} ({reader.GetFromKey("TITLE")})? ", "Create Backup for Restoring.");
            confirm.ShowDialog(this);
            if (confirm.result == DialogResult.OK)
            {
                if (confirm.GetChecked())
                {
                    // make zip
                    var zipLoc = @$"backups\save-backup-{SFOReader.Format((string)reader.GetFromKey("SAVEDATA_TITLE"))}-{DateTime.Now.ToString().Replace(":", "").Trim().Replace(" ", "-")}.ptb";

                    ZipFile.CreateFromDirectory(GetSelectedSaveFolder(),
                    zipLoc,
                    CompressionLevel.SmallestSize,
                    false);

                    //save data
                    var iniFile = new IniFile("settings.ini");
                    iniFile.WriteString("Backups", $"save-backup-{reader.GetFromKey("SAVEDATA_TITLE")}", zipLoc);

                    Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
                }
            }
        }
    }
}
