
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Meal
    {
        

        public int MealID { get; set; }
        public MealType MealName { get; set; }
        public DateTime MealDate { get; set; }
        public decimal TotalMealCalories { get; set; }
        public List<User> Users { get; set; }
        public List<Food> Foods { get; set; }
        //public List<MealsAndUsers> Users { get; set; }
        //public List<MealsAndFoods> Foods { get; set; }
    }
}
