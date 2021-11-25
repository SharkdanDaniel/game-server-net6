using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class ExpMachine : BaseEntity
    {
        public string Description { get; set; }
        public int ExpEachMinute { get; set; }
        public bool AutomaticStart { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourEnds { get; set; }
        public bool Enable { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }
    }
}
