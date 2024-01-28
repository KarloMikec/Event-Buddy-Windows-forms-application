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
    public partial class frmCategories : MaterialForm
    {
        public UserServices userServices = new UserServices();
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {

            lblCategory.Text = "Kategorije";
            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnSearch.Text = "Pretraži";
            btnAdd.Text = "Dodaj";
            btnRequest.Text = "Zahtjevi";
            btnEdit.Text = "Izmijeni podatke";
            btnDelete.Text = "Obriši kategoriju";

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblCategory.Text = translations.First(t => t.ID_atributa == "lblCategory").prijevod;
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnSearch.Text = translations.First(t => t.ID_atributa == "btnSearch").prijevod;
                btnAdd.Text = translations.First(t => t.ID_atributa == "btnAdd").prijevod;
                btnRequest.Text = translations.First(t => t.ID_atributa == "btnRequest").prijevod;
                btnEdit.Text = translations.First(t => t.ID_atributa == "btnEdit").prijevod;
                btnDelete.Text = translations.First(t => t.ID_atributa == "btnDelete").prijevod;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }
    }
}
