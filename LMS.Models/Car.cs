using System;
namespace LMS.Model
{
    /// <summary>
    /// 车辆管理信息表Car
    /// </summary>
    [Serializable]
    public partial class Car
    {
        public Car()
        { }
        private int _carid;
        private string _carno;
        private string _cardiver;
        private string _caraddress;
        private string _cartype;
        /// <summary>
        /// 车辆编号
        /// </summary>
        public int CarID
        {
            set { _carid = value; }
            get { return _carid; }
        }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string CarNo
        {
            set { _carno = value; }
            get { return _carno; }
        }
        /// <summary>
        /// 驾驶员
        /// </summary>
        public string CarDiver
        {
            set { _cardiver = value; }
            get { return _cardiver; }
        }
        /// <summary>
        /// 车辆路线
        /// </summary>
        public string CarAddress
        {
            set { _caraddress = value; }
            get { return _caraddress; }
        }
        /// <summary>
        /// 车辆类型
        /// </summary>
        public string CarType
        {
            set { _cartype = value; }
            get { return _cartype; }
        }
    }
}

