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
    
    public partial class dic_standardreplayfile
    {
        public dic_standardreplayfile()
        {
            this.auditattachment = new HashSet<auditattachment>();
        }
    
        public int ID { get; set; }
        public Nullable<int> AffairID { get; set; }
        public string AcceptFileName { get; set; }
        public string FileNameDetails { get; set; }
        public Nullable<int> Valid { get; set; }
    
        public virtual affairs affairs { get; set; }
        public virtual ICollection<auditattachment> auditattachment { get; set; }
    }
}
