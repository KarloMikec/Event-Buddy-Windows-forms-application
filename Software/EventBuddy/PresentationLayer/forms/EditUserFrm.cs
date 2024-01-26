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
    public partial class EditUserFrm : Form
    {
        korisnik _selectedUser;
        UserServices userService = new UserServices();
        public EditUserFrm(korisnik selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
        }

        private void EditUserFrm_Load(object sender, EventArgs e)
        {
            txtName.Text = _selectedUser.ime;
            txtSurname.Text = _selectedUser.prezime;
            txtNumberOfWarnings.Text = _selectedUser.upozorenja.ToString();
            txtUsername.Text = _selectedUser.korime;

            btnOrganizerBox.BackColor = Color.LightSalmon;
            btnModBox.BackColor = Color.LightSalmon;

            if(userService.checkForOrganizerRole(_selectedUser))
            {
                btnOrganizerBox.BackColor = Color.LightGreen;
            }
            if (userService.checkForModRole(_selectedUser))
            {
                btnModBox.BackColor = Color.LightGreen;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
