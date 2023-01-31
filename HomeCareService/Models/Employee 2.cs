using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeCareService.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Employee")]
    public class Employee : Person
    {

        public int Salary { get; set; }

        public virtual Service services { get; set; }
    }
}