namespace Entities.Entity;

public class MealsAndUsers
{
    public int UserID { get; set; }
    public int MealID { get; set; }

    public User User { get; set; }

    public Meal Meal { get; set; }

}