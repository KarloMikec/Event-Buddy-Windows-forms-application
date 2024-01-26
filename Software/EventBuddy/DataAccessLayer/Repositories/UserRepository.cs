﻿using EntitiesLayer.Entities;
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

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
