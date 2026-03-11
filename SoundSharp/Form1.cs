namespace SoundSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form AddPhone = new AddPhone();
            AddPhone.ShowDialog();

            SmartPhone newPhone = new SmartPhone(1, "Apple", "iPhone 14 Pro", 256000, 999.99m);
            //MessageBox.Show(newPhone.Brand);

            List<SmartPhone> phones = new List<SmartPhone>();
            phones.Add(newPhone);

            phones.Add(new SmartPhone(2, "Samsung", "Galaxy S23 Ultra", 256000, 1199.99m));

            foreach (SmartPhone phone in phones)
            {
                MessageBox.Show(phone.Brand);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblVoorraad_Click(object sender, EventArgs e)
        {

        }
    }
}
