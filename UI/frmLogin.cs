using DAL.Context;
using Entities.Entity;

namespace UI;

public partial class frmLogin : Form
{
    CalorieTrackingContext context;
    public User _user;
    frmUserProfile _userProfileForm;



    public frmLogin()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        context = new CalorieTrackingContext();
        _user = new User();
        //_profileForm = new UserProfileForm();

    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
        _user = context.Users.FirstOrDefault(u => u.UserMail == txtEmail.Text && u.UserPassword == txtPassword.Text);
        if (_user == null)
        {
            MessageBox.Show("Username or password is incorrect");
            txtEmail.Clear();
            txtPassword.Clear();
            return;
        }
        else
        {
            _userProfileForm = new frmUserProfile(_user);
            //_userProfileForm._userProfile = _user;
            this.Hide();
            _userProfileForm.Show();


        }

    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        frmUserRegistration userRegistrationScreenForm = new frmUserRegistration();
        userRegistrationScreenForm.ShowDialog();
    }

}
