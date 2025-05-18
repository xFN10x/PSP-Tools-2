namespace PSP_Tools_2
{
    public partial class deleteConfirmDialog : Form
    {
        public DialogResult result;

        public bool GetChecked()
        {
            return backupCheck.Checked;
        }
        public deleteConfirmDialog(string Name, string Message)
        {
            InitializeComponent();
            this.messageLabel.Text = Message;
            this.Name = Name;
            this.backupCheck.Enabled = false;
        }
        public deleteConfirmDialog(string Name, string Message, string DeleteBackupText)
        {
            InitializeComponent();
            this.Name = Name;
            this.messageLabel.Text = Message;
            this.backupCheck.Text = DeleteBackupText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void deleteConfirmDialog_Load(object sender, EventArgs e)
        {

        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }
    }
}
