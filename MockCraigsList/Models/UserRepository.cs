using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class UserRepository:GenericRepository<User> {
       public UserRepository(DbContext db) : base(db) { }

        //public IList<User> List() {
        //    var users = (from u in _db.Users
        //                 where u.Active
        //                 select u).ToList();
        //    return users;
        //}
        //public User Find(int id) {
        //    var user = (from u in _db.Users
        //                where u.Active && u.id == id
        //                select u).FirstOrDefault();
        //    return user;

        //}
        //public bool Add(User newUser) {
        //    try {
        //        _db.Users.Add(newUser);
        //        _db.SaveChanges();
        //        return true;
        //    }
        //    catch {
        //        return false;
        //    }
        //}
        public bool Update(User updates) {
            var dbUser = Find(updates.id);
            if (dbUser != null) {
                dbUser.Email = dbUser.Email;
                dbUser.userListings = dbUser.userListings;
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