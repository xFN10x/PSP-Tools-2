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
            if (Program.PSPSelected)
            {
                Program.ShowModal(new SaveDataEditorForm());
            }
            else
            {
                var resault = MessageBox.Show(Program.MainForm, "No PSP folder selected. Select one?", "No PSP Selected", MessageBoxButtons.YesNo);
                if (resault == DialogResult.No) return;

                Program.ShowModal(new PSPSelectionForm());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
