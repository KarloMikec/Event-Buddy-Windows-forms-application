using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PresentationLayer
{
    public partial class frmProfil : MaterialForm
    {
        private UserServices userServices = new UserServices();
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;
        public frmProfil()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newPassword = txtNewPassword.Text;
            var user = frmLogin.user;
            if (txtOldPassword.Text == user.lozinka)
            {
                if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtNewPassword2.Text))
                {
                    MessageBox.Show("Nisu sva polja popunjena!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNewPassword2.Text == newPassword)
                {
                    user.lozinka = newPassword;
                    if (userServices.updateUser(user))
                    {
                        frmLogin.user = user;
                        MessageBox.Show("Uspješno ažurirani podaci!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom ažuriranja profila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Lozinke se ne podudarajui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Molimo unesite staru lozinku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RefreshGUI()
        {
            var user = frmLogin.user;
            txtKorime.Text = user.korime;
            txtNewPassword.Text = "";
            txtNewPassword2.Text = "";
            txtOldPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void msChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (msChangeTheme.Checked)
            {
                changeTheme.Theme = MaterialSkinManager.Themes.DARK;
                //frmLogin.theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                changeTheme.Theme = MaterialSkinManager.Themes.LIGHT;
                //frmLogin.theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
   

