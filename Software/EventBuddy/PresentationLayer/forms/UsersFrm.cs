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

namespace PresentationLayer.forms
{
    public partial class UsersFrm : Form
    {
        UserServices userService = new UserServices();
        public UsersFrm()
        {
            InitializeComponent();
        }

        private void btnShowEvents_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = userService.getAllUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows != null)
            {
                var selectedUser = dgvUsers.CurrentRow.DataBoundItem as korisnik;
                EditUserFrm editUserFrm = new EditUserFrm(selectedUser);
                editUserFrm.Show();
            }
        }
    }
}
