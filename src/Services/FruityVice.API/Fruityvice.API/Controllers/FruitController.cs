using AutoMapper;
using Fruityvice.Application.Dto;
using Fruityvice.Application.Persistence;
using Microsoft.AspNetCore.Mvc;


namespace Fruityvice.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FruitController : ControllerBase
{
    private readonly IFruitRepository fruitRepository;
    private readonly INutritionRepository nutritionRepository;
    private readonly IMapper mapper;
    public FruitController(IFruitRepository fruitRepository, INutritionRepository nutritionRepository, IMapper mapper)
    {
        this.fruitRepository = fruitRepository;
        this.nutritionRepository = nutritionRepository;
        this.mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<FruitDto>), 200)]
    public async Task<IActionResult> GetAll()
    {
        var fruits = await fruitRepository.GetAllAsync();
        var result = mapper.Map<IEnumerable<FruitDto>>(fruits);
        return Ok(result);
    }
}
