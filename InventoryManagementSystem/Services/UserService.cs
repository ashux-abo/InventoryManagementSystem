using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Data_Access;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    internal class UserService
    {
        private readonly UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }
        public bool RegisterUser(string email, string hashedPassword)
        {
            if (userRepository.IsEmailToken(email))
            {
                MessageBox.Show("Email already exists.","Error", MessageBoxButtons.OK);
                return false; // Email already exists
            }

            User newUser = new User
            {
                Email = email,
                PasswordHash = hashedPassword
            };

            return userRepository.AddUser(newUser);
        }

       
    }
}
