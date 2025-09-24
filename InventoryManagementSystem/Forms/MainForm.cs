using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using InventoryManagementSystem.Data_Access;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private string email;
        private readonly UserRepository userRepository;
        private readonly UserService userService;

        public MainForm(string email)
        {
            InitializeComponent();
            this.email = email;
            userRepository = new UserRepository();
            userService = new UserService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayEmail.Text = email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select a Profile Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string image = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    byte[] photoData = userService.ImageToByte(pictureBox1.Image);
                    bool isSaved = userRepository.AddProfileImage(this.email, photoData);

                    if (isSaved)
                    {
                        MessageBox.Show("Profile picture updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile picture.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void LoadUserControl(System.Windows.Forms.UserControl userControl)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(userControl);
        }
        private void productsBtn_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
