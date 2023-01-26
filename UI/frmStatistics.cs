using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
            
            cmbChooseCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            cmbChooseCategory.SelectedIndex = -1;
        }
        private void btnBackUserForm_Click(object sender, EventArgs e)
        {
            _frmUserProfile.Show();
            this.Close();
        }
        
        private void cmbChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealsEatenByCategory();
            MostEatenMeal();
            
        }
        
        private void MostEatenMeal()
        {
            if (rbtnBreakfast.Checked == true)
            {
                Methods.GetStatsForMostEatenMeal(cmbChooseCategory,dgvMealReport,MealType.Breakfast);
                //var list = context.Meals
                //    .Where(m => m.MealName == MealType.Breakfast)
                //    .SelectMany(f => f.Foods)
                //    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName, a.Category.CategoryID })
                //    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                //    .ToList();

                //var listGroupBy = list.GroupBy(x => x.FoodName)
                //    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).OrderByDescending(x => x.Count).ToList().FirstOrDefault();

                //var listMostEatenMeal = new List<object>();
                //listMostEatenMeal.Add(listGroupBy);
                //dgvMealReport.DataSource = listMostEatenMeal;

                //if (listMostEatenMeal.Count > 1)
                //{
                //    Methods.EditDatagridviewColumnName(dgvMealReport);
                //}
            }
            else if (rbtnDinner.Checked == true)
            {
                Methods.GetStatsForMostEatenMeal(cmbChooseCategory, dgvMealReport, MealType.Dinner);
            }
            else if (rbtnSnack.Checked == true)
            {
                Methods.GetStatsForMostEatenMeal(cmbChooseCategory, dgvMealReport, MealType.Snack);
            }
            else if (rbtnLunch.Checked == true)
            {
                Methods.GetStatsForMostEatenMeal(cmbChooseCategory, dgvMealReport, MealType.Lunch);
            }  
        }
        private void MealsEatenByCategory()
        {
            if (rbtnBreakfast.Checked == true)
            {
                Methods.GetStatsForMealsEatenByCategory(cmbChooseCategory,dgvChooseFood,MealType.Breakfast);

                //var list = context.Meals
                //    .Where(m => m.MealName == MealType.Breakfast)
                //    .SelectMany(f => f.Foods)
                //    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                //    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                //    .ToList();

                //var listGroupBy = list.GroupBy(x => x.FoodName)
                //    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                //dgvChooseFood.DataSource = listGroupBy;

                //if (listGroupBy.Count > 1)
                //{
                //    Methods.EditDatagridviewColumnName(dgvChooseFood);
                //}
            }
            else if (rbtnDinner.Checked == true)
            {
                Methods.GetStatsForMealsEatenByCategory(cmbChooseCategory, dgvChooseFood, MealType.Dinner);
            }
            else if (rbtnSnack.Checked == true)
            {
                Methods.GetStatsForMealsEatenByCategory(cmbChooseCategory, dgvChooseFood, MealType.Snack);
            }
            else if (rbtnLunch.Checked == true)
            {
                Methods.GetStatsForMealsEatenByCategory(cmbChooseCategory, dgvChooseFood, MealType.Lunch);
            }
        }
    }
}
