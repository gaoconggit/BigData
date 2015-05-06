using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigDataManager.Models
{
    public class RegionModel
    {
        /// <summary>
        /// 镇街代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 镇街名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 结构化总计
        /// </summary>
        public int StructuringCount { get; set; }
        /// <summary>
        /// 非结构化总计
        /// </summary>
        public int NotStructuringCount { get; set; }
        
    }
}