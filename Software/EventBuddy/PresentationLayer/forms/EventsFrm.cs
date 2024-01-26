using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using PresentationLayer.forms;
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
    public partial class EventsFrm : Form
    {
        public EventsFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showEvents();
        }

        private void btnSakrij_Click(object sender, EventArgs e)
        {
            if(dgvEvents.SelectedRows != null)
            {
                var selectedEvent = dgvEvents.CurrentRow.DataBoundItem as dogadaj;
                HideEventFrm hideEventFrm = new HideEventFrm(selectedEvent);
                hideEventFrm.Show();
                showEvents();
            }
        }

        private void showEvents()
        {
            EventServices eventService = new EventServices();
            dgvEvents.DataSource = eventService.getAllEvents();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            UsersFrm usersFrm = new UsersFrm();
            Hide();
            usersFrm.Show();
        }
    }
}
