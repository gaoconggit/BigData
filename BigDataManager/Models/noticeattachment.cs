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
    
    public partial class noticeattachment
    {
        public int ID { get; set; }
        public Nullable<int> NOTICEID { get; set; }
        public string ATTNAME { get; set; }
        public string DESCRIBE { get; set; }
        public string ATTPATH { get; set; }
        public string FILEREALNAME { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual notice notice { get; set; }
    }
}
