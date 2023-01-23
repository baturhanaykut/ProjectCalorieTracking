using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;
using Entities.Enums;

namespace UI
{
    public partial class frmStatistics : Form
    {
        CalorieTrackingContext context;
        frmUserProfile _frmUserProfile;
        User _user;
        public frmStatistics(User user, frmUserProfile frmUserProfile)
        {
            InitializeComponent();
            _user = user;
            _frmUserProfile = frmUserProfile;
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();

            cmbChooseMeal.Items.Clear();
            cmbChooseMeal.DataSource = Enum.GetNames(typeof(MealType)).ToArray();

            var result = (from m in context.Meals
                join f in context.Foods on m.MealID equals f.FoodID
                //join u in context.Users on m.UserId equals u.UserID
                where m.MealName == MealType.Breakfast
                select
                      new
                      {
                          MealName = m.MealName,
                          TotalMealCalories = m.TotalMealCalories,
                      }).ToList();

            dgvChooseFood.DataSource = result;

            //cmbChooseMeal.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            //cmbChooseMeal.SelectedIndex = -1;
        }
        private void btnBackUserForm_Click(object sender, EventArgs e)
        {
            _frmUserProfile.Show();
            this.Close();
        }
        private void cmbChooseMeal_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    List<Meal> meals = new List<Meal>();
            //    List<Food> foods = new List<Food>();

            //    //if (cmbChooseMeal.SelectedIndex == 0)
            //    //{
            //    //    var result = (from m in context.Meals
            //    //                  join f in context.Foods on m.MealID equals f.FoodID
            //    //                  join u in context.Users on m.UserId equals u.UserID
            //    //                  select new
            //    //                  {
            //    //                      MealID = m.MealID,
            //    //                      FoodName = f.FoodName,
            //    //                      FoodCalorie = f.Calorie,
            //    //                      UserName = u.UserName,
            //    //                  }).ToList();

            //    //    dgvChooseFood.DataSource = result;


            //    //}
            //    //else if (cmbChooseMeal.SelectedIndex == 1)
            //    //{
            //    //    meals = context.Meals
            //    //        .Where(x => x.MealName == MealType.Lunch)
            //    //        .ToList();
            //    //    dgvChooseFood.DataSource = meals;
            //    //}
            //    //else if (cmbChooseMeal.SelectedIndex == 2)
            //    //{
            //    //    meals = context.Meals
            //    //        .Where(x => x.MealName == MealType.Snack)
            //    //        .ToList();
            //    //    dgvChooseFood.DataSource = meals;
            //    //}
            //    //else if (cmbChooseMeal.SelectedIndex == 3)
            //    //{
            //    //    meals = context.Meals
            //    //        .Where(x => x.MealName == MealType.Dinner)
            //    //        .ToList();
            //    //    dgvChooseFood.DataSource = meals;
            //    //}
            //    ////foreach (var meal in meals)
            //    ////{
            //    ////    foreach (var food in meals)
            //    ////    {
            //    ////        foods.Add(food);
            //    ////    }
            //    ////}

            //var dataList = foods
            //    .GroupBy(x=>x.FoodName).Select(z=> new
            //    {
            //        Name =z.Key,

            //    } ).ToList();
            //    //dgvChooseFood.DataSource = dataList;

        }


        //Hangi yemeklerin hangi öğünlerde ne kadar yendiğini gösteren bir rapor hazırlansın.
        //En çok yenen yemekler raporu çıksın.




    }
}
