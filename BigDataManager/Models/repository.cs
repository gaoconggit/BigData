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
    
    public partial class repository
    {
        public repository()
        {
            this.repositoryanswers = new HashSet<repositoryanswers>();
        }
    
        public int ID { get; set; }
        public string QuestionTitle { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public string Tags { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual ICollection<repositoryanswers> repositoryanswers { get; set; }
    }
}