using GameServer.API.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserPermission Permission { get; set; }
        public Server? Server { get; set; }
        public Guid? ServerId { get; set; }

    }
}
