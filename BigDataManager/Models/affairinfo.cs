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
    
    public partial class affairinfo
    {
        public int CURR_AFFAIRID { get; set; }
        public int AFFAIRID { get; set; }
        public int OPERATORID { get; set; }
        public string CURR_AFFAIRCODE { get; set; }
        public string CURR_SHORTCODE { get; set; }
        public int FLOWID { get; set; }
        public int FLOWRESULT { get; set; }
        public int NEXTFLOW { get; set; }
        public int NEXTPERSON { get; set; }
        public System.DateTime TRANSTIME { get; set; }
        public System.DateTime LASTTRANSTIME { get; set; }
        public int TRANSTYPE { get; set; }
        public int STATEOFAFFAIRS { get; set; }
        public string SATISFYDEGREE { get; set; }
        public Nullable<int> SATISFYResultID { get; set; }
        public string SATISFYDEGREES { get; set; }
        public Nullable<System.DateTime> SATISFYTime { get; set; }
        public string ServiceDuringTime { get; set; }
        public Nullable<int> AcceptUserID { get; set; }
        public string QUEUE_NUM { get; set; }
        public int VALID { get; set; }
        public Nullable<int> TOWNCODE { get; set; }
        public Nullable<int> COMMITTEE { get; set; }
        public Nullable<System.DateTime> QUEUEINGTIME { get; set; }
        public Nullable<System.DateTime> CALLTIME { get; set; }
        public string RESERVED1 { get; set; }
        public string RESERVED2 { get; set; }
        public string RESERVED3 { get; set; }
        public string RESERVED4 { get; set; }
        public string RESERVED5 { get; set; }
    
        public virtual businessinfo businessinfo { get; set; }
        public virtual dic_town dic_town { get; set; }
        public virtual dic_committee dic_committee { get; set; }
    }
}