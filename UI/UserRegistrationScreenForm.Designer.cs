namespace UI
{
    partial class UserRegistrationScreenForm
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
            this.grpbUserRegistration = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.nmrcHeight = new System.Windows.Forms.NumericUpDown();
            this.nmrcWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpbUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbUserRegistration
            // 
            this.grpbUserRegistration.Controls.Add(this.lblHeight);
            this.grpbUserRegistration.Controls.Add(this.lblWeight);
            this.grpbUserRegistration.Controls.Add(this.dtpDateofBirth);
            this.grpbUserRegistration.Controls.Add(this.nmrcWeight);
            this.grpbUserRegistration.Controls.Add(this.nmrcHeight);
            this.grpbUserRegistration.Controls.Add(this.lblDateOfBirth);
            this.grpbUserRegistration.Controls.Add(this.txtConfirmPassword);
            this.grpbUserRegistration.Controls.Add(this.lblConfirmPassword);
            this.grpbUserRegistration.Controls.Add(this.label5);
            this.grpbUserRegistration.Controls.Add(this.label4);
            this.grpbUserRegistration.Controls.Add(this.label3);
            this.grpbUserRegistration.Controls.Add(this.label2);
            this.grpbUserRegistration.Controls.Add(this.label1);
            this.grpbUserRegistration.Controls.Add(this.txtPassword);
            this.grpbUserRegistration.Controls.Add(this.lblPassword);
            this.grpbUserRegistration.Controls.Add(this.txtEmail);
            this.grpbUserRegistration.Controls.Add(this.lblEmail);
            this.grpbUserRegistration.Controls.Add(this.cmbGender);
            this.grpbUserRegistration.Controls.Add(this.lblGender);
            this.grpbUserRegistration.Controls.Add(this.txtSurname);
            this.grpbUserRegistration.Controls.Add(this.lblSurname);
            this.grpbUserRegistration.Controls.Add(this.txtName);
            this.grpbUserRegistration.Controls.Add(this.lblName);
            this.grpbUserRegistration.Location = new System.Drawing.Point(12, 12);
            this.grpbUserRegistration.Name = "grpbUserRegistration";
            this.grpbUserRegistration.Size = new System.Drawing.Size(443, 633);
            this.grpbUserRegistration.TabIndex = 0;
            this.grpbUserRegistration.TabStop = false;
            this.grpbUserRegistration.Text = "User Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(92, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(157, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(236, 27);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(72, 83);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(83, 136);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender :";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(157, 133);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(236, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(96, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 237);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(67, 240);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(157, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(157, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(157, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(157, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(157, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(157, 414);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(236, 27);
            this.txtConfirmPassword.TabIndex = 16;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.Location = new System.Drawing.Point(6, 417);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(145, 20);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(43, 473);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(108, 20);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth :";
            // 
            // nmrcHeight
            // 
            this.nmrcHeight.Location = new System.Drawing.Point(157, 578);
            this.nmrcHeight.Name = "nmrcHeight";
            this.nmrcHeight.Size = new System.Drawing.Size(236, 27);
            this.nmrcHeight.TabIndex = 1;
            // 
            // nmrcWeight
            // 
            this.nmrcWeight.Location = new System.Drawing.Point(157, 524);
            this.nmrcWeight.Name = "nmrcWeight";
            this.nmrcWeight.Size = new System.Drawing.Size(236, 27);
            this.nmrcWeight.TabIndex = 1;
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Location = new System.Drawing.Point(157, 468);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(236, 27);
            this.dtpDateofBirth.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(83, 526);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(68, 20);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight :";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(87, 651);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(289, 53);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(87, 580);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(64, 20);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height :";
            // 
            // UserRegistrationScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 716);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.grpbUserRegistration);
            this.Name = "UserRegistrationScreenForm";
            this.Text = "UserRegistrationScreenForm";
            this.grpbUserRegistration.ResumeLayout(false);
            this.grpbUserRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpbUserRegistration;
        private Label lblName;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtName;
        private Label lblGender;
        private DateTimePicker dtpDateofBirth;
        private NumericUpDown nmrcWeight;
        private NumericUpDown nmrcHeight;
        private Label lblDateOfBirth;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cmbGender;
        private Label lblHeight;
        private Label lblWeight;
        private Button btnSignUp;
    }
}