using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace HomeCareService.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Customer")]
    public class Customer : Person
    {
        public Customer() 
        {
            this.Services = new HashSet<Service>();
        }
        public int Payment { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }


}