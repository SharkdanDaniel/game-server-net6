using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Dtos.Server
{
    public class ServerDtoCreate
    {
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        public bool Shared { get; set; }

        [Required]
        public bool HasDisease { get; set; }

        [Required]
        [MaxLength(100)]
        public int InitialMoney { get; set; }

        [Required]
        [MaxLength(100)]
        public int InitialStatsPoints { get; set; }
    }
}
