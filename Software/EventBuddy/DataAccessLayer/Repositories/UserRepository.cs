using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<korisnik>
    {
        public UserRepository(EventBuddyModel context) : base(context)
        {
        }

        public override IQueryable<korisnik> GetAll()
        {
            var query = from e in Entities.Include("dogadaj").Include("zahtjev_organizator").Include("zahtjev_kategorija")
                        select e;
            return query;
        }

        public korisnik loginUser(string username, string password)
        {
            var user = Entities.SingleOrDefault(u => u.korime == username && u.lozinka == password);
            return user;
        }

        public override int Update(korisnik entity, bool saveChanges = true)
        {
            var user = Entities.First(e => e.ID == entity.ID);
            if (user != null)
            {
                user.lozinka = entity.lozinka;
            }
            return saveChanges ? SaveChanges() : 0;
        }

        public int warnUser(int userID, bool saveChanges = true)
        {
            var user = Entities.SingleOrDefault(d => d.ID == userID);
            user.upozorenja += 1;
            if(user.upozorenja > 1)
            {
                revokeOrganizerRole(userID);
            }

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int revokeOrganizerRole(int userID, bool saveChanges = true)
        {
            return revokeRole(userID, "Organizator");
        }

        public int revokeModRole(int userID, bool saveChanges = true)
        {
            return revokeRole(userID, "Moderator");
        }

        public int revokeRole(int userID, string roleName, bool saveChanges = true)
        {
            var user = Entities.SingleOrDefault(d => d.ID == userID);
            var uloga = user.uloga.First(x => x.Naziv == roleName) as uloga;
            user.uloga.Remove(uloga);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public bool checkForOrganizerRole(korisnik selectedUser)
        {
            return checkForRole("Organizator", selectedUser);
        }

        public bool checkForModRole(korisnik selectedUser)
        {
            return checkForRole("Moderator", selectedUser);
        }

        public bool checkForRole(string roleName, korisnik selectedUser)
        {
            var user = Entities.SingleOrDefault(d => d.ID == selectedUser.ID);

            if (user != null && user.uloga.Any(x => x.Naziv == roleName))
            {
                return true;
            }

            return false;
        }
    }
}
