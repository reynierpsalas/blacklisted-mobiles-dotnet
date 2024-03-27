using AutoMapper;
using BlacklistedMobiles.API.Data;
using BlacklistedMobiles.API.Models.DTO;
using BlacklistedMobiles.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlacklistedMobiles.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MunicipalitiesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMunicipalityRepository _repository;

    public MunicipalitiesController(ApplicationDbContext dbContext, IMunicipalityRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var entities = await _repository
            .GetAllAsync();

        return Ok(_mapper.Map<List<MunicipalityDto>>(entities));
    }

    [HttpGet]
    [Route("{code}")]
    public async Task<IActionResult> GetByCode([FromRoute] string code)
    {
        var entity = await _repository
            .GetByCodeAsync(code);

        if (entity == null) return NotFound();

        return Ok(_mapper.Map<MunicipalityDto>(entity));
    }
}