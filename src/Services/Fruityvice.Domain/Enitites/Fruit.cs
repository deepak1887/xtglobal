using Fruityvice.Domain.Common;

namespace Fruityvice.Domain.Enitites;
public class Fruit : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Family { get; set; } = string.Empty;
    public string Genus { get; set; } = string.Empty;
    public string Order { get; set; } = string.Empty;
    public int NutritionId { get; set; }
    public virtual Nutrition? Nutrition { get; set; }
}
