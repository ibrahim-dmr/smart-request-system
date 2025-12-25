using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRequestSystem.Domain.Domain.Enums
{
    public enum RequestStatus
    {
        open = 1,
        Inprogress = 2,
        Completed = 3,
        Cancelled = 4
    }
}
