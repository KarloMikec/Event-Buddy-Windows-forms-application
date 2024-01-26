using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EventRepository : Repository<dogadaj>
    {
        public EventRepository(EventBuddyModel context) : base(context)
        {
        }

        public override IQueryable<dogadaj> GetAll()
        {
            var query = from e in Entities.Include("status").Include("korisnik").Include("kategorija")
                        select e;
            return query;
        }

        public int hideEvent(dogadaj entity, bool saveChanges = true)
        {
            var selectedEvent = Entities.SingleOrDefault(d => d.ID == entity.ID);
            selectedEvent.ID_status = 5;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public IQueryable<string> GetLocations()
        {
            var query = from e in Entities select e.mjesto;
            return query.Distinct();
        }

        public ICollection<korisnik> GetEventParticipants(dogadaj _event)
        {
            var query = Entities.FirstOrDefault(e => e.ID == _event.ID).korisnik1;
            return query;
        }

        public bool RemoveUserFromEvent(dogadaj _event, korisnik user)
        {
            using(var context = new EventBuddyModel())
            {
                var selectedUser = (from e in context.korisnik select e).FirstOrDefault(e => e.ID == user.ID);
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                selectedEvent.korisnik1.Remove(selectedUser);
                return context.SaveChanges() > 0;
            }
        }

        public bool BanUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedUser = (from e in context.korisnik select e).FirstOrDefault(e => e.ID == user.ID);
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                selectedEvent.korisnik1.Remove(selectedUser);
                selectedEvent.korisnik2.Add(selectedUser);
                return context.SaveChanges() > 0;
            }
        }

        public override int Update(dogadaj entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
