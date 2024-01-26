using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        private UserServices userServices = new UserServices();
        public static korisnik user = null;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e) 
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var LoggedUser = userServices.loginUser(txtUsername.Text, txtPassword.Text);
                if(LoggedUser != null)
                {
                    user = LoggedUser;
                    //MessageBox.Show("Prijavljen " + LoggedUser.ime);
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Neuspješna prijava", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
