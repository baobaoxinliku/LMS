using System;
namespace LMS.Model
{
    /// <summary>
    /// 班次管理表Class
    /// </summary>
    [Serializable]
    public partial class Class
    {
        public Class()
        { }
        private int _classid;
        private string _start;
        private string _end;
        private DateTime _classtime;
        /// <summary>
        /// 班次编号
        /// </summary>
        public int ClassID
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 起始站
        /// </summary>
        public string Start
        {
            set { _start = value; }
            get { return _start; }
        }
        /// <summary>
        /// 终点站
        /// </summary>
        public string End
        {
            set { _end = value; }
            get { return _end; }
        }
        /// <summary>
        /// 发车时间
        /// </summary>
        public DateTime ClassTime
        {
            set { _classtime = value; }
            get { return _classtime; }
        }
        /// <summary>
        /// 车辆编号
        /// </summary>
        public Car CarID
        {  set ; get ;  }
    }
}

