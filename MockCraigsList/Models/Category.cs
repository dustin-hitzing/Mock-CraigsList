using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Listing> Listings { get; set; }

    }
}