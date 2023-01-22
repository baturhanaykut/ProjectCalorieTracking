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

namespace UI
{
    public partial class frmFoodUpdate : Form
    {
        User _user;
        frmFoodAdd _frmFoodAdd;
        CalorieTrackingContext context;
        List<Food> _foods;

        public frmFoodUpdate(User user, frmFoodAdd frmFoodAdd)
        {
            InitializeComponent();
            _user = user;
            _frmFoodAdd = frmFoodAdd;
            _foods = new List<Food>();
        }

        private void frmFoodUpdate_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();

            var ChoeseTime =
                context.Meals.Where(m => m.UserId == _user.UserID && m.MealDate == dtpFoodUpdate.Value.Date).Select(u => new { u.MealID, u.MealName, u.TotalMealCalories }).ToList();
            dgvFoodUpdate.DataSource = ChoeseTime;

            ComboBoxFill();
        }


        private void dtpFoodUpdate_ValueChanged(object sender, EventArgs e)
        {
            var ChoeseTime =
                context.Meals.Where(m => m.UserId == _user.UserID && m.MealDate == dtpFoodUpdate.Value.Date).Select(u => new { u.MealID, u.MealName, u.TotalMealCalories }).ToList();
            dgvFoodUpdate.DataSource = ChoeseTime;
        }

        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbFoodList.DataSource = context.Foods
                .Where(c => c.CategoryId == context.Categories
                    .FirstOrDefault(y => y.CategoryName == cmbFoodCategory.Text).CategoryID).ToList();

            lstbFoodList.DisplayMember = "FoodName";
            lstbFoodList.ValueMember = "Calorie";

        }

        private void ComboBoxFill()
        {
            cmbFoodCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            cmbFoodCategory.SelectedIndex = -1;
        }

        private void dgvFoodUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lstbEatsFood.Items.Clear();

            int mealID = Convert.ToInt32(dgvFoodUpdate.CurrentRow.Cells[0].Value);

           


            foreach (var item in context.Meals.Where(x => x.MealID == mealID).Select(y => y.Foods).FirstOrDefault())
            {
                if (item != null)
                {
                    lstbEatsFood.Items.Add(item);
                    lstbEatsFood.DisplayMember = "FoodName";
                    lstbEatsFood.ValueMember = "Calories";
                    _foods.Add(item);
                }
                
            }
            lstbEatsFood.DisplayMember = "FoodName";
            lstbEatsFood.ValueMember = "Calorie";
            
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstbEatsFood !=null)
            {
                lstbEatsFood.Items.Remove(lstbEatsFood.SelectedItem);
                _foods.Remove((Food)lstbEatsFood.SelectedItem);

            }
            else
            {
                MessageBox.Show("Silinicek yemek bulunamadı.");
            }
        }
    }
}
