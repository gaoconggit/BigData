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
    
    public partial class operationguide
    {
        public int GUIDEID { get; set; }
        public int AFFAIRID { get; set; }
        public int GUIDEORDER { get; set; }
        public string GUIDEPATH { get; set; }
        public string GUIDEDESCRIBE { get; set; }
    
        public virtual affairs affairs { get; set; }
    }
}
