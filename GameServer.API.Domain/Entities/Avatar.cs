using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class Avatar : BaseEntity
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Hungry { get; set; }
        public string Title { get; set; }
        public bool Leader { get; set; }
        public int Experience { get; set; }
        public int Money { get; set; }
        public int StatusPoint { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Accuracy { get; set; }
        public DateTime LastPing { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBanned { get; set; }
        public string BannedReason { get; set; }
        public bool IsDead { get; set; }
        public int MaxHealth { get; set; }
        public string ExpLabel { get; set; }
        public int ExpRemaining { get; set; }
        public bool Online { get; set; }
        public DateTime JoinedJobDate { get; set; }
        public Guid JobId { get; set; }
        public Server Server { get; set; }
        public Guid ServerId { get; set; }      
    }
}
