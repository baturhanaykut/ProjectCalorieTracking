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

            var result = (from f in context.Foods
                join fm in context.Meals on fm 

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
            

        }


        //Hangi yemeklerin hangi öğünlerde ne kadar yendiğini gösteren bir rapor hazırlansın.
        //En çok yenen yemekler raporu çıksın.




    }
}
