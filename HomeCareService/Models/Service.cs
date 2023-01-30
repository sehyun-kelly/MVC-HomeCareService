using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCareService.Models
{
    public class Service
    {
        public Service()
        {
            this.Customers = new List<Customer>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}