namespace Entities.Entity;

public class MealAndFood
{
    public int MealID  { get; set; }

    public int FoodId { get; set; }

    public List<Meal> Meals { get; set; }
}