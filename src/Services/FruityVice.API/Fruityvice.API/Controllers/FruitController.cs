using AutoMapper;
using Fruityvice.Application.Dto;
using Fruityvice.Application.Persistence;
using Fruityvice.Domain.Enitites;
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

    [HttpPost]
    [ProducesResponseType(typeof(FruitDto), 200)]
    public async Task<IActionResult> AddFruit([FromBody] BasicFruit basicFruit)
    {
        var fruit = mapper.Map<Fruit>(basicFruit);
        var nutri = await nutritionRepository.AddAsync(fruit.Nutrition);
        fruit.NutritionId = nutri.Id;
        var result = await fruitRepository.AddAsync(fruit);
        return Ok(mapper.Map<FruitDto>(result));
    }
}
