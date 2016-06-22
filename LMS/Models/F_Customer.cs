using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class F_Customer
    {
        [Key]
        public int F_CustoID { get; set; }

        public string F_CustoTel { get; set; }

        public string F_CustoName { get; set; }
    }
}