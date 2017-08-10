using Framework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.Enum
{
    public enum QuestionType {
        [Description("单选题")]
        SingleOption,
        [Description("多选题")]
        MultiOption,
        [Description("简答")]
        Breaf,
    }
    public enum Sex
    {
        [Description("未知")]
        Unkown,
        [Description("女")]
        Female,
        [Description("男")]
        Male,
    }

}
