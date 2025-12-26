using Microsoft.AspNetCore.Mvc;
using SmartRequestSystem.Application.DTOs;
using SmartRequestSystem.Application.Interfaces;

namespace SmartRequestSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestService _requestService;

        public RequestsController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        /// <summary>
        /// Create a new request
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRequestDto dto)
        {
            var requestId = await _requestService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), new { id = requestId }, requestId);
        }

        /// <summary>
        /// Get all requests
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var requests = await _requestService.GetAllAsync();
            return Ok(requests);
        }
    }
}
