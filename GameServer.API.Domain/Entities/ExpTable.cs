using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class ExpTable : BaseEntity
    {
        public int Level { get; set; }
        public int Exp { get; set; }
        public string Title { get; set; }

    }
}
