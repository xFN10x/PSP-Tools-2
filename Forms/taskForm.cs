namespace PSP_Tools_2.Forms
{
    public partial class taskForm : Form
    {
        public string currentTask = "Doing Nothing";
        public bool running = true;
        public DialogResult result;
        public taskForm(string InitalTask, bool CanCancel)
        {
            InitializeComponent();
            this.SetTask(InitalTask);

            cancelButton.Enabled = CanCancel;


        }
        public void SetCantCancel()
        {
            cancelButton.Enabled = false;
        }
        public void SetTask(string Task)
        {
            if (result == DialogResult.Cancel) return;
            currentTask = Task;
            this.text.Text = $"Currently: {currentTask}.";
        }

        public void IClose()
        {
            result = DialogResult.None;
            running = false;
            this.Close();
            this.Dispose();
        }

        private void taskForm_Load(object sender, EventArgs e)
        {

        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.text.Text = "Canceling...";
        }
    }
}
