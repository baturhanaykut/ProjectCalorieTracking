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
    public partial class frmStatistics : Form
    {
        CalorieTrackingContext context;
        public frmUserProfile _userProfileForm;
        public User _user;
        
        public frmStatistics(User frmUserProfile)
        {
            InitializeComponent();
            _user = frmUserProfile;
        }
        
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            _userProfileForm = new frmUserProfile(_user);
            _userProfileForm._userProfile = _user;
        }
        private void btnBackUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
            _userProfileForm.Show();
        }


        //Hangi Yemeklerin hangi öğünler ne kadar yendiğini gösteren bir rapor hazırlansın.En çok yemek yenen raporu




    }
}
