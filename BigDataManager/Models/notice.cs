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
    
    public partial class notice
    {
        public notice()
        {
            this.noticeattachment = new HashSet<noticeattachment>();
        }
    
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIBE { get; set; }
        public Nullable<int> TOWNCODE { get; set; }
        public Nullable<int> CITYID { get; set; }
        public Nullable<int> AREAID { get; set; }
        public Nullable<int> NOTICELV { get; set; }
        public Nullable<int> ISTOP { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<System.DateTime> STARTTIME { get; set; }
        public Nullable<System.DateTime> ENDTIME { get; set; }
        public Nullable<int> CREATEUSER { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual dic_counties dic_counties { get; set; }
        public virtual dic_town dic_town { get; set; }
        public virtual dic_userlevel dic_userlevel { get; set; }
        public virtual sy_user sy_user { get; set; }
        public virtual ICollection<noticeattachment> noticeattachment { get; set; }
    }
}
