using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class Listing {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public Category myCat { get; set; }
        public User Owner { get; set; }

    }
}