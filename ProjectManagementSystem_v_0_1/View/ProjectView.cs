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
    public partial class ProjectView : Form
    {

        Model.ProjectManagementDatabaseClassesDataContext db = new ProjectManagementDatabaseClassesDataContext();

        private string userId;

        public void SetUserId(string uId){
        
            userId = uId;
        
        }

        Controller.Controller con = new Controller.Controller();

        public ProjectView()
        {
            InitializeComponent();

            

        }

        private void ProjectView_Load(object sender, EventArgs e)
        {

            usersProjectDataGridView.DataSource = con.FillCurrentUserProjects(userId);
            finishedProjectsDataGridView.DataSource = con.fillFinishedProjectsForUser(userId);
            pnrTextBox.Text = con.fillUserPnr(userId).ToString();
            pnrTextBox.ReadOnly = true;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void applyNewSettingsButton_Click(object sender, EventArgs e)
        {

            int pnr = int.Parse(pnrTextBox.Text);
            String forename = forenameTextBox.Text;
            String surname = surnameTextBox.Text;
            String username = usernameTextBox.Text;
            String passwordInput= passwordTextBox.Text;
            String role = roleTextBox.Text;


            if (!forename.Equals("") && !surname.Equals("") && !username.Equals("") && !passwordInput.Equals("") && role.Equals(""))
            {

                var crypto = new SimpleCrypto.PBKDF2();

                string passwordSalt = con.getCurrentUser(userId);

                string hashedPassword = crypto.Compute(passwordInput, passwordSalt);

                SetUserId(username);

                con.editProjectMember(pnr, forename, surname, username, hashedPassword, role);

                MessageBox.Show("The new settings have been Applied!");
            }

            else
            {

                MessageBox.Show("The settings could not be applied. Please check that every field is entered correctly!");

            }

        }

        private void usersProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            Console.WriteLine(usersProjectDataGridView.SelectedRows.Count.ToString());

          
                int rowIndex = usersProjectDataGridView.CurrentCell.RowIndex;
                int pno = Convert.ToInt32(usersProjectDataGridView.Rows[rowIndex].Cells[0].Value.ToString());

               

                currentMembersDataGrid.DataSource = con.fillMembersForCurrentProject(pno);

                currentTasksDataGrid.DataSource = con.fillCurrentTasksForCurrentUser(pno, userId);

            

        }

       

   
    }
}
