using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDomain.Entities
{
    public class AnswerEntity : ModifiableEntity
    {
        /// <summary>
        /// 作答人Id
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// 选择项
        /// </summary>
        public byte Selections { get; set; }
        /// <summary>
        /// 简述
        /// </summary>
        public string Brief { get; set; }

        public virtual UserEntity User{get;set;}
    }
}
