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
    public partial class frmUserProfile : Form
    {
        CalorieTrackingContext context;
        public User _userProfile;
        public frmFoodAdd _foodAdd;
        

        public frmUserProfile(User user)
        {
            InitializeComponent();
            _userProfile = user;
        }


        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            lblUserInfo.Text = "İsim Soyisim :" + _userProfile.UserName + " " + _userProfile.UserSurname + "\n" + "Kilosu :" + _userProfile.UserWeight + "\n" + "Boyu :" + _userProfile.UserHeight + "\n" + "Doğum Tarihi :" + _userProfile.UserBirthDate.ToShortDateString();

            if (_userProfile.PhotoPath != null)
            {
                pctbUserPicture.Image = Image.FromFile(_userProfile.PhotoPath);
            }

            dgvDailyReport.DataSource = context.Meals.Select(u => new { u.MealDate, u.MealName, u.TotalMealCalories }).ToList();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            _foodAdd = new frmFoodAdd(_userProfile);
           _foodAdd.Show();

            //frmFoodAdd foodAddfrm = new frmFoodAdd();
            //foodAddfrm.Show();
            this.Close();
        }

        private void btnStatisticsForm_Click(object sender, EventArgs e)
        {
            frmStatistics statisticsForm = new frmStatistics();
            statisticsForm.Show();
            this.Close();
        }
    }
}
