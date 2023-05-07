using AutoMapper;
using Fruityvice.Application.Dto;
using Fruityvice.Domain.Enitites;

namespace Fruityvice.Application.Mapping;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Nutrition, NutritionDto>().ReverseMap();
        CreateMap<Fruit, FruitDto>().ReverseMap();
        CreateMap<BasicFruit, FruitDto>().ReverseMap();
        CreateMap<BasicFruit, Fruit>().ReverseMap();
    }
}
