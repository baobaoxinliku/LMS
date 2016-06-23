using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Line
    {
        [Key]
        [DisplayName("路线编号")]
        public int LineID { get; set; }

        [DisplayName("路线长度")]
        public int LineLength { get; set; }

        [DisplayName("起始站")]
        public string Start { get; set; }

        [DisplayName("中转站")]
        public string Lines { get; set; }

        [DisplayName("目的地")]
        public string End { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}