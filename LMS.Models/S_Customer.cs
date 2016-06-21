using System;
namespace LMS.Model
{
    /// <summary>
    /// 收货人信息表S_Customer
    /// </summary>
    [Serializable]
    public partial class S_Customer
    {
        public S_Customer()
        { }
        private int _s_custono;
        private string _s_custotel;
        private string _s_custoname;
        /// <summary>
        /// 收货人编号
        /// </summary>
        public int S_CustoNo
        {
            set { _s_custono = value; }
            get { return _s_custono; }
        }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string S_CustoTel
        {
            set { _s_custotel = value; }
            get { return _s_custotel; }
        }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string S_CustoName
        {
            set { _s_custoname = value; }
            get { return _s_custoname; }
        }
    }
}

