using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MockCraigsList.Models {
    public class User:IDbEntity,IActivatable {
        public int id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public IList<Listing> userListings { get; set; }
        public bool Active { get; set; } = true;
    }
}