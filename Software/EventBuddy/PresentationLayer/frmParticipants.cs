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

namespace PresentationLayer
{
    public partial class frmParticipants : Form
    {
        private dogadaj Event { get; set; }
        private EventServices eventServices = new EventServices();
        public frmParticipants(dogadaj _event)
        {
            InitializeComponent();
            Event = _event;
        }

        private void frmParticipants_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            var participants = eventServices.GetEventParticipants(Event);
            dgvParticipants.DataSource = participants;
        }
    }
}
