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
    /// <summary>
    /// <author>Dominik Josipović</author>
    /// </summary>
    public partial class frmParticipants : Form
    {
        private dogadaj Event { get; set; }
        private EventServices eventServices = new EventServices();
        public frmParticipants(dogadaj _event)
        {
            InitializeComponent();
            Event = _event;
            Text = Event.naziv;
        }

        private void frmParticipants_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            var participants = eventServices.GetEventParticipants(Event);
            dgvParticipants.DataSource = participants;
            dgvParticipants.Columns[4].Visible = false;
            dgvParticipants.Columns[5].Visible = false;
            dgvParticipants.Columns[6].Visible = false;
            dgvParticipants.Columns[7].Visible = false;
            dgvParticipants.Columns[8].Visible = false;
            dgvParticipants.Columns[9].Visible = false;
            dgvParticipants.Columns[10].Visible = false;
            dgvParticipants.Columns[11].Visible = false;
            dgvParticipants.Columns[12].Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var user = dgvParticipants.CurrentRow?.DataBoundItem as korisnik;
            if (user != null)
            {
                var dialogResult = MessageBox.Show($"Ukloniti korisnika {user}?", "Uklanjanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool executed = eventServices.RemoveUserFromEvent(Event, user);
                    RefreshGUI();
                    if (executed) MessageBox.Show($"Korisnik {user} uspješno uklonjen!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Greška prilikom uklanjanja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Morate označiti korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            var user = dgvParticipants.CurrentRow?.DataBoundItem as korisnik;
            if (user != null)
            {
                var dialogResult = MessageBox.Show($"Zabraniti pristup korisniku {user}?", "Zabrana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool executed = eventServices.BanUserFromEvent(Event, user);
                    RefreshGUI();
                    if (executed) MessageBox.Show($"Korisniku {user} uspješno zabranjen pristup!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Greška prilikom uklanjanja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Morate označiti korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
