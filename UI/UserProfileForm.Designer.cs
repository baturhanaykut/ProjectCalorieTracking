namespace UI
{
    partial class UserProfileForm
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
            this.rbmounthlyComparison = new System.Windows.Forms.RadioButton();
            this.rbWeeklyComparison = new System.Windows.Forms.RadioButton();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnStatisticsForm = new System.Windows.Forms.Button();
            this.dgvComparisonReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMonthlyReport)).BeginInit();
            this.dvgComparisonReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbUserPicture
            // 
            this.pctbUserPicture.Location = new System.Drawing.Point(1142, 84);
            this.pctbUserPicture.Name = "pctbUserPicture";
            this.pctbUserPicture.Size = new System.Drawing.Size(163, 187);
            this.pctbUserPicture.TabIndex = 0;
            this.pctbUserPicture.TabStop = false;
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Location = new System.Drawing.Point(12, 84);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.RowTemplate.Height = 29;
            this.dgvDailyReport.Size = new System.Drawing.Size(554, 188);
            this.dgvDailyReport.TabIndex = 1;
            // 
            // dgvWeeklyMonthlyReport
            // 
            this.dgvWeeklyMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyMonthlyReport.Location = new System.Drawing.Point(582, 84);
            this.dgvWeeklyMonthlyReport.Name = "dgvWeeklyMonthlyReport";
            this.dgvWeeklyMonthlyReport.RowHeadersWidth = 51;
            this.dgvWeeklyMonthlyReport.RowTemplate.Height = 29;
            this.dgvWeeklyMonthlyReport.Size = new System.Drawing.Size(543, 188);
            this.dgvWeeklyMonthlyReport.TabIndex = 2;
            // 
            // dtpDailyReport
            // 
            this.dtpDailyReport.Location = new System.Drawing.Point(264, 38);
            this.dtpDailyReport.Name = "dtpDailyReport";
            this.dtpDailyReport.Size = new System.Drawing.Size(302, 27);
            this.dtpDailyReport.TabIndex = 3;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeekly.Location = new System.Drawing.Point(717, 41);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(81, 24);
            this.rbWeekly.TabIndex = 4;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMonthly.Location = new System.Drawing.Point(913, 41);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(89, 24);
            this.rbMonthly.TabIndex = 5;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // lblSelectedDailyReport
            // 
            this.lblSelectedDailyReport.AutoSize = true;
            this.lblSelectedDailyReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDailyReport.Location = new System.Drawing.Point(26, 43);
            this.lblSelectedDailyReport.Name = "lblSelectedDailyReport";
            this.lblSelectedDailyReport.Size = new System.Drawing.Size(166, 20);
            this.lblSelectedDailyReport.TabIndex = 6;
            this.lblSelectedDailyReport.Text = "Selected Daily Report :";
            // 
            // cmbMealSelection
            // 
            this.cmbMealSelection.FormattingEnabled = true;
            this.cmbMealSelection.Location = new System.Drawing.Point(14, 26);
            this.cmbMealSelection.Name = "cmbMealSelection";
            this.cmbMealSelection.Size = new System.Drawing.Size(239, 28);
            this.cmbMealSelection.TabIndex = 7;
            // 
            // dvgComparisonReport
            // 
            this.dvgComparisonReport.Controls.Add(this.dgvComparisonReport);
            this.dvgComparisonReport.Controls.Add(this.rbmounthlyComparison);
            this.dvgComparisonReport.Controls.Add(this.rbWeeklyComparison);
            this.dvgComparisonReport.Controls.Add(this.cmbMealSelection);
            this.dvgComparisonReport.Location = new System.Drawing.Point(12, 313);
            this.dvgComparisonReport.Name = "dvgComparisonReport";
            this.dvgComparisonReport.Size = new System.Drawing.Size(1293, 315);
            this.dvgComparisonReport.TabIndex = 8;
            this.dvgComparisonReport.TabStop = false;
            this.dvgComparisonReport.Text = "Comparison Report";
            // 
            // rbmounthlyComparison
            // 
            this.rbmounthlyComparison.AutoSize = true;
            this.rbmounthlyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbmounthlyComparison.Location = new System.Drawing.Point(600, 30);
            this.rbmounthlyComparison.Name = "rbmounthlyComparison";
            this.rbmounthlyComparison.Size = new System.Drawing.Size(89, 24);
            this.rbmounthlyComparison.TabIndex = 9;
            this.rbmounthlyComparison.TabStop = true;
            this.rbmounthlyComparison.Text = "Monthly";
            this.rbmounthlyComparison.UseVisualStyleBackColor = true;
            // 
            // rbWeeklyComparison
            // 
            this.rbWeeklyComparison.AutoSize = true;
            this.rbWeeklyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeeklyComparison.Location = new System.Drawing.Point(404, 30);
            this.rbWeeklyComparison.Name = "rbWeeklyComparison";
            this.rbWeeklyComparison.Size = new System.Drawing.Size(81, 24);
            this.rbWeeklyComparison.TabIndex = 8;
            this.rbWeeklyComparison.TabStop = true;
            this.rbWeeklyComparison.Text = "Weekly";
            this.rbWeeklyComparison.UseVisualStyleBackColor = true;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.Location = new System.Drawing.Point(12, 645);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(636, 53);
            this.btnAddMeal.TabIndex = 9;
            this.btnAddMeal.Text = "Add a Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            // 
            // btnStatisticsForm
            // 
            this.btnStatisticsForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatisticsForm.Location = new System.Drawing.Point(669, 645);
            this.btnStatisticsForm.Name = "btnStatisticsForm";
            this.btnStatisticsForm.Size = new System.Drawing.Size(636, 53);
            this.btnStatisticsForm.TabIndex = 10;
            this.btnStatisticsForm.Text = "Statistics Form";
            this.btnStatisticsForm.UseVisualStyleBackColor = true;
            // 
            // dgvComparisonReport
            // 
            this.dgvComparisonReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparisonReport.Location = new System.Drawing.Point(14, 73);
            this.dgvComparisonReport.Name = "dgvComparisonReport";
            this.dgvComparisonReport.RowHeadersWidth = 51;
            this.dgvComparisonReport.RowTemplate.Height = 29;
            this.dgvComparisonReport.Size = new System.Drawing.Size(1273, 236);
            this.dgvComparisonReport.TabIndex = 10;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 710);
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
            this.Name = "UserProfileForm";
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
    }
}