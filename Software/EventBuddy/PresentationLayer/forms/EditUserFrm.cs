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
        bool organizerRoleInit = false;
        bool organizerRoleAfter = false;
        bool modRoleInit = false;
        bool modRoleAfter = false;
        public EditUserFrm(korisnik selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
        }

        private void EditUserFrm_Load(object sender, EventArgs e)
        {
            txtName.Text = _selectedUser.ime;
            txtSurname.Text = _selectedUser.prezime;
            txtUsername.Text = _selectedUser.korime;
            txtNumberOfWarnings.Text = _selectedUser.upozorenja.ToString();

            btnOrganizerBox.BackColor = Color.LightSalmon;
            btnModBox.BackColor = Color.LightSalmon;

            if(userService.checkForOrganizerRole(_selectedUser))
            {
                btnOrganizerBox.BackColor = Color.LightGreen;
                btnOrganizer.Text = "Makni ulogu";
                organizerRoleInit = true;
                organizerRoleAfter = true;
            }
            if (userService.checkForModRole(_selectedUser))
            {
                btnModBox.BackColor = Color.LightGreen;
                btnOrganizer.Text = "Makni ulogu";
                modRoleInit = true;
                modRoleAfter = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrganizer_Click(object sender, EventArgs e)
        {
            if(btnOrganizerBox.BackColor == Color.LightGreen)
            {
                btnOrganizerBox.BackColor = Color.LightSalmon;
                btnOrganizer.Text = "Dodaj ulogu";
                organizerRoleAfter = false;
            }
            else
            {
                btnOrganizerBox.BackColor = Color.LightGreen;
                btnOrganizer.Text = "Makni ulogu";
                organizerRoleAfter = true;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (btnModBox.BackColor == Color.LightGreen)
            {
                btnModBox.BackColor = Color.LightSalmon;
                btnMod.Text = "Dodaj ulogu";
                modRoleAfter = false;
            }
            else
            {
                btnModBox.BackColor = Color.LightGreen;
                btnMod.Text = "Makni ulogu";
                modRoleAfter = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (organizerRoleInit != organizerRoleAfter)
            {
                MessageBox.Show("Promijenjena uloga organizatora");
                if(!organizerRoleAfter)
                {
                    userService.revokeOrganizerRole(_selectedUser.ID);
                }
                else
                {
                    userService.addOrganizerRole(_selectedUser.ID);
                }
            }

            if (modRoleInit != modRoleAfter)
            {
                MessageBox.Show("Promijenjena uloga moderatora");
                if(!modRoleAfter)
                {
                    userService.revokeModRole(_selectedUser.ID);
                }
                else
                {
                    userService.addModRole(_selectedUser.ID);
                }
            }

            Close();
        }
    }
}
