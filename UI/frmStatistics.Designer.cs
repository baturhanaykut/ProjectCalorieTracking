namespace UI
{
    partial class frmStatistics
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
            this.cmbChooseMeal = new System.Windows.Forms.ComboBox();
            this.dgvChooseFood = new System.Windows.Forms.DataGridView();
            this.dgvMealReport = new System.Windows.Forms.DataGridView();
            this.btnBackUserForm = new System.Windows.Forms.Button();
            this.rbtnBreakfast = new System.Windows.Forms.RadioButton();
            this.rbtnLunch = new System.Windows.Forms.RadioButton();
            this.rbtnSnack = new System.Windows.Forms.RadioButton();
            this.rbtnDinner = new System.Windows.Forms.RadioButton();
            this.lblChooseCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseMeal
            // 
            this.cmbChooseMeal.FormattingEnabled = true;
            this.cmbChooseMeal.Location = new System.Drawing.Point(226, 44);
            this.cmbChooseMeal.Name = "cmbChooseMeal";
            this.cmbChooseMeal.Size = new System.Drawing.Size(207, 28);
            this.cmbChooseMeal.TabIndex = 0;
            this.cmbChooseMeal.SelectedIndexChanged += new System.EventHandler(this.cmbChooseMeal_SelectedIndexChanged);
            // 
            // dgvChooseFood
            // 
            this.dgvChooseFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseFood.Location = new System.Drawing.Point(30, 211);
            this.dgvChooseFood.Name = "dgvChooseFood";
            this.dgvChooseFood.RowHeadersWidth = 51;
            this.dgvChooseFood.RowTemplate.Height = 29;
            this.dgvChooseFood.Size = new System.Drawing.Size(544, 195);
            this.dgvChooseFood.TabIndex = 1;
            // 
            // dgvMealReport
            // 
            this.dgvMealReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealReport.Location = new System.Drawing.Point(30, 429);
            this.dgvMealReport.Name = "dgvMealReport";
            this.dgvMealReport.RowHeadersWidth = 51;
            this.dgvMealReport.RowTemplate.Height = 29;
            this.dgvMealReport.Size = new System.Drawing.Size(544, 252);
            this.dgvMealReport.TabIndex = 2;
            // 
            // btnBackUserForm
            // 
            this.btnBackUserForm.Location = new System.Drawing.Point(390, 688);
            this.btnBackUserForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackUserForm.Name = "btnBackUserForm";
            this.btnBackUserForm.Size = new System.Drawing.Size(184, 47);
            this.btnBackUserForm.TabIndex = 3;
            this.btnBackUserForm.Text = "Back To User Form";
            this.btnBackUserForm.UseVisualStyleBackColor = true;
            this.btnBackUserForm.Click += new System.EventHandler(this.btnBackUserForm_Click);
            // 
            // rbtnBreakfast
            // 
            this.rbtnBreakfast.AutoSize = true;
            this.rbtnBreakfast.Location = new System.Drawing.Point(30, 100);
            this.rbtnBreakfast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnBreakfast.Name = "rbtnBreakfast";
            this.rbtnBreakfast.Size = new System.Drawing.Size(91, 24);
            this.rbtnBreakfast.TabIndex = 4;
            this.rbtnBreakfast.TabStop = true;
            this.rbtnBreakfast.Text = "Breakfast";
            this.rbtnBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbtnLunch
            // 
            this.rbtnLunch.AutoSize = true;
            this.rbtnLunch.Location = new System.Drawing.Point(120, 100);
            this.rbtnLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLunch.Name = "rbtnLunch";
            this.rbtnLunch.Size = new System.Drawing.Size(68, 24);
            this.rbtnLunch.TabIndex = 5;
            this.rbtnLunch.TabStop = true;
            this.rbtnLunch.Text = "Lunch";
            this.rbtnLunch.UseVisualStyleBackColor = true;
            // 
            // rbtnSnack
            // 
            this.rbtnSnack.AutoSize = true;
            this.rbtnSnack.Location = new System.Drawing.Point(197, 100);
            this.rbtnSnack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnSnack.Name = "rbtnSnack";
            this.rbtnSnack.Size = new System.Drawing.Size(68, 24);
            this.rbtnSnack.TabIndex = 6;
            this.rbtnSnack.TabStop = true;
            this.rbtnSnack.Text = "Snack";
            this.rbtnSnack.UseVisualStyleBackColor = true;
            // 
            // rbtnDinner
            // 
            this.rbtnDinner.AutoSize = true;
            this.rbtnDinner.Location = new System.Drawing.Point(267, 100);
            this.rbtnDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDinner.Name = "rbtnDinner";
            this.rbtnDinner.Size = new System.Drawing.Size(74, 24);
            this.rbtnDinner.TabIndex = 7;
            this.rbtnDinner.TabStop = true;
            this.rbtnDinner.Text = "Dinner";
            this.rbtnDinner.UseVisualStyleBackColor = true;
            // 
            // lblChooseCategory
            // 
            this.lblChooseCategory.AutoSize = true;
            this.lblChooseCategory.Location = new System.Drawing.Point(30, 47);
            this.lblChooseCategory.Name = "lblChooseCategory";
            this.lblChooseCategory.Size = new System.Drawing.Size(175, 20);
            this.lblChooseCategory.TabIndex = 8;
            this.lblChooseCategory.Text = "Please Choose Category :";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 768);
            this.Controls.Add(this.lblChooseCategory);
            this.Controls.Add(this.rbtnDinner);
            this.Controls.Add(this.rbtnSnack);
            this.Controls.Add(this.rbtnLunch);
            this.Controls.Add(this.rbtnBreakfast);
            this.Controls.Add(this.btnBackUserForm);
            this.Controls.Add(this.dgvMealReport);
            this.Controls.Add(this.dgvChooseFood);
            this.Controls.Add(this.cmbChooseMeal);
            this.Name = "frmStatistics";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbChooseMeal;
        private DataGridView dgvChooseFood;
        private DataGridView dgvMealReport;
        private Button btnBackUserForm;
        private RadioButton rbtnBreakfast;
        private RadioButton rbtnLunch;
        private RadioButton rbtnSnack;
        private RadioButton rbtnDinner;
        private Label lblChooseCategory;
    }
}