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
    
    public partial class affair_role_channel_value
    {
        public int ID { get; set; }
        public string ChannelId { get; set; }
        public int RoleId { get; set; }
        public string Action { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string ChannelName { get; set; }
        public int ChannelType { get; set; }
    
        public virtual affair_role affair_role { get; set; }
    }
}