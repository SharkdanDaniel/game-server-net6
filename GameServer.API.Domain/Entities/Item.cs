using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public Guid ImageId { get; set; }
        public int Health { get; set; }
        public int Vest { get; set; }
        public int Experience { get; set; }
        public int Hungry { get; set; }
        public int Money { get; set; }
        public int StatusPoint { get; set; }
        public bool IsInitial { get; set; }
        public int QuantityInitial { get; set; }
        public bool IsVirtual { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }
    }
}
