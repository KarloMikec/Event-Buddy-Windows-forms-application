using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EventServices
    {
        public List<dogadaj> GetAllEvents()
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                List<dogadaj> eventList = repo.GetAll().ToList();
                return eventList;
            }
        }

        public int hideEvent(dogadaj selectedEvent)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.hideEvent(selectedEvent);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public List<string> GetLocations()
        {
            using(var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.GetLocations().ToList();
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public List<korisnik> GetEventParticipants(dogadaj _event)
        {
            using(var repo = new EventRepository(new EventBuddyModel()))
            {
                var participants = repo.GetEventParticipants(_event).ToList();
                return participants;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool RemoveUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.RemoveUserFromEvent(_event, user);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool BanUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.BanUserFromEvent(_event, user);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool DismissEvent(dogadaj _event)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.DismissEvent(_event);
            }
        }
    }
}
