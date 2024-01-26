using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RoleRepository : Repository<uloga>
    {
        public RoleRepository(EventBuddyModel context) : base(context)
        {
        }

        public override int Update(uloga entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
