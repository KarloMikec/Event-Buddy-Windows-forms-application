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
using MaterialSkin;
using MaterialSkin.Controls;

namespace PresentationLayer
{
    public partial class frmRequest : MaterialForm
    {
        public UserServices userServices = new UserServices();
        public frmRequest()
        {
            InitializeComponent();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {

            lblNewCategory.Text = "Zahtjev za novu kategoriju";
            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnAccept.Text = "Prihvati";
            btnReject.Text = "Odbaciti";
            btnModifyData.Text = "Izmijeniti podatke";
            Text = "Zahtjev za kategoriju";
          

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblNewCategory.Text = translations.First(t => t.ID_atributa == "lblNewCategory").prijevod;
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnAccept.Text = translations.First(t => t.ID_atributa == "btnAccept").prijevod;
                btnReject.Text = translations.First(t => t.ID_atributa == "btnReject").prijevod;
                btnModifyData.Text = translations.First(t => t.ID_atributa == "btnModifyData").prijevod;
                Text = translations.First(t => t.ID_atributa == "frmCategories").prijevod;
            }
        }
    }
}
