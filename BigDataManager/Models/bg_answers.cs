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
    
    public partial class bg_answers
    {
        public int ANSWERID { get; set; }
        public int QUESTIONID { get; set; }
        public int AFFAIRID { get; set; }
        public string ANSWERTEXT { get; set; }
        public string DESCRIBE { get; set; }
        public Nullable<int> VALID { get; set; }
    
        public virtual affairs affairs { get; set; }
        public virtual bg_questions bg_questions { get; set; }
    }
}