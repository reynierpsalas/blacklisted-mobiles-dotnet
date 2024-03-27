using AutoMapper;
using BlacklistedMobiles.API.Models.Domain;
using BlacklistedMobiles.API.Models.DTO;
using BlacklistedMobiles.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlacklistedMobiles.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrademarksController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ITrademarkRepository _repository;

    public TrademarksController(ITrademarkRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var entities = await _repository
            .GetAllAsync();

        return Ok(_mapper.Map<List<TrademarkDto>>(entities));
    }

    [HttpGet]
    [Route("{name}")]
    public async Task<IActionResult> GetByName([FromRoute] string name)
    {
        var entity = await _repository
            .GetByNameAsync(name);

        if (entity == null) return NotFound();

        return Ok(_mapper.Map<TrademarkDto>(entity));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddTrademarkRequestDto requestDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        
        var entity = await _repository
            .CreateAsync(_mapper.Map<Trademark>(requestDto));

        return CreatedAtAction(nameof(GetByName), new { name = entity.Name }, _mapper.Map<TrademarkDto>(entity));

    }

    [HttpPut]
    [Route("{name}")]
    public async Task<IActionResult> Update([FromRoute] string name, [FromBody] UpdateTrademarkRequestDto requestDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        
        var entity = await _repository
            .UpdateAsync(name, _mapper.Map<Trademark>(requestDto));

        if (entity == null) return NotFound();

        return Ok(_mapper.Map<TrademarkDto>(entity));
    }

    [HttpDelete]
    [Route("{name}")]
    public async Task<IActionResult> Delete([FromRoute] string name)
    {
        var entity = await _repository
            .DeleteAsync(name);

        if (entity == null) return NotFound();

        return Ok(_mapper.Map<TrademarkDto>(entity));
    }
}