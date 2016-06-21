using System;
using System.ComponentModel;
namespace LMS.Model
{
    /// <summary>
    /// 管理员信息表Admin
    /// </summary>
    [Serializable]
    public partial class Admin
    {
        public Admin()
        { }
        private int _adminno;
        private string _adminname;
        private string _adminaccount;
        private string _adminpwd;
        private string _admintel;
        private string _adminsex;
        /// <summary>
        /// 管理员编号
        /// </summary>
        public int AdminNo
        {
            set { _adminno = value; }
            get { return _adminno; }
        }
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AdminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string AdminAccount
        {
            set { _adminaccount = value; }
            get { return _adminaccount; }
        }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPwd
        {
            set { _adminpwd = value; }
            get { return _adminpwd; }
        }
        /// <summary>
        /// 管理员电话
        /// </summary>
        public string AdminTel
        {
            set { _admintel = value; }
            get { return _admintel; }
        }
        /// <summary>
        /// 管理员性别
        /// </summary>
        public string AdminSex
        {
            set { _adminsex = value; }
            get { return _adminsex; }
        }
    }
}

