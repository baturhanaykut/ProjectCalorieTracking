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

namespace UI
{
    public partial class UserProfileForm : Form
    {
        CalorieTrackingContext context;
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            dgvDailyReport.DataSource =
                context.Meals.Select(u => new { u.MealDate, u.MealName, u.TotalMealCalories }).ToList();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            FoodAddForm foodAddfrm = new FoodAddForm();
            foodAddfrm.Show();
            this.Close();
        }

        private void btnStatisticsForm_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
            this.Close();
        }
    }
}
