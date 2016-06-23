using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    //车辆管理信息表
    public class Car
    {
        [Key]
        [DisplayName("车辆编号")]
        public int CarID { get; set; }

        [DisplayName("车牌号")]
        [Required(ErrorMessage = "请输入车牌号")]
        public string CarNo { get; set; }

        [DisplayName("驾驶员")]
        [Required(ErrorMessage = "请输入驾驶员")]
        public string CarDiver { get; set; }

        [DisplayName("车辆路线")]
        public string CarAddress { get; set; }

        [DisplayName("车辆类型")]
        [Required(ErrorMessage = "请输入车辆类型")]
        public string CarType { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}