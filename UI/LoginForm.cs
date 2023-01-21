using DAL.Context;
using Entities.Entity;

namespace UI;

public partial class LoginForm : Form
{
    CalorieTrackingContext context;
    User _user;
    UserProfileForm _profileForm;


    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        context = new CalorieTrackingContext();
        _user = new User();
        _profileForm = new UserProfileForm();

    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
        var user = context.Users.FirstOrDefault(u=>u.UserMail == txtEmail.Text && u.UserPassword == txtPassword.Text);
        if (user == null)
        {
            MessageBox.Show("Username or password is incorrect");
            txtEmail.Clear(); 
            txtPassword.Clear(); 
            return;
        }
        else
        {
            _profileForm = new UserProfileForm();
            _profileForm.userProfile=user;
            this.Hide();
            _profileForm.Show();
            

        }
        
    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        UserRegistrationScreenForm userRegistrationScreenForm = new UserRegistrationScreenForm();
        userRegistrationScreenForm.ShowDialog();
    }

}
