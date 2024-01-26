using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RequestOrganizerRepository : Repository<zahtjev_organizator>
    {
        public RequestOrganizerRepository(EventBuddyModel context) : base(context)
        {
        }

        public void acceptOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            selectedRequst.prihvacen = true;
            Entities.AddOrUpdate(selectedRequst);
            SaveChanges();
        }

        public void declineOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            Remove(selectedRequst);
        }

        public override IQueryable<zahtjev_organizator> GetAll()
        {
            var query = from e in Entities.Include("korisnik")
                        select e;
            return query;
        }

        public override int Update(zahtjev_organizator entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
