namespace SoundSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddPhone = new AddPhone();
            AddPhone.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
