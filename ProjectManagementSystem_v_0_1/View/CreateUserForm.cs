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
    public partial class CreateUserForm : Form
    {

        Model.ProjectManagementDatabaseClassesDataContext db = new ProjectManagementDatabaseClassesDataContext();

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            Controller.Controller con = new Controller.Controller();

            
            string checkPnr = pnrTextBox.Text.Trim();
            string forename = forenameTextBox.Text;
            string surname = surnameTextBox.Text;
            string mUsername = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string mRole = roleTextBox.Text;

            string email = emailTextBox.Text;
            string phoneNr = phoneNrTextBox.Text;

            

            double num;

            bool isPhoneNum = double.TryParse(phoneNr, out num);
            bool isNum = double.TryParse(checkPnr, out num);

            

                if (isNum && !forename.Equals("") && !surname.Equals("")&& !mUsername.Equals("") && !password.Equals("") && !mRole.Equals("") && isPhoneNum && !email.Equals("") && !phoneNr.Equals(""))
                {
                    int phoneNumber = Convert.ToInt32(phoneNr);
                    int pnr = Convert.ToInt32(pnrTextBox.Text);
                    var crypto = new SimpleCrypto.PBKDF2();
                    string passwordSalt = crypto.GenerateSalt();
                    string hashedPassword = crypto.Compute(password, passwordSalt);
                    Console.WriteLine(passwordSalt);

                    con.createUser(pnr, forename, surname, mUsername, hashedPassword, mRole, passwordSalt, "standard");

                    con.createEmailAndPhoneListForUser(pnr, email, phoneNumber);

                    this.Close();

                
            }
            else
            {

                MessageBox.Show("Pnr was in the wrong format, must be Numbers from 0 - 9");

            }
            


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }

}
