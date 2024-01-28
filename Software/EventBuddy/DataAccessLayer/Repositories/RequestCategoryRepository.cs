using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RequestCategoryRepository : Repository<zahtjev_kategorija>
    {
        public RequestCategoryRepository(EventBuddyModel context) : base(context)
        {
        }

        public override int Update(zahtjev_kategorija entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void declineCategoryRequest(zahtjev_kategorija selectedRequst)
        {
            Remove(selectedRequst);
        }

    }
}
