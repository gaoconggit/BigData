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
    
    public partial class dic_servicestatus
    {
        public dic_servicestatus()
        {
            this.serviceversion = new HashSet<serviceversion>();
        }
    
        public int ID { get; set; }
        public string SERVICESTATUS { get; set; }
        public Nullable<bool> VALID { get; set; }
    
        public virtual ICollection<serviceversion> serviceversion { get; set; }
    }
}