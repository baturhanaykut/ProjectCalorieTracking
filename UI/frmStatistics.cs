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
        public frmUserProfile _frmUserProfile;
        public User _user;
        
        public frmStatistics(User user, frmUserProfile frmUserProfile )
        {
            InitializeComponent();
            _user = user;
            _frmUserProfile = frmUserProfile;
        }
        
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            
        }
        private void btnBackUserForm_Click(object sender, EventArgs e)
        {
            _frmUserProfile.Show();
            this.Close();
        }


        //Hangi Yemeklerin hangi öğünler ne kadar yendiğini gösteren bir rapor hazırlansın.En çok yemek yenen raporu




    }
}
