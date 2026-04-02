namespace SoundSharp
{
    public partial class frmMain : Form
    {

        SharpPhoneFileStorage fileStorage = new SharpPhoneFileStorage();
        public frmMain()
        {
            InitializeComponent();
            fileStorage.Load();
            lstbxStockjson();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fileStorage.Load();
            lstbxStockjson();
        }
        private void lstbxStockjson()
        {
            lstbxStock.Items.Clear();
            foreach (var phone in fileStorage.Data.Phones)
            {
                lstbxStock.Items.Add($"{phone.Brand} {phone.Model} - Size: {phone.Size}MB - Price: ${phone.Price} - Stock: {phone.Stock}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addPhoneForm = new AddPhone(fileStorage);
            addPhoneForm.ShowDialog();
            lstbxStockjson();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbxStock.SelectedIndex == -1)
            {
                MessageBox.Show("Select Phone");
                return;
            }

            fileStorage.Data.Phones.RemoveAt(lstbxStock.SelectedIndex);
            fileStorage.Save();

            lstbxStockjson();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstbxStock.SelectedIndex == -1)
            {
                MessageBox.Show("Select Phone");
                return;
            }

            var phone = fileStorage.Data.Phones[lstbxStock.SelectedIndex];

            var editForm = new AddPhone(fileStorage, phone);
            editForm.ShowDialog();

            lstbxStockjson();
        }

        private void lblVoorraad_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {


        }


        private void lstbxStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
