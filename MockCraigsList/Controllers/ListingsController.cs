using MockCraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MockCraigsList.Controllers
{
    public class ListingsController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        public List<Listing> Get() {
            //shorthand of below
            return _db.Listings.ToList();

            //longhandway
            //var listings = (from L in _db.Listings
            //               select L).ToList();
            //return listings;
        }
    }
}
