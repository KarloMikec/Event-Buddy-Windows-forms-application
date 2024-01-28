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
    public class CategoryServices
    {
        public void addNewCategory(kategorija newCategory)
        {
            using (var repo = new CategoryRepository(new EventBuddyModel()))
            {
                repo.Add(newCategory);
            }
        }

        public List<kategorija> getAllRequests()
        {
            using (var repo = new CategoryRepository(new EventBuddyModel()))
            {
                List<kategorija> requestsList = repo.GetAll().ToList();
                return requestsList;
            }
        }
    }
}
