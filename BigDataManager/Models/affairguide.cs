//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigDataManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class affairguide
    {
        public int GUIDEID { get; set; }
        public int AFFAIRID { get; set; }
        public string ACCORDING { get; set; }
        public string PROCEDURES { get; set; }
        public string MATERIAL { get; set; }
        public string INSTITUTION { get; set; }
        public string ACCESSORYPATH { get; set; }
    
        public virtual affairs affairs { get; set; }
    }
}
