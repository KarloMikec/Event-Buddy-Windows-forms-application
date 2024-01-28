using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PresentationLayer
{
    public partial class frmRequest : MaterialForm
    {
        public UserServices userServices = new UserServices();
        public RequestCategoryServices requestCategoryServices = new RequestCategoryServices();
        public PDFServices pDFServices = new PDFServices();
        public frmRequest()
        {
            InitializeComponent();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            RefreshData();
        }

        private void RefreshGUI()
        {

            lblNewCategory.Text = "Zahtjev za novu kategoriju";
            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnAccept.Text = "Prihvati";
            btnReject.Text = "Odbaciti";
            btnModifyData.Text = "Izmijeniti podatke";
            btnSave.Text = "Spremi";
            btnCancel.Text = "Odustani";

          

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblNewCategory.Text = translations.First(t => t.ID_atributa == "lblNewCategory").prijevod;
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnAccept.Text = translations.First(t => t.ID_atributa == "btnAccept").prijevod;
                btnReject.Text = translations.First(t => t.ID_atributa == "btnReject").prijevod;
                btnModifyData.Text = translations.First(t => t.ID_atributa == "btnModifyData").prijevod;
                btnSave.Text = translations.First(t => t.ID_atributa == "btnSave").prijevod;
                btnCancel.Text = translations.First(t => t.ID_atributa == "btnCancel").prijevod;

            }
        }

        private void RefreshData()
        {
            dgvRequest.DataSource = requestCategoryServices.getAllRequests();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvRequest.CurrentRow?.DataBoundItem as zahtjev_kategorija;
            if (selectedRequst != null)
            {
                requestCategoryServices.acceptCategoryRequest(selectedRequst);
                RefreshData();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvRequest.CurrentRow?.DataBoundItem as zahtjev_kategorija;
            if (selectedRequst != null)
            {
                requestCategoryServices.declineCategoryRequest(selectedRequst);
                RefreshData();
            }
        }

        private void btnModifyData_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvRequest.CurrentRow?.DataBoundItem as zahtjev_kategorija;
            if (selectedRequst != null)
            {
                dgvRequest.Visible = false;
                btnAccept.Visible = false;
                btnReject.Visible = false;
                btnModifyData.Visible = false;
                btnSaveAsPDF.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnModifyData.Visible = false;
                dgvRequest.Visible = false;
                txtNameOfCategory.Visible = true;
                txtNameOfCategory.Text = selectedRequst.naslov;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvRequest.CurrentRow?.DataBoundItem as zahtjev_kategorija;
            if (selectedRequst != null)
            {
                selectedRequst.naslov = txtNameOfCategory.Text;
                if(selectedRequst.naslov != "")
                {
                    requestCategoryServices.acceptCategoryRequest(selectedRequst);
                    RefreshData();
                    showMainData();
                }
                else
                {
                    MessageBox.Show("Naziv kategorije ne smije biti prazan");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            showMainData();
        }

        private void showMainData()
        {

            dgvRequest.Visible = true;
            btnAccept.Visible = true;
            btnReject.Visible = true;
            btnModifyData.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnSaveAsPDF.Visible = true;
            dgvRequest.Visible = true;
            txtNameOfCategory.Visible = false;
        }

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            pDFServices.saveCategoryRequestsAsPDF(dgvRequest.DataSource as List<zahtjev_kategorija>, frmLogin.user);
        }
    }
}
