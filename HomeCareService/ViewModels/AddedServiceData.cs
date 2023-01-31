using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCareService.ViewModels
{
    public class AddedServiceData
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public bool Assigned { get; set; }
    }
}