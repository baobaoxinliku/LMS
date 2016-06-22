using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.ViewModels
{
    public class IndexViewModel
    {
        public List<Models.Admin> Admins { get; set; }

        public List<Models.Car> Cars { get; set; }

        //public List<Models.Classs> Classss { get; set; }

        public List<Models.FCustomer> F_Customers { get; set; }

        //public List<Models.Line> Lines { get; set; }

        //public List<Models.Order> Orders { get; set; }

        public List<Models.S_Customer> S_Customers { get; set; }
    }
}