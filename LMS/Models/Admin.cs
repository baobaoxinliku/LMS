using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Admin
    {
        [Key]
        public int AdminNo { get; set; }

        [Required(ErrorMessage ="请输入姓名")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "请输入账号")]
        public string AdminAccount { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        public string AdminPwd { get; set; }

        public string AdminTel { get; set; }
        public string AdminIntro { get; set; }
    }
}