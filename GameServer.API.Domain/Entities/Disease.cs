using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Disease : BaseEntity
    {
        public string Name { get; set; }
        public int DamageEachTenMinutes { get; set; }
        public int DurationInMinutes { get; set; }
        public bool Contagious { get; set; }
        public bool HasVacine { get; set; }
        public int VacinePrice { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }

    }
}
