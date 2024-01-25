using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<korisnik>
    { // getUser metoda
        public UserRepository(EventBuddyModel context) : base(context)
        {
        }
    }
}
