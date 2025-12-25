using SmartRequestSystem.Domain.Domain.Common;
using SmartRequestSystem.Domain.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRequestSystem.Domain.Domain.Entities
{
    public class Request: BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public RequestStatus Status{ get; set; } = RequestStatus.open;

        public Guid UserId{ get; set; }
        public User User { get; set; } = null!;
    }
}
