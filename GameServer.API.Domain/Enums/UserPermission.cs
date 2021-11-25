using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Enums
{
    public enum UserPermission
    {
        Standard = 0,
        Administrator = 1,
        GlobalAdministrator = 2,
    }
}
