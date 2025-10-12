using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();
            string password = passwordTxt.Text; 

            AuthService authService = new AuthService();
            bool isAuthenticated = authService.AuthenticateUser(email, password);

            if (isAuthenticated) 
            {
                MessageBox.Show("Login successful!");
                this.Hide();

                string userEmail = emailTxt.Text;

                MainPage mainPage = new MainPage(userEmail);
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK);   
            }
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

            this.Close();
        }

        private void passwordVisible_Click(object sender, EventArgs e)
        {
            if(passwordTxt.UseSystemPasswordChar)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
