using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public bool CanHeal { get; set; }
        public bool CanArrest { get; set; }
        public bool CanDoMarriage { get; set; }
        public bool IsDefault { get; set; }
        public int RequirementXp { get; set; }
        public bool PublicJob { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }
    }
}
