namespace Fruityvice.Application.Dto;
public class FruitDto: BasicFruit
{
    public int Id { get; set; }
}

public class BasicFruit
{
    public string Name { get; set; }
    public string Family { get; set; }
    public string Genus { get; set; }
    public string Order { get; set; }
    public NutritionDto Nutrition { get; set; }
}
