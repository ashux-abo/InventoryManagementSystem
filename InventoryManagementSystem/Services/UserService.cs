using System;
using System.Collections.Generic;
using System.Drawing;
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
        //this will validates the user login credentials
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

        // Converts an Image to a byte array
        public byte[] ImageToByte(System.Drawing.Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // Converts a byte array back to an Image
        public Image ByteToImage(byte[] imageData)
        {

            if(imageData == null || imageData.Length == 0)
            {
                return null; // or return a default image
            }

            using (var ms = new System.IO.MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
