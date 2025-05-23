namespace PSP_Tools_2
{
    public partial class PSPSelectionForm : Form
    {
        public PSPSelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo selectedDrive = (DriveInfo)driveSelection.Items[driveSelection.SelectedIndex];
            //if (selectedDrive != null && Directory.Exists(selectedDrive + @"PSP\") && Directory.Exists(selectedDrive + @"ISO\"))
            //{
            PSPTools.SetPSP(this, selectedDrive + @"PSP\", selectedDrive + @"ISO\");
            //}
        }

        private void PSPSelectionForm_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (var item in allDrives)
            {
                driveSelection.Items.Add(item);
            }
            driveSelection.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pspFolderSelectButton_Click(object sender, EventArgs e)
        {
            var resault = this.folderBrowserDialog.ShowDialog(this);

            if (resault == DialogResult.OK)
            {
                this.pspFolderPath.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void isoFolderSelectButton_Click(object sender, EventArgs e)
        {
            var resault = this.folderBrowserDialog.ShowDialog(this);

            if (resault == DialogResult.OK)
            {
                this.isoFolderPath.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void byFolderSelect_Click(object sender, EventArgs e)
        {
            PSPTools.SetPSP(this, pspFolderPath.Text, this.isoFolderPath.Text);
        }
    }
}
