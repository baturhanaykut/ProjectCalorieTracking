namespace UI
{
    partial class FoodAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAddForm));
            this.mntcldrCalender = new System.Windows.Forms.MonthCalendar();
            this.pctbPicture = new System.Windows.Forms.PictureBox();
            this.lblChooseYourMeals = new System.Windows.Forms.Label();
            this.cmbChooseYourMeals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoods = new System.Windows.Forms.Label();
            this.cmbFoods = new System.Windows.Forms.ComboBox();
            this.nmrcAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddYourOwnFood = new System.Windows.Forms.Button();
            this.btnBacktoUserForm = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // mntcldrCalender
            // 
            this.mntcldrCalender.Location = new System.Drawing.Point(16, 14);
            this.mntcldrCalender.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mntcldrCalender.Name = "mntcldrCalender";
            this.mntcldrCalender.TabIndex = 0;
            // 
            // pctbPicture
            // 
            this.pctbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pctbPicture.Image")));
            this.pctbPicture.Location = new System.Drawing.Point(256, 14);
            this.pctbPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbPicture.Name = "pctbPicture";
            this.pctbPicture.Size = new System.Drawing.Size(463, 155);
            this.pctbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPicture.TabIndex = 1;
            this.pctbPicture.TabStop = false;
            // 
            // lblChooseYourMeals
            // 
            this.lblChooseYourMeals.AutoSize = true;
            this.lblChooseYourMeals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseYourMeals.Location = new System.Drawing.Point(16, 206);
            this.lblChooseYourMeals.Name = "lblChooseYourMeals";
            this.lblChooseYourMeals.Size = new System.Drawing.Size(116, 15);
            this.lblChooseYourMeals.TabIndex = 2;
            this.lblChooseYourMeals.Text = "Choose Your Meals :";
            // 
            // cmbChooseYourMeals
            // 
            this.cmbChooseYourMeals.FormattingEnabled = true;
            this.cmbChooseYourMeals.Location = new System.Drawing.Point(173, 204);
            this.cmbChooseYourMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseYourMeals.Name = "cmbChooseYourMeals";
            this.cmbChooseYourMeals.Size = new System.Drawing.Size(160, 23);
            this.cmbChooseYourMeals.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food Category :";
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(173, 271);
            this.cmbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(160, 23);
            this.cmbFoodCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Your Meal First";
            // 
            // lblFoods
            // 
            this.lblFoods.AutoSize = true;
            this.lblFoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoods.Location = new System.Drawing.Point(94, 344);
            this.lblFoods.Name = "lblFoods";
            this.lblFoods.Size = new System.Drawing.Size(45, 15);
            this.lblFoods.TabIndex = 7;
            this.lblFoods.Text = "Foods :";
            // 
            // cmbFoods
            // 
            this.cmbFoods.FormattingEnabled = true;
            this.cmbFoods.Location = new System.Drawing.Point(173, 344);
            this.cmbFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFoods.Name = "cmbFoods";
            this.cmbFoods.Size = new System.Drawing.Size(160, 23);
            this.cmbFoods.TabIndex = 8;
            // 
            // nmrcAmount
            // 
            this.nmrcAmount.Location = new System.Drawing.Point(447, 344);
            this.nmrcAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrcAmount.Name = "nmrcAmount";
            this.nmrcAmount.Size = new System.Drawing.Size(131, 23);
            this.nmrcAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(361, 346);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount :";
            // 
            // btnAddYourOwnFood
            // 
            this.btnAddYourOwnFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddYourOwnFood.Location = new System.Drawing.Point(389, 271);
            this.btnAddYourOwnFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddYourOwnFood.Name = "btnAddYourOwnFood";
            this.btnAddYourOwnFood.Size = new System.Drawing.Size(189, 38);
            this.btnAddYourOwnFood.TabIndex = 11;
            this.btnAddYourOwnFood.Text = "Add Your Own Food";
            this.btnAddYourOwnFood.UseVisualStyleBackColor = true;
            // 
            // btnBacktoUserForm
            // 
            this.btnBacktoUserForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoUserForm.Location = new System.Drawing.Point(374, 439);
            this.btnBacktoUserForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBacktoUserForm.Name = "btnBacktoUserForm";
            this.btnBacktoUserForm.Size = new System.Drawing.Size(229, 54);
            this.btnBacktoUserForm.TabIndex = 12;
            this.btnBacktoUserForm.Text = "Back to User Form";
            this.btnBacktoUserForm.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(103, 439);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(229, 54);
            this.btnAddFood.TabIndex = 13;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // FoodAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 542);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnBacktoUserForm);
            this.Controls.Add(this.btnAddYourOwnFood);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.nmrcAmount);
            this.Controls.Add(this.cmbFoods);
            this.Controls.Add(this.lblFoods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFoodCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChooseYourMeals);
            this.Controls.Add(this.lblChooseYourMeals);
            this.Controls.Add(this.pctbPicture);
            this.Controls.Add(this.mntcldrCalender);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FoodAddForm";
            this.Text = "FoodAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar mntcldrCalender;
        private PictureBox pctbPicture;
        private Label lblChooseYourMeals;
        private ComboBox cmbChooseYourMeals;
        private Label label1;
        private ComboBox cmbFoodCategory;
        private Label label2;
        private Label lblFoods;
        private ComboBox cmbFoods;
        private NumericUpDown nmrcAmount;
        private Label lblAmount;
        private Button btnAddYourOwnFood;
        private Button btnBacktoUserForm;
        private Button btnAddFood;
    }
}