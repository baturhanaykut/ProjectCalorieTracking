﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private UserProfileForm _userProfileForm;


        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            _userProfileForm = new UserProfileForm();
        }
        private void btnBackUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
            _userProfileForm.Show();
        }
    }
}
