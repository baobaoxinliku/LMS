using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LMS.Models
{
    public class Admin
    {
        [Key]
        [DisplayName("管理员编号")]
        public int AdminNo { get; set; }

        [DisplayName("管理员姓名")]
        [Required(ErrorMessage ="请输入姓名")]
        public string AdminName { get; set; }

        [DisplayName("管理员账号")]
        [Required(ErrorMessage = "请输入账号")]
        public string AdminAccount { get; set; }

        [DisplayName("管理员密码")]
        [Required(ErrorMessage = "请输入密码")]
        public string AdminPwd { get; set; }

        [DisplayName("管理员电话")]
        public string AdminTel { get; set; }

        [DisplayName("管理员简介")]
        public string AdminIntro { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}