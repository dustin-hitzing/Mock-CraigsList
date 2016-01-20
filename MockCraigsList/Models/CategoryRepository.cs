using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class CategoryRepository: GenericRepository<Category> {
        public CategoryRepository(DbContext db) : base(db) { }


        //public IList<Category> List() {
        //    var categories = (from c in _db.Categories
        //                      where c.Active
        //                      select c).ToList();
        //    return categories;
        //}
        //public Category Find(int id) {
        //    var category = (from c in _db.Categories
        //                    where c.Active && c.Id == id
        //                    select c).FirstOrDefault();
        //    return category;
        //}
        //public bool Add(Category newCategory) {
        //    try {
        //        _db.Categories.Add(newCategory);
        //        _db.SaveChanges();
        //        return true;
        //    }
        //    catch {
        //        return false;
        //    }
        //}
        public bool Update(Category updates) {
            var dbCat = Get(updates.id);
            if(dbCat != null) {
                dbCat.Name = updates.Name;
                dbCat.Listings = updates.Listings;
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