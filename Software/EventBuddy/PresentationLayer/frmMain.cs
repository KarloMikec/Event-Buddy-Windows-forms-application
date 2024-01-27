﻿using BusinessLogicLayer.Services;
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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        EventServices eventServices = new EventServices();
        UserServices userServices = new UserServices();

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            var loggedInUser = frmLogin.user;
            var isAdmin = userServices.checkForAdminRole(loggedInUser);
            if (isAdmin)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnCategories.Visible = true;
                btnUsers.Visible = true;
            }
            RefreshGUI();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void RefreshGUI()
        {
            cmbLocation.DataSource = eventServices.GetLocations();
            dgvEvents.DataSource = eventServices.GetAllEvents();
            HideFields();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searched = txtSearch.Text;
            var events = eventServices.GetAllEvents();
            var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            var filtered = await Task.Run(() => FilterEvents(searched, date, events));
            dgvEvents.DataSource = filtered;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private List<dogadaj> FilterEvents(string searched, DateTime date, List<dogadaj> events)
        {
            return events.FindAll(
                x =>
                    x.naziv.ToLower().Contains(searched.ToLower()) &&
                    x.datum >= date
            );
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private List<dogadaj> FilterEvents(string location, string searched, DateTime date, List<dogadaj> events)
        {
            return events.FindAll(
                x =>
                    x.naziv.ToLower().Contains(searched.ToLower()) &&
                    x.mjesto == location && x.datum >= date
            );
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var location = cmbLocation.SelectedItem as string;
            if (location == null) return;
            var events = eventServices.GetAllEvents();
            var searched = txtSearch.Text;
            var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            dgvEvents.DataSource = FilterEvents(location, searched, date, events);
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void HideFields()
        {
            dgvEvents.Columns[5].Visible = false;
            dgvEvents.Columns[6].Visible = false;
            dgvEvents.Columns[7].Visible = false;
            dgvEvents.Columns[11].Visible = false;
            dgvEvents.Columns[12].Visible = false;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                frmParticipants _frmParticipants = new frmParticipants(_event);
                _frmParticipants.ShowDialog();
                RefreshGUI();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfil frmProfil = new frmProfil();
            frmProfil.ShowDialog();
        }

        private void btnHideEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows != null)
            {
                var selectedEvent = dgvEvents.CurrentRow.DataBoundItem as dogadaj;
                HideEventFrm hideEventFrm = new HideEventFrm(selectedEvent);
                hideEventFrm.ShowDialog();
                RefreshGUI();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersFrm usersFrm = new UsersFrm();
            Hide();
            usersFrm.ShowDialog();
            Show();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnDismissEvent_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                var dialogResult = MessageBox.Show($"Jeste li sigurni da želite obustaviti događaj {_event.ID}", "Obustavljanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (eventServices.DismissEvent(_event))
                    {
                        MessageBox.Show($"Događaj {_event.ID} obustavljen!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGUI();
                    }
                    else MessageBox.Show($"Greška prilikom obustavljanja događaja {_event.ID}!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Morate odabrati neki događaj da biste ga obustavili!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
