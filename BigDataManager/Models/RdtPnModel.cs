using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigDataManager.Models
{
    public class RdtPnModel
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 是否是本市
        /// </summary>
        public int IsLocalCity { get; set; }
    }
}