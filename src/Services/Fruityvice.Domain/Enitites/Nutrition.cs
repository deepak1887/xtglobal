using Fruityvice.Domain.Common;

namespace Fruityvice.Domain.Enitites;
public class Nutrition: EntityBase
{
    public double Carbohydrates { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }
    public double Calories { get; set; }
    public double Sugar { get; set; }
}
