using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockCraigsList.Models {
    public class Category: IDbEntity, IActivatable {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<Listing> Listings { get; set; }
        public bool Active { get; set; } = true;
    }
}