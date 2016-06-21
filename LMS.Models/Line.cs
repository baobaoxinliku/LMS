using System;
namespace LMS.Model
{
    /// <summary>
    /// 路线信息表Line
    /// </summary>
    [Serializable]
    public partial class line
    {
        public line()
        { }
        private int _lineid;
        private int _linelength;
        private string _start;
        private string _line;
        private string _end;
        /// <summary>
        /// 路线编号
        /// </summary>
        public int LineID
        {
            set { _lineid = value; }
            get { return _lineid; }
        }
        /// <summary>
        /// 路线长度
        /// </summary>
        public int LineLength
        {
            set { _linelength = value; }
            get { return _linelength; }
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
        /// 中转站
        /// </summary>
        public string Line
        {
            set { _line = value; }
            get { return _line; }
        }
        /// <summary>
        /// 终点站
        /// </summary>
        public string End
        {
            set { _end = value; }
            get { return _end; }
        }
    }
}

