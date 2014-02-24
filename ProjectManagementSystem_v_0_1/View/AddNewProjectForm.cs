using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem_v_0_1.View
{
    public partial class AddNewProjectForm : Form
    {

        Controller.Controller con = new Controller.Controller();


        private ManagerView mv;

        public AddNewProjectForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            int pNo = con.checkMaxPnoPlusOne();
            string pName = projectNameBox.Text;
            string pBudget = estimatedBudgetBox.Text;
            string description = descriptionBox.Text;
            string date = deadlineDatePicker.Text;
            DateTime a = Convert.ToDateTime(date);
            int projectLeaderPnr = Convert.ToInt32(projectLeaderPnrComboBox.SelectedValue.ToString());

            double num;

            bool isNumBudget = double.TryParse(pBudget, out num);


            if (isNumBudget && pName != null && pBudget != null && description != null && date != null && a != null && projectLeaderPnr != null)
            {


                int budget = Convert.ToInt32(estimatedBudgetBox.Text);


                con.addNewProject(pNo, pName, budget, description, a, projectLeaderPnr);

                mv.projectsDataGridView.DataSource = con.fillProject();

                this.Close();
            }

            else
            {

                MessageBox.Show("Check if Pnr is in the correct format and everything else is typed correctly in the remaining boxes");

            }
        }

        private void AddNewProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet.ProjectMember' table. You can move, or remove it, as needed.
            this.projectMemberTableAdapter.Fill(this.pMSDataSet.ProjectMember);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
