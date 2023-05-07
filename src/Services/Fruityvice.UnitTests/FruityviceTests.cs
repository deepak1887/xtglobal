using AutoMapper;
using FluentAssertions;
using Fruityvice.API.Controllers;
using Fruityvice.Application.Dto;
using Fruityvice.Application.Persistence;
using Fruityvice.Domain.Enitites;
using Fruityvice.UnitTests.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Fruityvice.UnitTests;

public class FruityviceTests
{
    private readonly Mock<IFruitRepository> mokeFruitRepo;
    private readonly Mock<INutritionRepository> mokeNutritionRepo;
    private readonly Mock<IMapper> mokeMapper;

    public FruityviceTests()
    {
        mokeFruitRepo = new Mock<IFruitRepository>();
        mokeNutritionRepo = new Mock<INutritionRepository>();
        mokeMapper = new Mock<IMapper>();
    }

    [Fact]
    public async void GetAllAsync_ShouldReturn200Status()
    {
        var fruitController = new FruitController(mokeFruitRepo.Object, mokeNutritionRepo.Object
            , mokeMapper.Object);
        var result = (OkObjectResult)await fruitController.GetAll();
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async void PostFruit_ShouldSave_AtleastOne()
    {
        var fruitController = new FruitController(mokeFruitRepo.Object, mokeNutritionRepo.Object
            , mokeMapper.Object);
        var newFruit = FruitsMockData.NewFruit();
        var result = (OkObjectResult)await fruitController.AddFruit(newFruit);
        result.StatusCode.Should().Be(200);
        mokeFruitRepo.Verify(_ => _.AddAsync(mokeMapper.Object.Map<Fruit>(newFruit)), Times.Exactly(1));
    }
}