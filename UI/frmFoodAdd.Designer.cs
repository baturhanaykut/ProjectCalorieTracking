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
            this.lblChooseYourMeals = new System.Windows.Forms.Label();
            this.cmbChooseYourMeals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lblFoods = new System.Windows.Forms.Label();
            this.btnAddYourOwnFood = new System.Windows.Forms.Button();
            this.btnBacktoUserForm = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstbAllFoodName = new System.Windows.Forms.ListBox();
            this.lstbFoodName = new System.Windows.Forms.ListBox();
            this.btnLsitBoxEkle = new System.Windows.Forms.Button();
            this.btnListBoxSil = new System.Windows.Forms.Button();
            this.lblCaloriGoster = new System.Windows.Forms.Label();
            this.lblAlınanCaloriMiktarı = new System.Windows.Forms.Label();
            this.grpFoodAdd = new System.Windows.Forms.GroupBox();
            this.dgvFoodAdd = new System.Windows.Forms.DataGridView();
            this.bntUpdtae = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPicture)).BeginInit();
            this.grpFoodAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // mntcldrCalender
            // 
            this.mntcldrCalender.Location = new System.Drawing.Point(16, 14);
            this.mntcldrCalender.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mntcldrCalender.MaxSelectionCount = 1;
            this.mntcldrCalender.Name = "mntcldrCalender";
            this.mntcldrCalender.TabIndex = 0;
            this.mntcldrCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntcldrCalender_DateChanged);
            // 
            // pctbPicture
            // 
            this.pctbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pctbPicture.Image")));
            this.pctbPicture.Location = new System.Drawing.Point(256, 14);
            this.pctbPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbPicture.Name = "pctbPicture";
            this.pctbPicture.Size = new System.Drawing.Size(755, 162);
            this.pctbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPicture.TabIndex = 1;
            this.pctbPicture.TabStop = false;
            // 
            // lblChooseYourMeals
            // 
            this.lblChooseYourMeals.AutoSize = true;
            this.lblChooseYourMeals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseYourMeals.Location = new System.Drawing.Point(15, 29);
            this.lblChooseYourMeals.Name = "lblChooseYourMeals";
            this.lblChooseYourMeals.Size = new System.Drawing.Size(116, 15);
            this.lblChooseYourMeals.TabIndex = 2;
            this.lblChooseYourMeals.Text = "Choose Your Meals :";
            // 
            // cmbChooseYourMeals
            // 
            this.cmbChooseYourMeals.FormattingEnabled = true;
            this.cmbChooseYourMeals.Location = new System.Drawing.Point(147, 21);
            this.cmbChooseYourMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseYourMeals.Name = "cmbChooseYourMeals";
            this.cmbChooseYourMeals.Size = new System.Drawing.Size(160, 23);
            this.cmbChooseYourMeals.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food Category :";
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(147, 60);
            this.cmbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(160, 23);
            this.cmbFoodCategory.TabIndex = 5;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged);
            // 
            // lblFoods
            // 
            this.lblFoods.AutoSize = true;
            this.lblFoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoods.Location = new System.Drawing.Point(86, 101);
            this.lblFoods.Name = "lblFoods";
            this.lblFoods.Size = new System.Drawing.Size(45, 15);
            this.lblFoods.TabIndex = 7;
            this.lblFoods.Text = "Foods :";
            // 
            // btnAddYourOwnFood
            // 
            this.btnAddYourOwnFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddYourOwnFood.Location = new System.Drawing.Point(377, 59);
            this.btnAddYourOwnFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddYourOwnFood.Name = "btnAddYourOwnFood";
            this.btnAddYourOwnFood.Size = new System.Drawing.Size(148, 23);
            this.btnAddYourOwnFood.TabIndex = 11;
            this.btnAddYourOwnFood.Text = "Add Your Own Food";
            this.btnAddYourOwnFood.UseVisualStyleBackColor = true;
            this.btnAddYourOwnFood.Click += new System.EventHandler(this.btnAddYourOwnFood_Click);
            // 
            // btnBacktoUserForm
            // 
            this.btnBacktoUserForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoUserForm.Location = new System.Drawing.Point(370, 475);
            this.btnBacktoUserForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBacktoUserForm.Name = "btnBacktoUserForm";
            this.btnBacktoUserForm.Size = new System.Drawing.Size(229, 54);
            this.btnBacktoUserForm.TabIndex = 12;
            this.btnBacktoUserForm.Text = "Back to User Form";
            this.btnBacktoUserForm.UseVisualStyleBackColor = true;
            this.btnBacktoUserForm.Click += new System.EventHandler(this.btnBacktoUserForm_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(71, 475);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(229, 54);
            this.btnAddFood.TabIndex = 13;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstbAllFoodName
            // 
            this.lstbAllFoodName.FormattingEnabled = true;
            this.lstbAllFoodName.ItemHeight = 15;
            this.lstbAllFoodName.Location = new System.Drawing.Point(147, 103);
            this.lstbAllFoodName.MultiColumn = true;
            this.lstbAllFoodName.Name = "lstbAllFoodName";
            this.lstbAllFoodName.Size = new System.Drawing.Size(162, 124);
            this.lstbAllFoodName.TabIndex = 14;
            // 
            // lstbFoodName
            // 
            this.lstbFoodName.FormattingEnabled = true;
            this.lstbFoodName.ItemHeight = 15;
            this.lstbFoodName.Location = new System.Drawing.Point(421, 101);
            this.lstbFoodName.Name = "lstbFoodName";
            this.lstbFoodName.Size = new System.Drawing.Size(162, 124);
            this.lstbFoodName.TabIndex = 15;
            // 
            // btnLsitBoxEkle
            // 
            this.btnLsitBoxEkle.Location = new System.Drawing.Point(330, 128);
            this.btnLsitBoxEkle.Name = "btnLsitBoxEkle";
            this.btnLsitBoxEkle.Size = new System.Drawing.Size(75, 23);
            this.btnLsitBoxEkle.TabIndex = 16;
            this.btnLsitBoxEkle.Text = "-->";
            this.btnLsitBoxEkle.UseVisualStyleBackColor = true;
            this.btnLsitBoxEkle.Click += new System.EventHandler(this.btnLsitBoxEkle_Click);
            // 
            // btnListBoxSil
            // 
            this.btnListBoxSil.Location = new System.Drawing.Point(330, 172);
            this.btnListBoxSil.Name = "btnListBoxSil";
            this.btnListBoxSil.Size = new System.Drawing.Size(75, 23);
            this.btnListBoxSil.TabIndex = 16;
            this.btnListBoxSil.Text = "<--";
            this.btnListBoxSil.UseVisualStyleBackColor = true;
            this.btnListBoxSil.Click += new System.EventHandler(this.btnListBoxSil_Click);
            // 
            // lblCaloriGoster
            // 
            this.lblCaloriGoster.AutoSize = true;
            this.lblCaloriGoster.Location = new System.Drawing.Point(511, 227);
            this.lblCaloriGoster.Name = "lblCaloriGoster";
            this.lblCaloriGoster.Size = new System.Drawing.Size(0, 15);
            this.lblCaloriGoster.TabIndex = 17;
            // 
            // lblAlınanCaloriMiktarı
            // 
            this.lblAlınanCaloriMiktarı.AutoSize = true;
            this.lblAlınanCaloriMiktarı.Location = new System.Drawing.Point(421, 227);
            this.lblAlınanCaloriMiktarı.Name = "lblAlınanCaloriMiktarı";
            this.lblAlınanCaloriMiktarı.Size = new System.Drawing.Size(84, 15);
            this.lblAlınanCaloriMiktarı.TabIndex = 17;
            this.lblAlınanCaloriMiktarı.Text = "Calori Miktarı :";
            // 
            // grpFoodAdd
            // 
            this.grpFoodAdd.Controls.Add(this.cmbChooseYourMeals);
            this.grpFoodAdd.Controls.Add(this.lblAlınanCaloriMiktarı);
            this.grpFoodAdd.Controls.Add(this.lblChooseYourMeals);
            this.grpFoodAdd.Controls.Add(this.lblCaloriGoster);
            this.grpFoodAdd.Controls.Add(this.label1);
            this.grpFoodAdd.Controls.Add(this.btnListBoxSil);
            this.grpFoodAdd.Controls.Add(this.cmbFoodCategory);
            this.grpFoodAdd.Controls.Add(this.btnLsitBoxEkle);
            this.grpFoodAdd.Controls.Add(this.lblFoods);
            this.grpFoodAdd.Controls.Add(this.lstbFoodName);
            this.grpFoodAdd.Controls.Add(this.btnAddYourOwnFood);
            this.grpFoodAdd.Controls.Add(this.lstbAllFoodName);
            this.grpFoodAdd.Location = new System.Drawing.Point(16, 186);
            this.grpFoodAdd.Name = "grpFoodAdd";
            this.grpFoodAdd.Size = new System.Drawing.Size(613, 272);
            this.grpFoodAdd.TabIndex = 18;
            this.grpFoodAdd.TabStop = false;
            // 
            // dgvFoodAdd
            // 
            this.dgvFoodAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodAdd.Location = new System.Drawing.Point(649, 196);
            this.dgvFoodAdd.Name = "dgvFoodAdd";
            this.dgvFoodAdd.RowTemplate.Height = 25;
            this.dgvFoodAdd.Size = new System.Drawing.Size(362, 262);
            this.dgvFoodAdd.TabIndex = 19;
            this.dgvFoodAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodAdd_CellClick);
            // 
            // bntUpdtae
            // 
            this.bntUpdtae.Location = new System.Drawing.Point(649, 475);
            this.bntUpdtae.Name = "bntUpdtae";
            this.bntUpdtae.Size = new System.Drawing.Size(139, 54);
            this.bntUpdtae.TabIndex = 20;
            this.bntUpdtae.Text = "Food Update";
            this.bntUpdtae.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(892, 475);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 54);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Food Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // frmFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 582);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.bntUpdtae);
            this.Controls.Add(this.dgvFoodAdd);
            this.Controls.Add(this.grpFoodAdd);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnBacktoUserForm);
            this.Controls.Add(this.pctbPicture);
            this.Controls.Add(this.mntcldrCalender);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Label lblChooseYourMeals;
        private ComboBox cmbChooseYourMeals;
        private Label label1;
        private ComboBox cmbFoodCategory;
        private Label lblFoods;
        private Button btnAddYourOwnFood;
        private Button btnBacktoUserForm;
        private Button btnAddFood;
        private ListBox lstbAllFoodName;
        private ListBox lstbFoodName;
        private Button btnLsitBoxEkle;
        private Button btnListBoxSil;
        private Label lblCaloriGoster;
        private Label lblAlınanCaloriMiktarı;
        private GroupBox grpFoodAdd;
        private DataGridView dgvFoodAdd;
        private Button bntUpdtae;
        private Button btnRemove;
    }
}