using DAL.Context;

namespace UI;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    CalorieTrackingContext context;
    private void LoginForm_Load(object sender, EventArgs e)
    {
        context = new CalorieTrackingContext();
    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
        var user = context.Users.FirstOrDefault(u=>u.UserMail == txtEmail.Text && u.UserPassword == txtPassword.Text);





    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        UserRegistrationScreenForm userRegistrationScreenForm = new UserRegistrationScreenForm();
        userRegistrationScreenForm.ShowDialog();
    }

}
