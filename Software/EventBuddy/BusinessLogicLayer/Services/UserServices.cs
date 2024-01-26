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
        
        public List<korisnik> getAllUsers()
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                List<korisnik> userList = repo.GetAll().ToList();
                return userList;
            }
        }

        public korisnik loginUser(string username, string password)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                var user = repo.loginUser(username, password);
                return user;
            }
        }
    }
}
