using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeCareService.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Employee")]
    public class Employee : Person
    {

        public int Salary { get; set; }

        [Display(Name = "Service")]
        public int services_ID { get; set; }

        [ForeignKey("services_ID")]
        public virtual Service services { get; set; }
    }
}