using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            fileStorage.Load();
        }

        private SharpPhoneFileStorage fileStorage = new SharpPhoneFileStorage();

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            var user = fileStorage.Data.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                lblError.Text = "  Account bestaat niet.";
                return;
            }
            if (user.Locked)
            {
                lblError.Text = "Account is geblokkeerd.";
                return;
            }
            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                fileStorage.Save();
                frmMain main = new frmMain();
                this.Hide();
            }
            if (user.Password != password)
            {
                user.FailedAttempts++;
                if (user.FailedAttempts >= 4)
                {
                    user.Locked = true;
                    lblError.Text = "Account is geblokkeerd" + Environment.NewLine + "na 3 mislukte pogingen.";
                }
                else
                {
                    lblError.Text = "Ongeldige wachtwoord." + Environment.NewLine + $"      Poging {user.FailedAttempts} van 3.";
                }
                fileStorage.Save();
                return;
            }
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
