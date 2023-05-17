using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Sayali S. Bujade
namespace CarRentalSystem
{
    public partial class LoginForm : Form
    {
        public static string loggedInRole = "";
        private static LoginForm loginForm;
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        public LoginForm()
        {
            InitializeComponent();
        }
        public static LoginForm GetLoginForm()
        {
            if (loginForm == null) loginForm = new LoginForm();
            return loginForm;
        }//GetLoginForm()

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm = null;
        }//LoginForm_FormClosing()

        private void LoginForm_Load(object sender, EventArgs e)
        {
            bool isLoggedIn = CarRentalMdiContainer.IsLoggedIn;
            resultLabel.Text = $"Login Val: {isLoggedIn}";
            
            if (isLoggedIn)
                showLogout();
            else
                showLogin();
        }//LoginForm_Load()

        private void loginButton_Click(object sender, EventArgs e)
        {

            //get the login credentials from user
            DataTable user = carRentalIntermediaryClass.getUserForLogin
                                (usernameTextBox.Text, passwordTextBox.Text);
            int count = user.Rows.Count;   
            try
            {
                if (user != null && count > 0)
                {
                    CarRentalMdiContainer.loggedInUsername = user.Rows[0]["user_name"].ToString().Trim();
                    CarRentalMdiContainer.loggedInUserId = int.Parse(user.Rows[0]["user_id"].ToString());
                    BindingSource userBindingSource = new BindingSource();
                    userBindingSource.DataSource = user;
                    resultLabel.DataBindings.Clear();
                    resultLabel.DataBindings.Add("Text", userBindingSource, "role");

                    loggedInRole = resultLabel.Text.Trim();
                    CarRentalMdiContainer.IsLoggedIn = true;
                    showLogout();
                }
                else
                {
                    loggedInRole = "";
                    CarRentalMdiContainer.IsLoggedIn = false;
                    showLogin();
                    throw new InvalidCredentialsException("Incorrect username or password");
                }
            } catch(InvalidCredentialsException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }//loginButton_Click()

        private void logoutButton_Click(object sender, EventArgs e)
        {
            showLogin();
            loggedInRole = "";
            CarRentalMdiContainer.IsLoggedIn = false;
        }//logoutButton_click()

        private void showLogin()
        {
            resultLabel.Text = "";
            usernameLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            loginButton.Visible = true;
            logoutButton.Visible = false;
        }//showLogin()
        private void showLogout()
        {
            resultLabel.Text = $"You are logged in as a {loggedInRole}";
            usernameLabel.Visible = false;
            usernameTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            loginButton.Visible = false;
            logoutButton.Visible = true;
        }//showLogout()
    }//class
}//namespace
