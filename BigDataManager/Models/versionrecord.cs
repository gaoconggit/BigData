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
    
    public partial class versionrecord
    {
        public int ID { get; set; }
        public Nullable<int> SERVICEWINDOWID { get; set; }
        public Nullable<int> CLIENTVERSIONID { get; set; }
        public Nullable<int> CONFIGVALUEGROUPID { get; set; }
        public string NEEDCONFIGKEYS { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<System.DateTime> RECORDTIME { get; set; }
    }
}