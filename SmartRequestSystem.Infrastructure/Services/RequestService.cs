using SmartRequestSystem.Application.DTOs;
using SmartRequestSystem.Application.Interfaces;
using SmartRequestSystem.Domain.Domain.Entities;
using SmartRequestSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRequestSystem.Infrastructure.Services
{
    public class RequestService : IRequestService
    {
        private readonly AppDbContext _context;

        public RequestService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateAsync(CreateRequestDto dto)
        {
            var request = new Request
            {
                Title = dto.Title,
                Description = dto.Description,
                UserId = dto.UserId
            };

            _context.Requests.Add(request);
            await _context.SaveChangesAsync();

            return request.Id;
        }

        public async Task<List<RequestDto>> GetAllAsync()
        {
            return await _context.Requests
                .Select(r => new RequestDto
                {
                    Id = r.Id,
                    Title = r.Title,
                    Description = r.Description,
                    Status = r.Status,
                    CreatedAt = r.CreatedAt
                })
                .ToListAsync();
        }
    }
}
