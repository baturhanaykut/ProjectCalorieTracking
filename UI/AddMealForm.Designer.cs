namespace UI
{
    partial class AddMealForm
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
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoodName.Location = new System.Drawing.Point(23, 48);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(98, 20);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food Name :";
            // 
            // lblPorsion
            // 
            this.lblPorsion.AutoSize = true;
            this.lblPorsion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorsion.Location = new System.Drawing.Point(51, 103);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(70, 20);
            this.lblPorsion.TabIndex = 1;
            this.lblPorsion.Text = "Porsion :";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalorie.Location = new System.Drawing.Point(56, 159);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(65, 20);
            this.lblCalorie.TabIndex = 2;
            this.lblCalorie.Text = "Calorie :";
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagePath.Location = new System.Drawing.Point(28, 215);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(93, 20);
            this.lblImagePath.TabIndex = 3;
            this.lblImagePath.Text = "Image Path:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(156, 48);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(224, 27);
            this.txtFoodName.TabIndex = 4;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(156, 212);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(224, 27);
            this.txtImagePath.TabIndex = 5;
            // 
            // txtCalorie
            // 
            this.txtCalorie.Location = new System.Drawing.Point(156, 159);
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.Size = new System.Drawing.Size(224, 27);
            this.txtCalorie.TabIndex = 6;
            // 
            // cmbPorsion
            // 
            this.cmbPorsion.FormattingEnabled = true;
            this.cmbPorsion.Location = new System.Drawing.Point(156, 103);
            this.cmbPorsion.Name = "cmbPorsion";
            this.cmbPorsion.Size = new System.Drawing.Size(224, 28);
            this.cmbPorsion.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(28, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 83);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(255, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 83);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 464);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbPorsion);
            this.Controls.Add(this.txtCalorie);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.lblPorsion);
            this.Controls.Add(this.lblFoodName);
            this.Name = "AddMealForm";
            this.Text = "AddMealForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}