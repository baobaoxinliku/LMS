using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class S_Customer
    {
        [Key]
        public int S_CustoID { get; set; }

        public string S_CustoTel { get; set; }

        public string S_CustoName { get; set; }
    }
}