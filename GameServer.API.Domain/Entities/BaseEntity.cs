using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        private DateTime? _createdAt;
        private DateTime? _updatedAt;

        public DateTime? CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = DateTime.UtcNow; }
        }
    }
}
