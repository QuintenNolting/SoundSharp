using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp
{
    public partial class AddPhone : Form
    {
        private SmartPhone EditPhone;

        private SharpPhoneFileStorage fileStorage;

        public AddPhone(SharpPhoneFileStorage storage)
        {
            InitializeComponent();
            fileStorage = storage;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public AddPhone(SharpPhoneFileStorage storage, SmartPhone EditPhone)
        {
            InitializeComponent();
            fileStorage = storage;
            this.EditPhone = EditPhone;

            tbxBrand.Text = EditPhone.Brand;
            tbxModel.Text = EditPhone.Model;
            tbxSize.Text = EditPhone.Size.ToString();
            tbxPrice.Text = EditPhone.Price.ToString();
            tbxStock.Text = EditPhone.Stock.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxBrand_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (EditPhone != null)
            {
                EditPhone.Brand = tbxBrand.Text;
                EditPhone.Model = tbxModel.Text;
                EditPhone.Size = int.Parse(tbxSize.Text);
                EditPhone.Price = decimal.Parse(tbxPrice.Text);
                EditPhone.Stock = int.Parse(tbxStock.Text);

                fileStorage.Save();
                MessageBox.Show("Phone updated successfully!");
                Close();
                return;
            }
            fileStorage.Load();

            int newId = fileStorage.Data.Phones.Any()
            ? fileStorage.Data.Phones.Max(p => p.Id) + 1
            : 1;

            SmartPhone newPhone = new SmartPhone(
                newId,
                tbxBrand.Text,
                tbxModel.Text,
                int.Parse(tbxSize.Text),
                decimal.Parse(tbxPrice.Text),
                int.Parse(tbxStock.Text)
            );

            fileStorage.Data.Phones.Add(newPhone);
            fileStorage.Save();

            MessageBox.Show("Phone added successfully!");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
        
