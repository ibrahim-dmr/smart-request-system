using SmartRequestSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRequestSystem.Application.Interfaces
{
    public interface IRequestService
    {
        Task<Guid> CreateAsync(CreateRequestDto dto);
        Task<List<RequestDto>> GetAllAsync();
    }
}
