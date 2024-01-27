using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmLogin : MaterialForm
    {
        private UserServices userServices = new UserServices();
        public static korisnik user = null;
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;
        //public static MaterialSkinManager.Themes theme = MaterialSkinManager.Themes.LIGHT;

        public frmLogin()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
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
                    Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neuspješna prijava", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
