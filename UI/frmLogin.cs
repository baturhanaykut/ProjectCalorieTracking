using DAL.Context;
using Entities.Entity;

namespace UI;

public partial class frmLogin : Form
{
    CalorieTrackingContext context;
    //User _user;
    //frmUserProfile _userProfileForm;



    public frmLogin()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        context = new CalorieTrackingContext();
        //_user = new User();
        //_profileForm = new UserProfileForm();

    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
        User user = context.Users.FirstOrDefault(u => u.UserMail == txtEmail.Text && u.UserPassword == txtPassword.Text);
        if (user == null)
        {
            MessageBox.Show("Username or password is incorrect");
            txtEmail.Clear();
            txtPassword.Clear();
            return;
        }
        else
        {
            frmUserProfile frm = new frmUserProfile(user);
            this.Hide();
            frm.Show();
        }

    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        frmUserRegistration userRegistrationScreenForm = new frmUserRegistration();
        userRegistrationScreenForm.ShowDialog();
    }

}
