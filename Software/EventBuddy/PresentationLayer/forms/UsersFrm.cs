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
        PDFServices pDFServices = new PDFServices();
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
            showRequests();
            showUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var selectedUser = dgvUsers.CurrentRow?.DataBoundItem as korisnik;
            if (selectedUser != null)
            {
                EditUserFrm editUserFrm = new EditUserFrm(selectedUser);
                editUserFrm.ShowDialog();
            }
        }

        private void showRequests()
        {
            dgvUserRequests.DataSource = requestOrganizerService.getAllRequests();
        }

        private void showUsers()
        {
            dgvUsers.DataSource = userService.getAllUsers();
            dgvUsers.Columns[6].Visible = false;
            dgvUsers.Columns[7].Visible = false;
            dgvUsers.Columns[8].Visible = false;
            dgvUsers.Columns[9].Visible = false;
            dgvUsers.Columns[10].Visible = false;
            dgvUsers.Columns[11].Visible = false;
            dgvUsers.Columns[12].Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvUserRequests.CurrentRow?.DataBoundItem as zahtjev_organizator;
            if (selectedRequst != null)
            {
                requestOrganizerService.acceptOrganizerRequest(selectedRequst);
                userService.addOrganizerRole(selectedRequst.ID_korisnik);
                showRequests();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvUserRequests.CurrentRow?.DataBoundItem as zahtjev_organizator;
            if (selectedRequst != null)
            {
                requestOrganizerService.declineOrganizerRequest(selectedRequst);
                showRequests();
            }
        }

        private void btnSaveAsPDFUsers_Click(object sender, EventArgs e)
        {
            pDFServices.saveUsersAsPDF(dgvUsers.DataSource as List<korisnik>, frmLogin.user);
        }

        private void btnSaveAsPDFRequests_Click(object sender, EventArgs e)
        {
            pDFServices.saveOrganizerRequestsAsPDF(dgvUserRequests.DataSource as List<zahtjev_organizator>, frmLogin.user);
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            showUsers();
        }

        private void btnRefreshRequests_Click(object sender, EventArgs e)
        {
            showRequests();
        }
    }
}
