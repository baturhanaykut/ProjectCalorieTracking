using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    public partial class FoodAddForm : Form
    {
        UserProfileForm _userForm;
        CalorieTrackingContext context;
        Meal meal;
        decimal _mealCalories;
        decimal _totalCalories;
        List<MealsAndFoods> _foods;

        public FoodAddForm()
        {
            InitializeComponent();
        }

        private void FoodAddForm_Load(object sender, EventArgs e)
        {
            _userForm = new UserProfileForm();
            context = new CalorieTrackingContext();

            ComboBoxDoldur();

        }

        private void ComboBoxDoldur()
        {
            cmbChooseYourMeals.DataSource = Enum.GetNames(typeof(MealType)).ToList();
            cmbChooseYourMeals.SelectedIndex = -1;
            cmbFoodCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            cmbFoodCategory.SelectedIndex = -1;
        }

        private void btnAddYourOwnFood_Click(object sender, EventArgs e)
        {
            AddMealForm adfrm = new AddMealForm();
            adfrm.Show();
            this.Close();
        }

        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbAllFoodName.DataSource = context.Foods
                .Where(c => c.CategoryId == context.Categories
                    .FirstOrDefault(y => y.CategoryName == cmbFoodCategory.Text).CategoryID).ToList();

            lstbAllFoodName.DisplayMember = "FoodName";
            lstbAllFoodName.ValueMember = "Calorie";


        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            meal = new Meal();

            //meal.Foods =

            if (cmbChooseYourMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öğün Seçiniz");
            }
            else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Breakfast && _foods != null)
            {
                meal.MealDate = mntcldrCalender.SelectionStart.Date;
                meal.TotalMealCalories =Convert.ToDecimal(lblCaloriGoster.Text);
                meal.Foods =_foods;




            }

        }

        private void btnBacktoUserForm_Click(object sender, EventArgs e)
        {

            this.Close();
            _userForm.Show();
        }

        private void btnLsitBoxEkle_Click(object sender, EventArgs e)
        {

            if (lstbAllFoodName.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir yemek ekleyeniz");
            }
            else
            {
                lstbFoodName.Items.Add(lstbAllFoodName.SelectedItem);
                lstbFoodName.DisplayMember = "FoodName";
                lstbFoodName.ValueMember = "Calorie";

                //lblCaloriGoster +=Food.
                //add calories to label
                Food food = (Food)lstbAllFoodName.SelectedItem;
                _mealCalories += food.Calorie;
                lblCaloriGoster.Text = _mealCalories.ToString();

                //add foods to list
                _foods = new List<MealsAndFoods>();
                _foods.Add(food);
            }

        }

        private void btnListBoxSil_Click(object sender, EventArgs e)
        {
            Food food = (Food)lstbFoodName.SelectedItem;

            if (lstbFoodName.SelectedItem != null)
            {
                lstbFoodName.Items.Remove(lstbFoodName.SelectedItem);
                //remove food from list
                _foods.Remove(food);

                if (food != null)
                {
                    _mealCalories -= food.Calorie;
                    lblCaloriGoster.Text = _mealCalories.ToString();
                }
                else
                {
                    _mealCalories -= 0;
                    lblCaloriGoster.Text = "0";
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir besin seçiniz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }
    }
}
