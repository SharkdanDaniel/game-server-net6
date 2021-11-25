using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Dtos.Server
{
    public class ServerDto
    {
        public string Name { get; set; }
        public bool Shared { get; set; }
        public bool HasDisease { get; set; }
        public int InitialMoney { get; set; }
        public int InitialStatsPoints { get; set; }
        //public List<object> ExpTable { get; set; }
        //public List<object> AvailableItems { get; set; }
        //public List<object> AvailableDisease { get; set; }
        //public List<object> Parcels { get; set; }
    }
}
