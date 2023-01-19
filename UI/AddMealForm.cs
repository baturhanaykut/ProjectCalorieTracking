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
using Entities.Enums;

namespace UI
{
    public partial class AddMealForm : Form
    {
        public AddMealForm()
        {
            InitializeComponent();
        }

        CalorieTrackingContext context;
        Food food;
        FoodAddForm _frm;
        private void AddMealForm_Load(object sender, EventArgs e)
        {
            _frm = new FoodAddForm();
            context = new CalorieTrackingContext();
            food = new Food();
            ComboBoxDoldur();
        }

        private void ComboBoxDoldur()
        {
            cmbPorsion.DataSource = Enum.GetNames(typeof(Porsion)).ToList();
            cmbPorsion.SelectedIndex = -1;
            cmbBoxCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Category

            if (cmbBoxCategory.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Kategori Seçimi Yapınız");
                return;
            }
            else
            {
                food.CategoryId=context.Categories.FirstOrDefault(c=>c.CategoryName == cmbBoxCategory.Text).CategoryID;
            }

            #endregion

            #region FoodName

            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Lütfen yemek ismini giriniz");
            }
            else
            {
                food.FoodName = txtFoodName.Text;
            }
            #endregion

            #region Porsion
            if (cmbPorsion.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Porsiyon Seçimi Yapınız");
                return;
            }
            else
            {
                if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Piece)
                {
                    food.Porsion = Porsion.Piece;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Gram)
                {
                    food.Porsion = Porsion.Gram;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Slice)
                {
                    food.Porsion = Porsion.Slice;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Millilitre)
                {
                    food.Porsion = Porsion.Millilitre;
                }
            }
            #endregion

            #region Calori

            if (string.IsNullOrEmpty((txtCalorie.Text)))
            {
                MessageBox.Show("Calori Değerini Lütfen Giriniz");
                return;
            }
            else
            {
                food.Calorie = Convert.ToDecimal(txtCalorie.Text);
            }

            #endregion


            #region FoodPhoto
            if (food.ImagePath == null)
            {
                MessageBox.Show("Please add picture");
            }
            #endregion

            #region DatabaseConnect
            context.Foods.Add(food);
            context.SaveChanges();
            MessageBox.Show("Yemek başarılı ile kaydedil");

            ButtonClear();

            #endregion
        }

        private void ButtonClear()
        {
            foreach (Control item in grpFoodAdd.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                
            }


        }

        private void txtCalorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sayı harici giriş yapmayı engelle

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen bir fotograf seçiniz";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                food.ImagePath = ofd.FileName;
                txtImagePath.Text = food.ImagePath;
            }
            else
            {
                MessageBox.Show("Fotograf Seçilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }
    }

}
