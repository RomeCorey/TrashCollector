using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int CustomerDay { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
    }
}