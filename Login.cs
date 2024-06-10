using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Lorica_Residences_Rental_Management_System
{
    public partial class Login : Form
    {
        private UserController _userController;

        public Login()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private async void LogInBTN_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = UserController.SHA256Converter(PasswordTxtBox.Text);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Your Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int verify = await _userController.LogInValidationAsync(username, password);

                switch (verify)
                {
                    case 1:
                        MessageBox.Show("Successfully Logged In.");
                        this.Hide();
                        var mainBoard = new Dashboard();
                        mainBoard.Show();
                        break;
                    case 0:
                        MessageBox.Show("Incorrect Username or Password. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("There is something wrong while logging in. Please Try Again", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}
