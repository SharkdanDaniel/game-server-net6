using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Server : BaseEntity
    {
        public string Name { get; set; }
        public bool Shared { get; set; }
        public bool HasDisease { get; set; }
        public int InitialMoney { get; set; }
        public int InitialStatsPoints { get; set; }
        public List<ExpTable> ExpTable { get; set; }
        public List<Item> AvailableItems { get; set; }
        public List<Disease> AvailableDisease { get; set; }
        public List<Parcel> Parcels { get; set; }
    }
}
