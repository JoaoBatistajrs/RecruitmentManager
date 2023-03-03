using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeniorityController : ControllerBase
{
    public readonly ISeniorityService _service;

    public SeniorityController(ISeniorityService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create(SeniorityDto seniorityDto)
    {
        _service.CreateAsync(seniorityDto);

        return Ok();
    }
}
