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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class frmUserProfile : Form
    {
        CalorieTrackingContext context;
        public User _userProfile;
        public frmFoodAdd _foodAdd;
        public frmUserProfile _frmUserProfile;
        public frmStatistics _statisticsForm;
        private DateTime time;
        private DateTime time2;
        
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

            time = dtpDailyReport.Value.Date;

            var SecilenTarih = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate == DateTime.Today).ToList();

            dgvDailyReport.DataSource = SecilenTarih;
            dgvDailyReport.Columns["UserId"].Visible = false;
            dgvDailyReport.Columns["MealID"].Visible = false;
            dgvDailyReport.Columns["User"].Visible = false;
            dgvDailyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvDailyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvDailyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";

            ComboBoxDoldur();
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
            _statisticsForm = new frmStatistics(_userProfile);
            _statisticsForm.Show();
            this.Close();
        }

        private void dtpDailyReport_ValueChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;

            var SecilenTarih = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate == time).ToList();

            dgvDailyReport.DataSource = SecilenTarih;
            dgvDailyReport.Columns["UserId"].Visible = false;
            dgvDailyReport.Columns["MealID"].Visible = false;
            dgvDailyReport.Columns["User"].Visible = false;
            dgvDailyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvDailyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvDailyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";


            //foreach (var item in SecilenTarih)
            //{

            //     dgvDailyReport.DataSource = context.Meals.Where(x => x.UserId == _userProfile.UserID).Select(u => new { u.MealDate, u.MealName, u.TotalMealCalories }).ToList();

            //}
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;
            time2 = dtpDailyReport.Value.Date.AddDays(-7);

            var SecilenTarih = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate <= time && x.MealDate >= time2).OrderBy(x => x.MealDate).ToList();


            dgvWeeklyMonthlyReport.DataSource = SecilenTarih;

            dgvWeeklyMonthlyReport.Columns["UserId"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealID"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["User"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvWeeklyMonthlyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvWeeklyMonthlyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;
            time2 = dtpDailyReport.Value.Date.AddDays(-30);

            var SecilenTarih = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate <= time && x.MealDate >= time2).OrderBy(x => x.MealDate).ToList();


            dgvWeeklyMonthlyReport.DataSource = SecilenTarih;

            dgvWeeklyMonthlyReport.Columns["UserId"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealID"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["User"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvWeeklyMonthlyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvWeeklyMonthlyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }

        private void ComboBoxDoldur()
        {
            cmbMealSelection.DataSource = Enum.GetNames(typeof(MealType)).ToList();
            cmbMealSelection.SelectedIndex = -1;

        }

        private void rbWeeklyComparison_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbMealSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öğün Seçimi Yapınız");
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Breakfast)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-7);
                
                var liste = context.Meals
                .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Breakfast && m.MealDate <= time && m.MealDate>= time2)
                .SelectMany(f => f.Foods)
                .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

                dgvWeeklyMonthlyReport.Columns[1].HeaderText = "Food Name";
                dgvWeeklyMonthlyReport.Columns[2].HeaderText = "Total Calorie";
               
               

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Dinner )
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-7);

                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner && m.MealDate <= time && m.MealDate>= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;


                

                //dgvComparisonReport.DataSource = context.Meals
                //    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner)
                //    .SelectMany(f => f.Foods).Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName }).ToList();

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Snack)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-7);


                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Snack && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

                

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Lunch)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-7);

                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Lunch && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

            }



        }

        private void rbmounthlyComparison_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbMealSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öğün Seçimi Yapınız");
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Breakfast)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-30);


                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Breakfast && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

                //dgvComparisonReport.DataSource = context.Meals
                //    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Breakfast)
                //    .SelectMany(f => f.Foods).Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName }).ToList();

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Dinner)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-30);

                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

                //dgvComparisonReport.DataSource = context.Meals
                //    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner)
                //    .SelectMany(f => f.Foods).Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName }).ToList();

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Snack)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-30);

                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Snack && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;
                //dgvComparisonReport.DataSource = context.Meals
                //    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Snack)
                //    .SelectMany(f => f.Foods).Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName }).ToList();

            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Lunch)
            {
                time = DateTime.Today;
                time2 = DateTime.Today.AddDays(-30);

                var liste = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Lunch && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listeGruopBylı = liste.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listeGruopBylı;

                //dgvComparisonReport.DataSource = context.Meals
                //    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Lunch)
                //    .SelectMany(f => f.Foods).Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName }).ToList();
            }
        }

        private void cmbMealSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbWeeklyComparison.Checked == true)
            {
                rbWeeklyComparison_CheckedChanged(sender, e);
            }
            else if (rbmounthlyComparison.Checked == true)
            {
                rbmounthlyComparison_CheckedChanged(sender, e);
            }


        }
    }
}
