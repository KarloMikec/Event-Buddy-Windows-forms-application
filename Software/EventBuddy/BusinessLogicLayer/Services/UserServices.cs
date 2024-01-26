using DataAccessLayer.Repositories;
using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UserServices
    {
        public int warnUser(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.warnUser(userID);
            }
        }

        public int revokeOrganizerRole(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.revokeOrganizerRole(userID);
            }
        }
    }
}
