using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {
        private readonly string name;
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public DescriptionAttribute(string name_)
        {
            name = name_;
        }

    }
}
