using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MockCraigsList.Models {
    public class User {
        public int id { get; set; }
        public string Email { get; set; }
        public List<Listing> userListings { get; set; }

    }
}