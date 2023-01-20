namespace UI
{
    partial class StatisticsForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseMeal
            // 
            this.cmbChooseMeal.FormattingEnabled = true;
            this.cmbChooseMeal.Location = new System.Drawing.Point(26, 32);
            this.cmbChooseMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseMeal.Name = "cmbChooseMeal";
            this.cmbChooseMeal.Size = new System.Drawing.Size(182, 23);
            this.cmbChooseMeal.TabIndex = 0;
            // 
            // dgvChooseFood
            // 
            this.dgvChooseFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseFood.Location = new System.Drawing.Point(26, 69);
            this.dgvChooseFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChooseFood.Name = "dgvChooseFood";
            this.dgvChooseFood.RowHeadersWidth = 51;
            this.dgvChooseFood.RowTemplate.Height = 29;
            this.dgvChooseFood.Size = new System.Drawing.Size(767, 146);
            this.dgvChooseFood.TabIndex = 1;
            // 
            // dgvMealReport
            // 
            this.dgvMealReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealReport.Location = new System.Drawing.Point(26, 284);
            this.dgvMealReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealReport.Name = "dgvMealReport";
            this.dgvMealReport.RowHeadersWidth = 51;
            this.dgvMealReport.RowTemplate.Height = 29;
            this.dgvMealReport.Size = new System.Drawing.Size(767, 189);
            this.dgvMealReport.TabIndex = 2;
            // 
            // btnBackUserForm
            // 
            this.btnBackUserForm.Location = new System.Drawing.Point(609, 490);
            this.btnBackUserForm.Name = "btnBackUserForm";
            this.btnBackUserForm.Size = new System.Drawing.Size(161, 35);
            this.btnBackUserForm.TabIndex = 3;
            this.btnBackUserForm.Text = "Back To User Form";
            this.btnBackUserForm.UseVisualStyleBackColor = true;
            this.btnBackUserForm.Click += new System.EventHandler(this.btnBackUserForm_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 537);
            this.Controls.Add(this.btnBackUserForm);
            this.Controls.Add(this.dgvMealReport);
            this.Controls.Add(this.dgvChooseFood);
            this.Controls.Add(this.cmbChooseMeal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbChooseMeal;
        private DataGridView dgvChooseFood;
        private DataGridView dgvMealReport;
        private Button btnBackUserForm;
    }
}