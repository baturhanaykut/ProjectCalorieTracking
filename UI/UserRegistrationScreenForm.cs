using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;
using Entities.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using User = Entities.Entity.User;

namespace UI
{
    public partial class UserRegistrationScreenForm : Form
    {
        CalorieTrackingContext context;
        User user;
        bool passwordIsTrue = false;
       
        public UserRegistrationScreenForm()
        {
            InitializeComponent();
        }

        private void UserRegistrationScreenForm_Load(object sender, EventArgs e)
        {
            user = new User();
            context = new CalorieTrackingContext();
            ComboBoxDoldur();
        }

        private void ComboBoxDoldur()
        {
            cmbGender.DataSource = Enum.GetNames(typeof(Gender)).ToList();
            cmbGender.SelectedIndex = -1;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //user = new User();

            #region Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("İsim alanı boş bırakılamaz");
                return;
            }
            else
            {
                string userName = txtName.Text.Trim().ToUpper();
                string userNameReplace = userName.Replace("İĞÜŞÖÇ", "IGUSOC");
                user.UserName = userNameReplace;

                // To Do : Replace() metodu yazılacak.
            }

            #endregion
            #region Surname
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Soyisim alanı boş bırakılamaz");
                return;
            }
            else
            {
                string surname = txtSurname.Text.ToUpper().Trim();
                string surnameReplace = surname.Replace("İĞÜŞÖÇ" ,"IGUSOC");
                user.UserSurname = surnameReplace;

                // To Do : Replace() metodu yazılacak.
            }
            #endregion
            #region Gender
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Cinsiteyi Seçiniz");
                return;
            }
            else
            {

                if ((Entities.Enums.Gender)cmbGender.SelectedIndex == 0)
                {
                    user.UserGender = Gender.Man;
                }
                else if ((Entities.Enums.Gender)cmbGender.SelectedIndex == (Gender)1)
                {
                    user.UserGender = Gender.Women;
                }
                else if ((Entities.Enums.Gender)cmbGender.SelectedIndex == (Gender)2)
                {
                    user.UserGender = Gender.Unspecified;
                }
            }


            #endregion
            #region Mail
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Mail Alanı Boş Bırakılamaz");
                return;
            }
            else
            {
                user.UserMail = txtEmail.Text.Trim();
            }
            #endregion
            #region Password
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty((txtConfirmPassword.Text)))
            {
                MessageBox.Show("Şifre Alanı Boş Bırakılamaz");
                return;
            }
            else if (passwordIsTrue == true)
            {
                user.UserPassword = txtPassword.Text.Trim();
                
            }
            #endregion
            #region BirthDay
            if (dtpDateofBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Doğumtarihiniz bugün olamaz");
                return;
            }
            else
            {
                user.UserBirthDate = dtpDateofBirth.Value;
            }
            #endregion
            #region Weight
            user.UserWeight = nmrcWeight.Value;


            #endregion
            #region Height
            user.UserHeight = nmrcHeight.Value;
            #endregion
            #region EmailChech

            foreach (var email in context.Users)
            {
                if (email.UserMail == user.UserMail)
                {
                    MessageBox.Show("User Mail Registered.");
                    return;
                }
            }
            #endregion
            #region PhotoControl

            if (user.PhotoPath == null)
            {
                MessageBox.Show("Please add picture");
                return;
            }

            #endregion
            #region DataBaseConnect
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Kullanıcı Başarılı ile kaydedildi");
            this.Close();
            #endregion

        }

        #region PictureBoxAdd
        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen bir fotoğraf seçiniz.";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxUserPhoto.ImageLocation = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Fotoğraf seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //save photopath to database
            string photoPath = pbxUserPhoto.ImageLocation;
            user.PhotoPath = photoPath;
        }

        #endregion
        #region PasswordCheck

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassLen.ForeColor = Color.LightGray;
            lblPassLow.ForeColor = Color.LightGray;
            lblPassNum.ForeColor = Color.LightGray;
            lblPassSpec.ForeColor = Color.LightGray;
            lblPassUp.ForeColor = Color.LightGray;

            //txtPassword.PasswordChar = '*';
            string password = txtPassword.Text.Trim();
            string numbers = "0123456789";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string specialCharacters = "!'£^#+$%&/*?\\-_|@~¨´,;.:`";



            if (password.Length < 6 || password.Length > 8)
            {
                lblPassLen.ForeColor = Color.Red;

            }
            else
            {
                lblPassLen.ForeColor = Color.Green;
                passwordIsTrue2 = true;
            }

            foreach (var item in password.Distinct())
            {


                if (lowerCase.Contains(item))
                {
                    lblPassLow.ForeColor = Color.Green;
                }
                else if (upperCase.Contains(item))
                {
                    lblPassUp.ForeColor = Color.Green;
                }
                else if (numbers.Contains(item))
                {
                    lblPassNum.ForeColor = Color.Green;
                }
                else if (specialCharacters.Contains(item))
                {
                    lblPassSpec.ForeColor = Color.Green;
                }
                else
                {
                    lblPassUp.ForeColor = Color.Red;
                    lblPassNum.ForeColor = Color.Red;
                    lblPassLow.ForeColor = Color.Red;
                    lblPassSpec.ForeColor = Color.Red;
                }
               
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordCheck();
        }

        private void PasswordCheck()
        {
            if (txtPassword.Text == null)
            {
                lblPasswordControl.Visible = false;
            }
            else
            {
                //txtPassword.PasswordChar = '*';
                string paswordCheck = txtConfirmPassword.Text.Trim();
                if (txtPassword.Text.Trim() != paswordCheck)
                {
                    lblPasswordControl.ForeColor = Color.Red;
                    lblPasswordControl.Text = "Your password is not matched";
                    lblPasswordControl.Visible = true;
                    passwordIsTrue = false;
                }
                else
                {
                    lblPasswordControl.ForeColor = Color.Green;
                    lblPasswordControl.Text = "Your password  is matched";
                    lblPasswordControl.Visible = true;
                    passwordIsTrue = true;
                }
            }
        }

        #endregion


    }
}
