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
    
    public partial class v_userexam
    {
        public Nullable<decimal> Score { get; set; }
        public long Total { get; set; }
        public Nullable<decimal> RIGHTTotal { get; set; }
        public Nullable<decimal> ERRORTotal { get; set; }
        public int ExamID { get; set; }
        public Nullable<int> ea_paper { get; set; }
        public Nullable<int> ea_user { get; set; }
        public string ea_user_name { get; set; }
        public Nullable<System.DateTime> start_titme { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public string pa_title { get; set; }
    }
}
