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
    
    public partial class businessinfo
    {
        public int CURRAFFAIRID { get; set; }
        public Nullable<int> P_DOC_TYPE { get; set; }
        public string IDNUMBER { get; set; }
        public string P_NAME { get; set; }
        public Nullable<int> P_SEX { get; set; }
        public Nullable<System.DateTime> P_BIRTHDAY { get; set; }
        public string PHONE { get; set; }
        public string MOBLEPHONE { get; set; }
        public string RESIDENCEADDRESS { get; set; }
        public string LIVEADDRESS { get; set; }
        public Nullable<int> VALID { get; set; }
        public string RESERVED1 { get; set; }
        public string RESERVED2 { get; set; }
        public string RESERVED3 { get; set; }
        public string RESERVED4 { get; set; }
        public string RESERVED5 { get; set; }
    
        public virtual affairinfo affairinfo { get; set; }
    }
}