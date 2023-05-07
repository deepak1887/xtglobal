using Fruityvice.Application.Dto;

namespace Fruityvice.UnitTests.MockData;
public class FruitsMockData
{
    public static List<FruitDto> GetFruits()
    {
        return new List<FruitDto>()
        {
            new FruitDto()
            {
                Id = 1,
                Name = "Strawberry",
                Family = "Rosaceae",
                Order = "Rosales",
                Genus = "Fragaria",
                Nutrition = new NutritionDto()
                {
                    Carbohydrates = 5.5f,
                    Protein = 0,
                    Fat = 0.4f,
                    Calories = 29,
                    Sugar= 5.4f
                }
            }
        };
    }

    public static BasicFruit NewFruit()
    {
        return new BasicFruit()
        {
            Name = "StrawberryW",
            Family = "Rosaceae",
            Genus = "Rosales",
            Order = "Fragaria",
            Nutrition = new NutritionDto() { 
                Calories = 29,
                Carbohydrates  = 5,
                Protein = 0,
                Sugar = 0,
                Fat= 15,
            }

        };
    }
}
