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
using Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    public partial class FoodAddForm : Form
    {
        UserProfileForm _userForm;
        public FoodAddForm()
        {
            InitializeComponent();
        }

        private CalorieTrackingContext context;
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
            lstbFoodName.DataSource = context.Foods
                .Where(c => c.CategoryId == context.Categories
                    .FirstOrDefault(y => y.CategoryName == cmbFoodCategory.Text).CategoryID).Select(x => x.FoodName)
                .ToList();
        }

        private void btnBacktoUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
            _userForm.Show();
        }
    }
}
