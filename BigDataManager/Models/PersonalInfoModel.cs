using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigDataManager.Models
{
    public class PersonalInfoModel
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 姓别
        /// </summary>
        public string Sex { get; set; }
        
        /// <summary>
        /// 出生年月
        /// </summary>
        public string Birth { get; set; }
    }
}