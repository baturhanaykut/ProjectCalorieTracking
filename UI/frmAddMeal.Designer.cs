namespace UI
{
    partial class frmAddMeal
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblPorsion = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtCalorie = new System.Windows.Forms.TextBox();
            this.cmbPorsion = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPictureAdd = new System.Windows.Forms.Button();
            this.grpFoodAdd = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.grpFoodAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoodName.Location = new System.Drawing.Point(37, 83);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(98, 20);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food Name :";
            // 
            // lblPorsion
            // 
            this.lblPorsion.AutoSize = true;
            this.lblPorsion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorsion.Location = new System.Drawing.Point(66, 128);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(70, 20);
            this.lblPorsion.TabIndex = 1;
            this.lblPorsion.Text = "Porsion :";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalorie.Location = new System.Drawing.Point(70, 184);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(65, 20);
            this.lblCalorie.TabIndex = 2;
            this.lblCalorie.Text = "Calorie :";
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagePath.Location = new System.Drawing.Point(42, 240);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(93, 20);
            this.lblImagePath.TabIndex = 3;
            this.lblImagePath.Text = "Image Path:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(158, 83);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(233, 27);
            this.txtFoodName.TabIndex = 4;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(158, 237);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(118, 27);
            this.txtImagePath.TabIndex = 5;
            // 
            // txtCalorie
            // 
            this.txtCalorie.Location = new System.Drawing.Point(158, 184);
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.Size = new System.Drawing.Size(233, 27);
            this.txtCalorie.TabIndex = 6;
            this.txtCalorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalorie_KeyPress);
            // 
            // cmbPorsion
            // 
            this.cmbPorsion.FormattingEnabled = true;
            this.cmbPorsion.Location = new System.Drawing.Point(158, 128);
            this.cmbPorsion.Name = "cmbPorsion";
            this.cmbPorsion.Size = new System.Drawing.Size(233, 28);
            this.cmbPorsion.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(27, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 83);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(286, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 83);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPictureAdd.Location = new System.Drawing.Point(296, 240);
            this.btnPictureAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.Size = new System.Drawing.Size(95, 31);
            this.btnPictureAdd.TabIndex = 10;
            this.btnPictureAdd.Text = "Picture Add";
            this.btnPictureAdd.UseVisualStyleBackColor = true;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // grpFoodAdd
            // 
            this.grpFoodAdd.Controls.Add(this.lblFoodName);
            this.grpFoodAdd.Controls.Add(this.btnPictureAdd);
            this.grpFoodAdd.Controls.Add(this.lblCategory);
            this.grpFoodAdd.Controls.Add(this.lblPorsion);
            this.grpFoodAdd.Controls.Add(this.lblCalorie);
            this.grpFoodAdd.Controls.Add(this.lblImagePath);
            this.grpFoodAdd.Controls.Add(this.cmbBoxCategory);
            this.grpFoodAdd.Controls.Add(this.cmbPorsion);
            this.grpFoodAdd.Controls.Add(this.txtFoodName);
            this.grpFoodAdd.Controls.Add(this.txtCalorie);
            this.grpFoodAdd.Controls.Add(this.txtImagePath);
            this.grpFoodAdd.Location = new System.Drawing.Point(27, 16);
            this.grpFoodAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoodAdd.Name = "grpFoodAdd";
            this.grpFoodAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoodAdd.Size = new System.Drawing.Size(421, 316);
            this.grpFoodAdd.TabIndex = 11;
            this.grpFoodAdd.TabStop = false;
            this.grpFoodAdd.Text = "Food Add";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(54, 37);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category :";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(158, 37);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(233, 28);
            this.cmbBoxCategory.TabIndex = 7;
            // 
            // frmAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 529);
            this.Controls.Add(this.grpFoodAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAddMeal";
            this.Text = "AddMealForm";
            this.Load += new System.EventHandler(this.AddMealForm_Load);
            this.grpFoodAdd.ResumeLayout(false);
            this.grpFoodAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblFoodName;
        private Label lblPorsion;
        private Label lblCalorie;
        private Label lblImagePath;
        private TextBox txtFoodName;
        private TextBox txtImagePath;
        private TextBox txtCalorie;
        private ComboBox cmbPorsion;
        private Button btnBack;
        private Button btnAdd;
        private Button btnPictureAdd;
        private GroupBox grpFoodAdd;
        private Label lblCategory;
        private ComboBox cmbBoxCategory;
    }
}