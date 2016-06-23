using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class SCustomer
    {
        [Key]
        public int SCustoID { get; set; }

        public string SCustoTel { get; set; }

        public string SCustoName { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}