//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigDataManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class materialtakeinfo
    {
        public int ID { get; set; }
        public int CURR_AFFAIRID { get; set; }
        public string MATERIALNAME { get; set; }
        public int COPIES { get; set; }
        public int MATERIALTYPE { get; set; }
        public string SAVEPATH { get; set; }
        public Nullable<int> TOWNCODE { get; set; }
        public string REMARK { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual affairinfo affairinfo { get; set; }
        public virtual dic_town dic_town { get; set; }
    }
}
