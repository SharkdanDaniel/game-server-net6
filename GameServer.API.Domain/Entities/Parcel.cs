using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Parcel : BaseEntity
    {
        public string ParcelName { get; set; }
        public string ParcelDescription { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }
    }
}
