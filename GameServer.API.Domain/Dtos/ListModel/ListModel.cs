using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Dtos.ListModel
{
    public class ListModel<T>
    {
        public IEnumerable<T> items { get; set; }
        public int total { get; set; }
    }
}
