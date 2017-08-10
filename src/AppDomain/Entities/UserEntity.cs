using Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDomain.Entities
{
    public class UserEntity:DeletableEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Sex Sex { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId{ get; set; }
        public RoleEntity Role { get; set; }
    }
}
