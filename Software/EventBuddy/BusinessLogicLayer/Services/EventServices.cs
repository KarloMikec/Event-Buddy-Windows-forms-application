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
        public List<dogadaj> getAllEvents()
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
    }
}
