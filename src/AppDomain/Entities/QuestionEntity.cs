using Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDomain.Entities
{
    public class QuestionEntity:DeletableEntity
    {
        public Guid Guid { get; set; }
        /// <summary>
        /// 题干
        /// </summary>
        public string Stem { get; set; }
        public QuestionType QuestionType { get; set; }
        public string Options { get; set; }
        public int AnswerId{ get; set; }
        public virtual AnswerEntity Answer { get; set; }
    }
}
