﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.ViewModels
{
    public class AccountListViewModel
    {
        public List<Models.Admin> Admin { get; set; }

        public List<Models.Car> Car { get; set; }

        //public List<Models.Classs> Classs { get; set; }

        public List<Models.FCustomer> FCustomer { get; set; }

        public List<Models.Line> Line { get; set; }

        //public List<Models.Order> Order { get; set; }

        public List<Models.SCustomer> SCustomer { get; set; }
    }
}