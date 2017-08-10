using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDomain.Entities
{
    public class AddressEntity:DeletableEntity
    {
        public int ParentId { get; set; }
        public string Name { get; set; }

    }
}
