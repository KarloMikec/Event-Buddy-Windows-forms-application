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
        RequestOrganizerService requestOrganizerService = new RequestOrganizerService();
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
            showRequests();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows != null)
            {
                var selectedUser = dgvUsers.CurrentRow.DataBoundItem as korisnik;
                EditUserFrm editUserFrm = new EditUserFrm(selectedUser);
                editUserFrm.ShowDialog();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgvUserRequests.SelectedRows != null)
            {
                var selectedRequst = dgvUserRequests.CurrentRow.DataBoundItem as zahtjev_organizator;
                requestOrganizerService.declineOrganizerRequest(selectedRequst);
                showRequests();
            }
        }

        private void showRequests()
        {
            dgvUserRequests.DataSource = requestOrganizerService.getAllRequests();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvUserRequests.SelectedRows != null)
            {
                var selectedRequst = dgvUserRequests.CurrentRow.DataBoundItem as zahtjev_organizator;
                requestOrganizerService.acceptOrganizerRequest(selectedRequst);
                userService.addOrganizerRole(selectedRequst.ID_korisnik);
                showRequests();
            }
        }
    }
}
