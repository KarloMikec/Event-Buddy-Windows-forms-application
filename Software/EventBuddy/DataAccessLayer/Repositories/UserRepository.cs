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

        public override int Update(korisnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
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
