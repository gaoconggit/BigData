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
    
    public partial class bg_questions
    {
        public bg_questions()
        {
            this.bg_answers = new HashSet<bg_answers>();
        }
    
        public int QUESTIONID { get; set; }
        public string QUESTIONTEXT { get; set; }
        public int AFFAIRID { get; set; }
        public bool ISBEGIN { get; set; }
        public string DESCRIBE { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual affairs affairs { get; set; }
        public virtual ICollection<bg_answers> bg_answers { get; set; }
    }
}
