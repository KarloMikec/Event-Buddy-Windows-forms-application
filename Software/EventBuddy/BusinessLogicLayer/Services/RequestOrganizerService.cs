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
    public class RequestOrganizerService
    {
        public void acceptOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            using (var repo = new RequestOrganizerRepository(new EventBuddyModel()))
            {
                repo.acceptOrganizerRequest(selectedRequst);
            }
        }

        public void declineOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            using (var repo = new RequestOrganizerRepository(new EventBuddyModel()))
            {
                repo.declineOrganizerRequest(selectedRequst);
            }
        }

        public List<zahtjev_organizator> getAllRequests()
        {
            using (var repo = new RequestOrganizerRepository(new EventBuddyModel()))
            {
                List<zahtjev_organizator> requestsList = repo.GetAll().ToList();
                return requestsList;
            }
        }
    }
}
