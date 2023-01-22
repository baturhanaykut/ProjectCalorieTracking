﻿namespace UI
{
    partial class frmFoodUpdate
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
            this.dgvFoodUpdate = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.dtpFoodUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.lstbFoodList = new System.Windows.Forms.ListBox();
            this.lstbEatsFood = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCurrentCalorie = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoodUpdate
            // 
            this.dgvFoodUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodUpdate.Location = new System.Drawing.Point(12, 41);
            this.dgvFoodUpdate.Name = "dgvFoodUpdate";
            this.dgvFoodUpdate.RowTemplate.Height = 25;
            this.dgvFoodUpdate.Size = new System.Drawing.Size(367, 105);
            this.dgvFoodUpdate.TabIndex = 0;
            this.dgvFoodUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodUpdate_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(136, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 26);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "<- Food Delete";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(12, 152);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(145, 23);
            this.cmbFoodCategory.TabIndex = 2;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged);
            // 
            // dtpFoodUpdate
            // 
            this.dtpFoodUpdate.Location = new System.Drawing.Point(12, 12);
            this.dtpFoodUpdate.Name = "dtpFoodUpdate";
            this.dtpFoodUpdate.Size = new System.Drawing.Size(200, 23);
            this.dtpFoodUpdate.TabIndex = 3;
            this.dtpFoodUpdate.ValueChanged += new System.EventHandler(this.dtpFoodUpdate_ValueChanged);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Location = new System.Drawing.Point(266, 385);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(113, 49);
            this.btnGeriDön.TabIndex = 4;
            this.btnGeriDön.Text = "GeriDön";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // lstbFoodList
            // 
            this.lstbFoodList.FormattingEnabled = true;
            this.lstbFoodList.ItemHeight = 15;
            this.lstbFoodList.Location = new System.Drawing.Point(12, 181);
            this.lstbFoodList.Name = "lstbFoodList";
            this.lstbFoodList.Size = new System.Drawing.Size(118, 109);
            this.lstbFoodList.TabIndex = 5;
            // 
            // lstbEatsFood
            // 
            this.lstbEatsFood.CausesValidation = false;
            this.lstbEatsFood.FormattingEnabled = true;
            this.lstbEatsFood.ItemHeight = 15;
            this.lstbEatsFood.Location = new System.Drawing.Point(266, 181);
            this.lstbEatsFood.MultiColumn = true;
            this.lstbEatsFood.Name = "lstbEatsFood";
            this.lstbEatsFood.Size = new System.Drawing.Size(113, 109);
            this.lstbEatsFood.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(136, 205);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(124, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Food Add ->";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(367, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 356);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(367, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Meal Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCurrentCalorie
            // 
            this.lblCurrentCalorie.AutoSize = true;
            this.lblCurrentCalorie.Location = new System.Drawing.Point(173, 309);
            this.lblCurrentCalorie.Name = "lblCurrentCalorie";
            this.lblCurrentCalorie.Size = new System.Drawing.Size(87, 15);
            this.lblCurrentCalorie.TabIndex = 9;
            this.lblCurrentCalorie.Text = "Current Calorie";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(266, 309);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(13, 15);
            this.lblCalorie.TabIndex = 10;
            this.lblCalorie.Text = "0";
            // 
            // frmFoodUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 446);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.lblCurrentCalorie);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstbEatsFood);
            this.Controls.Add(this.lstbFoodList);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.dtpFoodUpdate);
            this.Controls.Add(this.cmbFoodCategory);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvFoodUpdate);
            this.Name = "frmFoodUpdate";
            this.Text = "frmFoodUpdate";
            this.Load += new System.EventHandler(this.frmFoodUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSil;
        private ComboBox cmbFoodCategory;
        private DateTimePicker dateTimePicker1;
        private Button btnGeriDön;
        private ListBox lstbFoodList;
        private ListBox lstbEatsFood;
        private Button btnEkle;
        private DataGridView dgvFoodUpdate;
        private DateTimePicker dtpFoodUpdate;
        private Button btnUpdate;
        private Button btnRemove;
        private Label lblCurrentCalorie;
        private Label lblCalorie;
    }
}