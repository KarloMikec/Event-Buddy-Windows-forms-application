﻿using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class PDFServices
    {
        private List<dogadaj> _eventList;
        private List<korisnik> _userList;
        private int currentItemIndex;
        private korisnik _user;
        private EventServices eventServices = new EventServices();
        public void saveEventsAsPDF(List<dogadaj> eventList, korisnik user)
        {
            _eventList = eventList;
            _user = user;
            PrintDocument document = new PrintDocument();
            document.DefaultPageSettings.Landscape = true;
            document.PrintPage += new PrintPageEventHandler(saveEventsAsPDFPrintPage);
            currentItemIndex = 0;
            document.Print();
        }

        private void saveEventsAsPDFPrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            Font fontSmall = new Font("Arial", 10);
            Font fontBig = new Font("Arial", 16);
            int x = 50;
            int y = 50;
            int width = 50;
            int height = 50;

            graphics.DrawString("ID", fontBig, Brushes.Black, new PointF(x, y));
            graphics.DrawString("Organizator", fontBig, Brushes.Black, new PointF(x + width, y));
            graphics.DrawString("Status", fontBig, Brushes.Black, new PointF(x + width * 4, y));
            graphics.DrawString("Mjesto", fontBig, Brushes.Black, new PointF(x + width * 6, y));
            graphics.DrawString("Datum", fontBig, Brushes.Black, new PointF(x + width * 9, y));
            graphics.DrawString("Sudionici", fontBig, Brushes.Black, new PointF(x + width * 11, y));
            graphics.DrawString("Naziv", fontBig, Brushes.Black, new PointF(x + width * 13 + 20, y));

            graphics.DrawString("Kreirao: " + _user.ToString() + " na datum " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), fontSmall, Brushes.Black, new PointF(e.PageBounds.Width - 350, e.PageBounds.Height - 40));

            y += 50;

            while (currentItemIndex < _eventList.Count)
            {
                dogadaj cE = _eventList[currentItemIndex];
                graphics.DrawString(cE.ID.ToString(), font, Brushes.Black, new PointF(x, y));
                graphics.DrawString(cE.korisnik.ime + " " + cE.korisnik.prezime, font, Brushes.Black, new PointF(x + width, y));
                graphics.DrawString(cE.status.naziv, font, Brushes.Black, new PointF(x + width * 4, y));
                graphics.DrawString(cE.mjesto, font, Brushes.Black, new PointF(x + width * 6, y));
                graphics.DrawString(cE.datum.ToShortDateString(), font, Brushes.Black, new PointF(x + width * 9, y));
                graphics.DrawString(eventServices.GetEventParticipants(cE).Count().ToString(), font, Brushes.Black, new PointF(x + width * 11 + 50, y));
                graphics.DrawString(cE.naziv, font, Brushes.Black, new PointF(x + width * 13 + 20, y));
                y += height;
                currentItemIndex++;

                if (y > e.PageBounds.Height - 50)
                {
                    if (currentItemIndex < _eventList.Count)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                        currentItemIndex = 0;
                        return;
                    }
                }
            }
        }

        public void saveUsersAsPDF(List<korisnik> userList, korisnik user)
        {
            _userList = userList;
            _user = user;
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(saveUsersAsPDFPrintPage);
            currentItemIndex = 0;
            document.Print();
        }

        private void saveUsersAsPDFPrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            Font fontSmall = new Font("Arial", 10);
            Font fontBig = new Font("Arial", 16);
            int x = 50;
            int y = 50;
            int width = 50;
            int height = 50;

            graphics.DrawString("ID", fontBig, Brushes.Black, new PointF(x, y));
            graphics.DrawString("Korisničko ime", fontBig, Brushes.Black, new PointF(x + width, y));
            graphics.DrawString("Ime", fontBig, Brushes.Black, new PointF(x + width * 5, y));
            graphics.DrawString("Prezime", fontBig, Brushes.Black, new PointF(x + width * 8, y));
            graphics.DrawString("Upozorenja", fontBig, Brushes.Black, new PointF(x + width * 11, y));

            graphics.DrawString("Kreirao: " + _user.ToString() + " na datum " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), fontSmall, Brushes.Black, new PointF(e.PageBounds.Width - 350, e.PageBounds.Height - 40));

            y += 50;

            while (currentItemIndex < _userList.Count)
            {
                korisnik uE = _userList[currentItemIndex];
                graphics.DrawString(uE.ID.ToString(), font, Brushes.Black, new PointF(x, y));
                graphics.DrawString(uE.korime, font, Brushes.Black, new PointF(x + width, y));
                graphics.DrawString(uE.ime, font, Brushes.Black, new PointF(x + width * 5, y));
                graphics.DrawString(uE.prezime, font, Brushes.Black, new PointF(x + width * 8, y));
                graphics.DrawString(uE.upozorenja.ToString(), font, Brushes.Black, new PointF(x + width * 11 + 50, y));
                y += height;
                currentItemIndex++;

                if (y > e.PageBounds.Height - 50)
                {
                    if (currentItemIndex < _userList.Count)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                        currentItemIndex = 0;
                        return;
                    }
                }
            }
        }
    }
}
