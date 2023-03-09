using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
    public async Task<IActionResult> Create([FromBody] SeniorityDto seniorityDto)
    {
        if (seniorityDto == null)
            return BadRequest();

        await _service.CreateAsync(seniorityDto);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetSeniorityAsync();

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SeniorityDto seniorityDto)
    {
        if (seniorityDto == null)
            return BadRequest();

        await _service.UpdateAsync(seniorityDto);

        return Ok(seniorityDto);
    }


    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        return NoContent();
    }
}
