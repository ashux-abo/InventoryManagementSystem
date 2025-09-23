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
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 
            loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();
            string password = createPasswordTxt.Text;
            string confirmPassword = confirmPassTxt.Text;

            if(string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK);
                return;
            }

            if(password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK);
                return;
            }


            //We hash the password before storing it with the help of SecurityService that we created
            SecurityService securityService = new SecurityService();
            string hashedPassword = securityService.HashPassword(password);

            Console.WriteLine($"Email: {email}, Password: {password}, Hashed: {hashedPassword}");
            UserService userService = new UserService();
            bool isRegistered = userService.RegisterUser(email, hashedPassword);

            if (isRegistered)
            {
                MessageBox.Show("Registration succeessful. You can now log in.");
            }
            else
            {
                MessageBox.Show("Registration failed. Email may already be in used.", "Error", MessageBoxButtons.OK);
            }

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                createPasswordTxt.UseSystemPasswordChar = false;
                confirmPassTxt.UseSystemPasswordChar = false;
                createPasswordTxt.PasswordChar = '\0';
                confirmPassTxt.PasswordChar = '\0';
            }
            else
            {
                createPasswordTxt.UseSystemPasswordChar = true;
                confirmPassTxt.UseSystemPasswordChar = true;
                createPasswordTxt.PasswordChar = '●';
                confirmPassTxt.PasswordChar = '●';
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
