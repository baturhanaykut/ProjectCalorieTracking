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
    public partial class frmFoodAdd : Form
    {
        CalorieTrackingContext context;
        public frmUserProfile _userForm;
        public User _user;
        public Meal _meal;
        public List<Food> _foods;
      
        decimal _mealCalories;
        decimal _totalCalories;

        public frmFoodAdd(User userProfile)
        {
            InitializeComponent();
            _user = userProfile;
        }

        private void FoodAddForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            _userForm = new frmUserProfile(_user);
            _userForm._userProfile = _user;

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
            frmAddMeal adfrm = new frmAddMeal(_user);
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

            _meal = new Meal();
            
            if (cmbChooseYourMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öğün Seçiniz");
            }
            else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Breakfast && _foods != null)
            {
                _meal.MealName = MealType.Breakfast;
                FoodAdd();
            }
            else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Lunch && _foods != null)
            {
                _meal.MealName = MealType.Lunch;
                FoodAdd();
            }
            else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Dinner && _foods != null)
            {
                _meal.MealName = MealType.Dinner;
                FoodAdd();
            }
            else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Snack && _foods != null)
            {
                _meal.MealName = MealType.Snack;
                FoodAdd();
            }


        }
        private void FoodAdd()
        {
            _meal.MealDate = mntcldrCalender.SelectionStart.Date;
            _meal.TotalMealCalories = Convert.ToDecimal(lblCaloriGoster.Text);
            _meal.Foods = _foods;
            _meal.UserId = _userForm._userProfile.UserID;
            context.Meals.Add(_meal);


            //_users = new List<User>();
            //_users.Add(_user);

            context.SaveChanges();
            MessageBox.Show("Yemeğiniz başarı ile eklendi");

            _mealCalories = 0;
            ListBoxComboBoxTemizle();
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
                _foods = new List<Food>();
                _foods.Add(food);

            }

        }

        private void ListBoxComboBoxTemizle()
        {
            foreach (Control item in grpFoodAdd.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
            lstbFoodName.Items.Clear();
            lblCaloriGoster.Text = " ";
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
