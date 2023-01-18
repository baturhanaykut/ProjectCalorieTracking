using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;

namespace UI
{
    public partial class UserRegistrationScreenForm : Form
    {
        CalorieTrackingContext context;
        public UserRegistrationScreenForm()
        {
            InitializeComponent();
        }

        private void UserRegistrationScreenForm_Load(object sender, EventArgs e)
        {
           Methods.ComboBoxDoldur(cmbGender);
          
        }

        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
           User user = new User();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("İsim alanı boş bırakılamaz");
            }
            else
            {
               user.UserName = txtName.Text.Trim().ToUpper();
               
               // To Do : Replace() metodu yazılacak.
            }

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Soyisim alanı boş bırakılamaz");
            }
            else
            {
                user.UserSurname = txtSurname.Text.Trim().ToUpper();

                // To Do : Replace() metodu yazılacak.
            }

            if (cmbGender.SelectedIndex ==-1)
            {
                MessageBox.Show("Lütfen Cinsiteyi Seçiniz");
            }
            else
            {
                user.UserGender = (Entities.Enums.Gender)cmbGender.SelectedItem;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Mail Alanı Boş Bırakılamaz");
            }
            else
            {
                user.UserMail = txtEmail.Text.Trim();
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Şifre Alanı Boş Bırakılamaz");
            }
            else
            {
                user.UserPassword = txtPassword.Text.Trim();
            }

            if (dtpDateofBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Doğumtarihiniz bugün olamaz");
            }
            else
            {
                user.UserBirthDate = dtpDateofBirth.Value;
            }

            user.UserWeight = nmrcWeight.Value;
            user.UserHeight = nmrcHeight.Value;

            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Kullanıcı Başarılı ile kaydedildi");
            this.Close();

        }

       
    }
}
