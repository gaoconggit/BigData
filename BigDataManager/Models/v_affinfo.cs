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
    
    public partial class v_affinfo
    {
        public int CURR_AFFAIRID { get; set; }
        public int AFFAIRID { get; set; }
        public int OPERATORID { get; set; }
        public string CURR_AFFAIRCODE { get; set; }
        public int FLOWID { get; set; }
        public int FLOWRESULT { get; set; }
        public int NEXTFLOW { get; set; }
        public int NEXTPERSON { get; set; }
        public System.DateTime TRANSTIME { get; set; }
        public System.DateTime LASTTRANSTIME { get; set; }
        public int TRANSTYPE { get; set; }
        public int STATEOFAFFAIRS { get; set; }
        public string QUEUE_NUM { get; set; }
        public string AFFAIRCODE { get; set; }
        public string AFFAIRNAME { get; set; }
        public string AF_ABBREVIATION { get; set; }
        public Nullable<int> AF_TYPE { get; set; }
        public int AF_LEVEL { get; set; }
        public int AF_DEPARTMENT { get; set; }
        public float TIMELIMIT { get; set; }
        public int AF_PARENT { get; set; }
        public Nullable<int> USERID { get; set; }
        public string USERNAME { get; set; }
        public string REALNAME { get; set; }
        public string USERPWD { get; set; }
        public Nullable<int> SEX { get; set; }
        public Nullable<System.DateTime> BIRTHDAY { get; set; }
        public string IDCARD { get; set; }
        public string CARDNUMBER { get; set; }
        public Nullable<int> ULEVEL { get; set; }
        public Nullable<int> UROLE { get; set; }
        public Nullable<int> COUNTIES { get; set; }
        public Nullable<int> TOWNS { get; set; }
        public Nullable<int> BUSINESS { get; set; }
        public Nullable<System.DateTime> LASTLOGINTIME { get; set; }
        public Nullable<int> VALID { get; set; }
        public string FINGERCODE { get; set; }
    }
}
