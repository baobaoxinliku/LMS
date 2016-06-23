using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class FCustomer
    {
        [Key]
        public int FCustoID { get; set; }

        public string FCustoTel { get; set; }

        public string FCustoName { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}