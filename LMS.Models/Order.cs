using System;
namespace LMS.Model
{
    /// <summary>
    /// 订单管理表Order
    /// </summary>
    [Serializable]
    public partial class Order
    {
        public Order()
        { }
        private int _orderid;
        private DateTime _ordertime;
        private string _address;
        private int _ordernum;
        private decimal _ordermoney;
        private string _s_custoname;
        private string _f_custoname;
        private string _goodsname;
        private string _start;
        private string _end;
        private string _path;
        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 车辆编号
        /// </summary>
        public Car CarID
        {  set ;  get ;  }
        /// <summary>
        /// 班次编号
        /// </summary>
        public Class ClassID
        { set ; get; }
        /// <summary>
        /// 订单时间
        /// </summary>
        public DateTime OrderTime
        {
            set { _ordertime = value; }
            get { return _ordertime; }
        }
        /// <summary>
        /// 订单地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 订单数量
        /// </summary>
        public int OrderNum
        {
            set { _ordernum = value; }
            get { return _ordernum; }
        }
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderMoney
        {
            set { _ordermoney = value; }
            get { return _ordermoney; }
        }
        /// <summary>
        /// 收货人编号
        /// </summary>
        public S_Customer S_CustoNo
        { set ; get ;  }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string S_CustoName
        {
            set { _s_custoname = value; }
            get { return _s_custoname; }
        }
        /// <summary>
        /// 发货人编号
        /// </summary>
        public F_Customer F_CustoNo
        { set; get; }
        /// <summary>
        /// 发货人姓名
        /// </summary>
        public string F_CustoName
        {
            set { _f_custoname = value; }
            get { return _f_custoname; }
        }
        /// <summary>
        /// 货物名称
        /// </summary>
        public string GoodsName
        {
            set { _goodsname = value; }
            get { return _goodsname; }
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
        /// 中转站
        /// </summary>
        public string Path
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 管理员编号
        /// </summary>
        public Admin AdminNo
        { set; get; }
        /// <summary>
        /// 路线编号
        /// </summary>
        public line LineID
        { set; get; }
    }
}

