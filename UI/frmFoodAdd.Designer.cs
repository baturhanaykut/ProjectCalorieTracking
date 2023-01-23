namespace UI
{
    partial class frmFoodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodAdd));
            this.mntcldrCalender = new System.Windows.Forms.MonthCalendar();
            this.pctbPicture = new System.Windows.Forms.PictureBox();
            this.lblChooseYourMeal = new System.Windows.Forms.Label();
            this.cmbChooseYourMeals = new System.Windows.Forms.ComboBox();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lblFoods = new System.Windows.Forms.Label();
            this.btnAddYourOwnFood = new System.Windows.Forms.Button();
            this.btnBacktoUserForm = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstbAllFoodName = new System.Windows.Forms.ListBox();
            this.lstbFoodName = new System.Windows.Forms.ListBox();
            this.btnListBoxAdd = new System.Windows.Forms.Button();
            this.btnListBoxDelete = new System.Windows.Forms.Button();
            this.lblCaloriValue = new System.Windows.Forms.Label();
            this.lblAmountofCalories = new System.Windows.Forms.Label();
            this.grpFoodAdd = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvFoodAdd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPicture)).BeginInit();
            this.grpFoodAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // mntcldrCalender
            // 
            this.mntcldrCalender.Location = new System.Drawing.Point(18, 19);
            this.mntcldrCalender.MaxSelectionCount = 1;
            this.mntcldrCalender.Name = "mntcldrCalender";
            this.mntcldrCalender.TabIndex = 0;
            this.mntcldrCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntcldrCalender_DateChanged);
            // 
            // pctbPicture
            // 
            this.pctbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pctbPicture.Image")));
            this.pctbPicture.Location = new System.Drawing.Point(293, 19);
            this.pctbPicture.Name = "pctbPicture";
            this.pctbPicture.Size = new System.Drawing.Size(791, 216);
            this.pctbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPicture.TabIndex = 1;
            this.pctbPicture.TabStop = false;
            // 
            // lblChooseYourMeal
            // 
            this.lblChooseYourMeal.AutoSize = true;
            this.lblChooseYourMeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseYourMeal.Location = new System.Drawing.Point(6, 31);
            this.lblChooseYourMeal.Name = "lblChooseYourMeal";
            this.lblChooseYourMeal.Size = new System.Drawing.Size(149, 20);
            this.lblChooseYourMeal.TabIndex = 2;
            this.lblChooseYourMeal.Text = "Choose Your Meals :";
            // 
            // cmbChooseYourMeals
            // 
            this.cmbChooseYourMeals.FormattingEnabled = true;
            this.cmbChooseYourMeals.Location = new System.Drawing.Point(157, 28);
            this.cmbChooseYourMeals.Name = "cmbChooseYourMeals";
            this.cmbChooseYourMeals.Size = new System.Drawing.Size(182, 28);
            this.cmbChooseYourMeals.TabIndex = 3;
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoodCategory.Location = new System.Drawing.Point(31, 83);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(120, 20);
            this.lblFoodCategory.TabIndex = 4;
            this.lblFoodCategory.Text = "Food Category :";
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(157, 80);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(182, 28);
            this.cmbFoodCategory.TabIndex = 5;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged);
            // 
            // lblFoods
            // 
            this.lblFoods.AutoSize = true;
            this.lblFoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoods.Location = new System.Drawing.Point(87, 135);
            this.lblFoods.Name = "lblFoods";
            this.lblFoods.Size = new System.Drawing.Size(59, 20);
            this.lblFoods.TabIndex = 7;
            this.lblFoods.Text = "Foods :";
            // 
            // btnAddYourOwnFood
            // 
            this.btnAddYourOwnFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddYourOwnFood.Location = new System.Drawing.Point(402, 79);
            this.btnAddYourOwnFood.Name = "btnAddYourOwnFood";
            this.btnAddYourOwnFood.Size = new System.Drawing.Size(169, 31);
            this.btnAddYourOwnFood.TabIndex = 11;
            this.btnAddYourOwnFood.Text = "Add Your Own Food";
            this.btnAddYourOwnFood.UseVisualStyleBackColor = true;
            this.btnAddYourOwnFood.Click += new System.EventHandler(this.btnAddYourOwnFood_Click);
            // 
            // btnBacktoUserForm
            // 
            this.btnBacktoUserForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoUserForm.Location = new System.Drawing.Point(24, 695);
            this.btnBacktoUserForm.Name = "btnBacktoUserForm";
            this.btnBacktoUserForm.Size = new System.Drawing.Size(627, 72);
            this.btnBacktoUserForm.TabIndex = 12;
            this.btnBacktoUserForm.Text = "Back to User Form";
            this.btnBacktoUserForm.UseVisualStyleBackColor = true;
            this.btnBacktoUserForm.Click += new System.EventHandler(this.btnBacktoUserForm_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(24, 617);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(262, 72);
            this.btnAddFood.TabIndex = 13;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstbAllFoodName
            // 
            this.lstbAllFoodName.FormattingEnabled = true;
            this.lstbAllFoodName.ItemHeight = 20;
            this.lstbAllFoodName.Location = new System.Drawing.Point(157, 137);
            this.lstbAllFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbAllFoodName.MultiColumn = true;
            this.lstbAllFoodName.Name = "lstbAllFoodName";
            this.lstbAllFoodName.Size = new System.Drawing.Size(185, 164);
            this.lstbAllFoodName.TabIndex = 14;
            // 
            // lstbFoodName
            // 
            this.lstbFoodName.FormattingEnabled = true;
            this.lstbFoodName.ItemHeight = 20;
            this.lstbFoodName.Location = new System.Drawing.Point(422, 135);
            this.lstbFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbFoodName.Name = "lstbFoodName";
            this.lstbFoodName.Size = new System.Drawing.Size(185, 164);
            this.lstbFoodName.TabIndex = 15;
            // 
            // btnListBoxAdd
            // 
            this.btnListBoxAdd.Location = new System.Drawing.Point(349, 171);
            this.btnListBoxAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListBoxAdd.Name = "btnListBoxAdd";
            this.btnListBoxAdd.Size = new System.Drawing.Size(59, 31);
            this.btnListBoxAdd.TabIndex = 16;
            this.btnListBoxAdd.Text = "-->";
            this.btnListBoxAdd.UseVisualStyleBackColor = true;
            this.btnListBoxAdd.Click += new System.EventHandler(this.btnListBoxAdd_Click);
            // 
            // btnListBoxDelete
            // 
            this.btnListBoxDelete.Location = new System.Drawing.Point(349, 229);
            this.btnListBoxDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListBoxDelete.Name = "btnListBoxDelete";
            this.btnListBoxDelete.Size = new System.Drawing.Size(59, 31);
            this.btnListBoxDelete.TabIndex = 16;
            this.btnListBoxDelete.Text = "<--";
            this.btnListBoxDelete.UseVisualStyleBackColor = true;
            this.btnListBoxDelete.Click += new System.EventHandler(this.btnListBoxDelete_Click);
            // 
            // lblCaloriValue
            // 
            this.lblCaloriValue.AutoSize = true;
            this.lblCaloriValue.Location = new System.Drawing.Point(571, 315);
            this.lblCaloriValue.Name = "lblCaloriValue";
            this.lblCaloriValue.Size = new System.Drawing.Size(17, 20);
            this.lblCaloriValue.TabIndex = 17;
            this.lblCaloriValue.Text = "0";
            // 
            // lblAmountofCalories
            // 
            this.lblAmountofCalories.AutoSize = true;
            this.lblAmountofCalories.Location = new System.Drawing.Point(422, 315);
            this.lblAmountofCalories.Name = "lblAmountofCalories";
            this.lblAmountofCalories.Size = new System.Drawing.Size(120, 20);
            this.lblAmountofCalories.TabIndex = 17;
            this.lblAmountofCalories.Text = "Calorie Amount :";
            // 
            // grpFoodAdd
            // 
            this.grpFoodAdd.Controls.Add(this.cmbChooseYourMeals);
            this.grpFoodAdd.Controls.Add(this.lblAmountofCalories);
            this.grpFoodAdd.Controls.Add(this.lblChooseYourMeal);
            this.grpFoodAdd.Controls.Add(this.lblCaloriValue);
            this.grpFoodAdd.Controls.Add(this.lblFoodCategory);
            this.grpFoodAdd.Controls.Add(this.btnListBoxDelete);
            this.grpFoodAdd.Controls.Add(this.cmbFoodCategory);
            this.grpFoodAdd.Controls.Add(this.btnListBoxAdd);
            this.grpFoodAdd.Controls.Add(this.lblFoods);
            this.grpFoodAdd.Controls.Add(this.lstbFoodName);
            this.grpFoodAdd.Controls.Add(this.btnAddYourOwnFood);
            this.grpFoodAdd.Controls.Add(this.lstbAllFoodName);
            this.grpFoodAdd.Location = new System.Drawing.Point(18, 248);
            this.grpFoodAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoodAdd.Name = "grpFoodAdd";
            this.grpFoodAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoodAdd.Size = new System.Drawing.Size(633, 363);
            this.grpFoodAdd.TabIndex = 18;
            this.grpFoodAdd.TabStop = false;
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(411, 616);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(238, 72);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Food Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvFoodAdd
            // 
            this.dgvFoodAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodAdd.Location = new System.Drawing.Point(670, 260);
            this.dgvFoodAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFoodAdd.Name = "dgvFoodAdd";
            this.dgvFoodAdd.RowHeadersWidth = 51;
            this.dgvFoodAdd.RowTemplate.Height = 25;
            this.dgvFoodAdd.Size = new System.Drawing.Size(414, 351);
            this.dgvFoodAdd.TabIndex = 19;
            // 
            // frmFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 776);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvFoodAdd);
            this.Controls.Add(this.grpFoodAdd);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnBacktoUserForm);
            this.Controls.Add(this.pctbPicture);
            this.Controls.Add(this.mntcldrCalender);
            this.Name = "frmFoodAdd";
            this.Text = "FoodAddForm";
            this.Load += new System.EventHandler(this.FoodAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbPicture)).EndInit();
            this.grpFoodAdd.ResumeLayout(false);
            this.grpFoodAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar mntcldrCalender;
        private PictureBox pctbPicture;
        private Label lblChooseYourMeal;
        private ComboBox cmbChooseYourMeals;
        private Label lblFoodCategory;
        private ComboBox cmbFoodCategory;
        private Label lblFoods;
        private Button btnAddYourOwnFood;
        private Button btnBacktoUserForm;
        private Button btnAddFood;
        private ListBox lstbAllFoodName;
        private ListBox lstbFoodName;
        private Button btnListBoxAdd;
        private Button btnListBoxDelete;
        private Label lblCaloriValue;
        private Label lblAmountofCalories;
        private GroupBox grpFoodAdd;
        private Button btnUpdate;
        private DataGridView dgvFoodAdd;
    }
}