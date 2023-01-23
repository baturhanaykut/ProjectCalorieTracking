namespace UI
{
    partial class frmUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctbUserPicture = new System.Windows.Forms.PictureBox();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.dgvWeeklyMonthlyReport = new System.Windows.Forms.DataGridView();
            this.dtpDailyReport = new System.Windows.Forms.DateTimePicker();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.lblSelectedDailyReport = new System.Windows.Forms.Label();
            this.cmbMealSelection = new System.Windows.Forms.ComboBox();
            this.dvgComparisonReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComparisonReport = new System.Windows.Forms.DataGridView();
            this.rbmounthlyComparison = new System.Windows.Forms.RadioButton();
            this.rbWeeklyComparison = new System.Windows.Forms.RadioButton();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnStatisticsForm = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMonthlyReport)).BeginInit();
            this.dvgComparisonReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbUserPicture
            // 
            this.pctbUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbUserPicture.Location = new System.Drawing.Point(14, 15);
            this.pctbUserPicture.Name = "pctbUserPicture";
            this.pctbUserPicture.Size = new System.Drawing.Size(207, 186);
            this.pctbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbUserPicture.TabIndex = 0;
            this.pctbUserPicture.TabStop = false;
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Location = new System.Drawing.Point(241, 61);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.RowTemplate.Height = 29;
            this.dgvDailyReport.Size = new System.Drawing.Size(455, 188);
            this.dgvDailyReport.TabIndex = 1;
            // 
            // dgvWeeklyMonthlyReport
            // 
            this.dgvWeeklyMonthlyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeeklyMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyMonthlyReport.Location = new System.Drawing.Point(717, 61);
            this.dgvWeeklyMonthlyReport.Name = "dgvWeeklyMonthlyReport";
            this.dgvWeeklyMonthlyReport.RowHeadersWidth = 51;
            this.dgvWeeklyMonthlyReport.RowTemplate.Height = 29;
            this.dgvWeeklyMonthlyReport.Size = new System.Drawing.Size(433, 188);
            this.dgvWeeklyMonthlyReport.TabIndex = 2;
            // 
            // dtpDailyReport
            // 
            this.dtpDailyReport.Location = new System.Drawing.Point(494, 15);
            this.dtpDailyReport.Name = "dtpDailyReport";
            this.dtpDailyReport.Size = new System.Drawing.Size(202, 27);
            this.dtpDailyReport.TabIndex = 3;
            this.dtpDailyReport.ValueChanged += new System.EventHandler(this.dtpDailyReport_ValueChanged);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeekly.Location = new System.Drawing.Point(851, 19);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(81, 24);
            this.rbWeekly.TabIndex = 4;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.CheckedChanged += new System.EventHandler(this.rbWeekly_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMonthly.Location = new System.Drawing.Point(1048, 19);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(89, 24);
            this.rbMonthly.TabIndex = 5;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // lblSelectedDailyReport
            // 
            this.lblSelectedDailyReport.AutoSize = true;
            this.lblSelectedDailyReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDailyReport.Location = new System.Drawing.Point(256, 20);
            this.lblSelectedDailyReport.Name = "lblSelectedDailyReport";
            this.lblSelectedDailyReport.Size = new System.Drawing.Size(166, 20);
            this.lblSelectedDailyReport.TabIndex = 6;
            this.lblSelectedDailyReport.Text = "Selected Daily Report :";
            // 
            // cmbMealSelection
            // 
            this.cmbMealSelection.FormattingEnabled = true;
            this.cmbMealSelection.Location = new System.Drawing.Point(122, 26);
            this.cmbMealSelection.Name = "cmbMealSelection";
            this.cmbMealSelection.Size = new System.Drawing.Size(239, 28);
            this.cmbMealSelection.TabIndex = 7;
            this.cmbMealSelection.SelectedIndexChanged += new System.EventHandler(this.cmbMealSelection_SelectedIndexChanged);
            // 
            // dvgComparisonReport
            // 
            this.dvgComparisonReport.Controls.Add(this.label1);
            this.dvgComparisonReport.Controls.Add(this.dgvComparisonReport);
            this.dvgComparisonReport.Controls.Add(this.rbmounthlyComparison);
            this.dvgComparisonReport.Controls.Add(this.rbWeeklyComparison);
            this.dvgComparisonReport.Controls.Add(this.cmbMealSelection);
            this.dvgComparisonReport.Location = new System.Drawing.Point(241, 291);
            this.dvgComparisonReport.Name = "dvgComparisonReport";
            this.dvgComparisonReport.Size = new System.Drawing.Size(918, 315);
            this.dvgComparisonReport.TabIndex = 8;
            this.dvgComparisonReport.TabStop = false;
            this.dvgComparisonReport.Text = "Comparison Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Meals";
            // 
            // dgvComparisonReport
            // 
            this.dgvComparisonReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparisonReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparisonReport.Location = new System.Drawing.Point(14, 73);
            this.dgvComparisonReport.Name = "dgvComparisonReport";
            this.dgvComparisonReport.RowHeadersWidth = 51;
            this.dgvComparisonReport.RowTemplate.Height = 29;
            this.dgvComparisonReport.Size = new System.Drawing.Size(874, 236);
            this.dgvComparisonReport.TabIndex = 10;
            // 
            // rbmounthlyComparison
            // 
            this.rbmounthlyComparison.AutoSize = true;
            this.rbmounthlyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbmounthlyComparison.Location = new System.Drawing.Point(606, 24);
            this.rbmounthlyComparison.Name = "rbmounthlyComparison";
            this.rbmounthlyComparison.Size = new System.Drawing.Size(89, 24);
            this.rbmounthlyComparison.TabIndex = 9;
            this.rbmounthlyComparison.TabStop = true;
            this.rbmounthlyComparison.Text = "Monthly";
            this.rbmounthlyComparison.UseVisualStyleBackColor = true;
            this.rbmounthlyComparison.CheckedChanged += new System.EventHandler(this.rbmounthlyComparison_CheckedChanged);
            // 
            // rbWeeklyComparison
            // 
            this.rbWeeklyComparison.AutoSize = true;
            this.rbWeeklyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeeklyComparison.Location = new System.Drawing.Point(445, 24);
            this.rbWeeklyComparison.Name = "rbWeeklyComparison";
            this.rbWeeklyComparison.Size = new System.Drawing.Size(81, 24);
            this.rbWeeklyComparison.TabIndex = 8;
            this.rbWeeklyComparison.TabStop = true;
            this.rbWeeklyComparison.Text = "Weekly";
            this.rbWeeklyComparison.UseVisualStyleBackColor = true;
            this.rbWeeklyComparison.CheckedChanged += new System.EventHandler(this.rbWeeklyComparison_CheckedChanged);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.Location = new System.Drawing.Point(241, 623);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(395, 53);
            this.btnAddMeal.TabIndex = 9;
            this.btnAddMeal.Text = "Add a Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnStatisticsForm
            // 
            this.btnStatisticsForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatisticsForm.Location = new System.Drawing.Point(686, 623);
            this.btnStatisticsForm.Name = "btnStatisticsForm";
            this.btnStatisticsForm.Size = new System.Drawing.Size(473, 53);
            this.btnStatisticsForm.TabIndex = 10;
            this.btnStatisticsForm.Text = "Statistics Form";
            this.btnStatisticsForm.UseVisualStyleBackColor = true;
            this.btnStatisticsForm.Click += new System.EventHandler(this.btnStatisticsForm_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Location = new System.Drawing.Point(16, 219);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(205, 187);
            this.lblUserInfo.TabIndex = 11;
            this.lblUserInfo.Text = "User Info";
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 757);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnStatisticsForm);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.dvgComparisonReport);
            this.Controls.Add(this.lblSelectedDailyReport);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.dtpDailyReport);
            this.Controls.Add(this.dgvWeeklyMonthlyReport);
            this.Controls.Add(this.dgvDailyReport);
            this.Controls.Add(this.pctbUserPicture);
            this.Name = "frmUserProfile";
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMonthlyReport)).EndInit();
            this.dvgComparisonReport.ResumeLayout(false);
            this.dvgComparisonReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctbUserPicture;
        private DataGridView dgvDailyReport;
        private DataGridView dgvWeeklyMonthlyReport;
        private DateTimePicker dtpDailyReport;
        private RadioButton rbWeekly;
        private RadioButton rbMonthly;
        private Label lblSelectedDailyReport;
        private ComboBox cmbMealSelection;
        private GroupBox dvgComparisonReport;
        private DataGridView dgvComparisonReport;
        private RadioButton rbmounthlyComparison;
        private RadioButton rbWeeklyComparison;
        private Button btnAddMeal;
        private Button btnStatisticsForm;
        private Label lblUserInfo;
        private Label label1;
    }
}