using System.Security.AccessControl;

namespace Entities.Entity;

public class MealsAndFoods
{
    public int FoodID { get; set; }

    public int MealID { get; set; }

    public Food Food { get; set; }
    public Meal Meal { get; set; }
}