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
    
    public partial class auditrecords
    {
        public int ID { get; set; }
        public string CURRAFFAIRCODE { get; set; }
        public int CURRAFFAIRID { get; set; }
        public int AFFAIRFLOWID { get; set; }
        public string AFFAIRFLOWNAME { get; set; }
        public int OPERATORID { get; set; }
        public int FLOWRESULT { get; set; }
        public string FLOWERRESULTNAME { get; set; }
        public System.DateTime UPTODATE { get; set; }
        public int RECORDTYPE { get; set; }
        public int VALIDITYTORESULT { get; set; }
        public System.DateTime STARTTIME { get; set; }
        public System.DateTime OPERATORTIME { get; set; }
        public string REMARK { get; set; }
        public int VAILD { get; set; }
        public string RESERVED1 { get; set; }
        public string RESERVED2 { get; set; }
        public string RESERVED3 { get; set; }
        public string RESERVED4 { get; set; }
        public string RESERVED5 { get; set; }
    
        public virtual affairinfo affairinfo { get; set; }
    }
}