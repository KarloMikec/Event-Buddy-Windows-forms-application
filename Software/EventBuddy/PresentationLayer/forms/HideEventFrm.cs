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
    public partial class HideEventFrm : Form
    {
        dogadaj _selectedEvent = null;
        EventServices eventServices = new EventServices();
        UserServices userServices = new UserServices();
        public HideEventFrm(dogadaj selectedEvent)
        {
            _selectedEvent = selectedEvent;
            InitializeComponent();
        }
        private void btnHideEvent_Click(object sender, EventArgs e)
        {
            eventServices.hideEvent(_selectedEvent);
            userServices.warnUser(_selectedEvent.ID_korisnik);
            Close();
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            userServices.revokeOrganizerRole(_selectedEvent.ID_korisnik);
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {   
            Close();
        }

    }
}
