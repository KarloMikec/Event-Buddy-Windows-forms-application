using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using EntitiesLayer.Exceptions;
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
    public partial class frmEventDetails : MaterialForm
    {
        private EventServices eventServices = new EventServices();
        private dogadaj Event { get; set; }
        public frmEventDetails(dogadaj _event)
        {
            InitializeComponent();
            Event = _event;
            Text = Event.ToString();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void frmEventDetails_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            txtName.Text = Event.naziv;
            txtDescription.Text = Event.opis;
            txtLocation.Text = Event.mjesto;
            dtpDate.Value = Event.datum;
            dtpTime.Value = Event.datum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = true;
            try
            {
                var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
                Event.datum = date;
                Event.naziv = txtName.Text;
                Event.opis = txtDescription.Text;
                Event.mjesto = txtLocation.Text;
                eventServices.UpdateEvent(Event);
            }
            catch (EventException ex)
            {
                success = false;
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (success) Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
