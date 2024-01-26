using DataAccessLayer.Repositories;
using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        public int revokeModRole(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.revokeModRole(userID);
            }
        }

        public int addOrganizerRole(int userID)
        {
            using (var context = new EventBuddyModel())
            {
                var user = (from e in context.korisnik
                             select e).FirstOrDefault(r => r.ID == userID);

                var role = (from e in context.uloga
                             select e).FirstOrDefault(u => u.Naziv == "Organizator");

                user.uloga.Add(role);
                return context.SaveChanges();
            }
        }

        public int addModRole(int userID)
        {
            using (var context = new EventBuddyModel())
            {
                var user = (from e in context.korisnik
                            select e).FirstOrDefault(r => r.ID == userID);

                var role = (from e in context.uloga
                            select e).FirstOrDefault(u => u.Naziv == "Moderator");

                user.uloga.Add(role);
                return context.SaveChanges();
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

        public bool checkForOrganizerRole(korisnik user)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.checkForOrganizerRole(user);
            }
        }

        public bool checkForModRole(korisnik selectedUser)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.checkForModRole(selectedUser);
            }
        }
    }
}
