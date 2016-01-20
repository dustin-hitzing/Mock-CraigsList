using MockCraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MockCraigsList.Controllers {
    public class ListingsController : ApiController {
        private ListingRepository _repo;
        public ListingsController(ListingRepository repo) {
            _repo = repo;
        }


        public IList<Listing> Get() {

            return _repo.List();

        }

        public Listing Get(int id) {
            return _repo.Get(id);
        }

        public IHttpActionResult Post(Listing newListing) {
            if (ModelState.IsValid) {
                _repo.Add(newListing);
                _repo.SaveChanges();
                if (_repo.Get(newListing.id) != null) {
                    return Created("/api/listings/" + newListing.id, newListing);
                }
                return InternalServerError();
            }
            return BadRequest(ModelState);
        }

        public IHttpActionResult Post(int id, Listing updates) {
            updates.id = id;
            if (ModelState.IsValid) {
                updates.id = id;
                if (_repo.Update(updates)) {
                    return Ok();
                }
                return InternalServerError();
            }
            return BadRequest(ModelState);
        }
        public IHttpActionResult Delete(int id) {

            try {
                _repo.Delete(id);
                _repo.SaveChanges();
                return Ok();
            }
            catch { }
            return BadRequest();


        }
    }
}
