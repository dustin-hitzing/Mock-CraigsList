using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class ListingRepository: GenericRepository<Listing> {


        public ListingRepository(DbContext db) : base(db) { }

        public IList<Listing> FindByCategory(string cat) {
            return (from l in Table
                    where l.Active && l.myCat.Name == cat
                    select l).ToList();
        }

        

        public bool Update(Listing updates) {
            var dbItem = Get(updates.id);
            if (dbItem != null) {
                dbItem.Description = updates.Description;
                dbItem.myCat = updates.myCat;
                dbItem.Owner = updates.Owner;
                dbItem.Picture = updates.Picture;
                dbItem.Title = updates.Title;
                try {
                    _db.SaveChanges();
                    return true;
                }
                catch { }
                
            }
            return false;
        }

    }
}