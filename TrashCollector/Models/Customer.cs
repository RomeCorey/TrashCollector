using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer : Address
    {
        [Key]
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int CustomerDay { get; set; }
    }
}