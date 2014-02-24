using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem_v_0_1.Controller;
using ProjectManagementSystem_v_0_1.Model;

namespace ProjectManagementSystem_v_0_1.View
{
    public partial class LoginForm : Form
    {



        Controller.Controller con = new Controller.Controller();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerLabel_click(object sender, EventArgs e)
        {

            registerLabel.ForeColor = Color.Tomato;

            var createUserForm = new CreateUserForm();

            createUserForm.Show();


        }

        private void registerLabel_Hover(object sender, EventArgs e)
        {


            registerLabel.ForeColor = Color.AliceBlue;

        }

        private void registerLabel_HoverLeave(object sender, EventArgs e)
        {

            registerLabel.ForeColor = Color.Black;

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

           ProjectManagementDatabaseClassesDataContext db = new ProjectManagementDatabaseClassesDataContext();

           var crypto = new SimpleCrypto.PBKDF2();

           string password = passwordTextBox.Text;

           string userName = userNameTextBox.Text;

           var result = db.getCurrentUser(userName);

           string salt = "";
           string userType = "";

           if (result != null)
           {
               foreach (var sResult in result)
               {

                   salt = sResult.PasswordSalt;
                   userType = sResult.UserType;

                   Console.WriteLine("UserType: " + userType);

               }



              string hashedPassword = crypto.Compute(password, salt);
              int valid = con.tryLogin(userName, hashedPassword, userType);

              if (valid == 1)
              {

                  this.Hide();

              }
              else
              {
                  Console.WriteLine("Wrong username or password");
              }
           }

        }

    }
}
