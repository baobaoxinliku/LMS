using System;
namespace LMS.Model
{
    /// <summary>
    /// 发货人信息表F_Customer
    /// </summary>
    [Serializable]
    public partial class F_Customer
    {
        public F_Customer()
        { }
        private int _f_custono;
        private string _f_custotel;
        private string _f_custoname;
        /// <summary>
        /// 发货人编号
        /// </summary>
        public int F_CustoNo
        {
            set { _f_custono = value; }
            get { return _f_custono; }
        }
        /// <summary>
        /// 发货人电话
        /// </summary>
        public string F_CustoTel
        {
            set { _f_custotel = value; }
            get { return _f_custotel; }
        }
        /// <summary>
        /// 发货人姓名
        /// </summary>
        public string F_CustoName
        {
            set { _f_custoname = value; }
            get { return _f_custoname; }
        }
    }
}

