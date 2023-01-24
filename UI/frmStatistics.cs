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
            if (cmbChooseCategory.SelectedIndex == 0)
            {
                MealsEatenByCategory();
                MostEatenMeal();
            }
            else if (cmbChooseCategory.SelectedIndex == 1)
            {
                MealsEatenByCategory();
                MostEatenMeal();

            }
            else if (cmbChooseCategory.SelectedIndex == 2)
            {
                MealsEatenByCategory();
                MostEatenMeal();
            }
            else if (cmbChooseCategory.SelectedIndex == 3)
            {
                MealsEatenByCategory();
                MostEatenMeal();
            }

        }

        //private void rbtnBreakfast_CheckedChanged(object sender, EventArgs e)
        //{
        //    MostEatenMeal();
        //}
        private void rbtnBreakfast_Click(object sender, EventArgs e)
        {
            MostEatenMeal();
        }

        private void MostEatenMeal()
        {
            if (rbtnBreakfast.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Breakfast)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName, a.Category.CategoryID })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).OrderBy(x => x.Count).ToList();

                
                dgvMealReport.DataSource = listGroupBy;

            //    dgvMealReport.Columns[0].DataPropertyName = "Key";
            //    dgvMealReport.Columns[0].HeaderText = "Food Name";
            //    dgvMealReport.Columns[1].DataPropertyName = "Sum";
            //    dgvMealReport.Columns[1].HeaderText = "Total Calorie";
            //    dgvMealReport.Columns[2].DataPropertyName = "Count";
            //    dgvMealReport.Columns[2].HeaderText = "Total Porsion";
            }
            else if (rbtnDinner.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Dinner)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).FirstOrDefault();

                dgvMealReport.DataSource = listGroupBy;


            }

            else if (rbtnSnack.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Snack)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).FirstOrDefault();

                dgvMealReport.DataSource = listGroupBy;


            }
            else if (rbtnLunch.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Lunch)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).FirstOrDefault();

                dgvMealReport.DataSource = listGroupBy;

            }
        }


        private void MealsEatenByCategory()
        {
            if (rbtnBreakfast.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Breakfast)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName, a.Category.CategoryID })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).OrderBy(x=>x.Count) .ToList();

                dgvChooseFood.DataSource = listGroupBy;

                dgvChooseFood.Columns[0].DataPropertyName = "Key";
                dgvChooseFood.Columns[0].HeaderText = "Food Name";
                dgvChooseFood.Columns[1].DataPropertyName = "Sum";
                dgvChooseFood.Columns[1].HeaderText = "Total Calorie";
                dgvChooseFood.Columns[2].DataPropertyName = "Count";
                dgvChooseFood.Columns[2].HeaderText = "Total Porsion";
            }
            else if (rbtnDinner.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Dinner)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvChooseFood.DataSource = listGroupBy;

                
            }

            else if (rbtnSnack.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Snack)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvChooseFood.DataSource = listGroupBy;

                
            }
            else if (rbtnLunch.Checked == true)
            {
                var list = context.Meals
                    .Where(m => m.MealName == MealType.Lunch)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .Where(b => b.CategoryName == cmbChooseCategory.Text)
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName)
                    .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvChooseFood.DataSource = listGroupBy;

            }
        }

    }

   

    
}
