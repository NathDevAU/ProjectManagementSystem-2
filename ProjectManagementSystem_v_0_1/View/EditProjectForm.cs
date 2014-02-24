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
    public partial class EditProjectForm : Form
    {

        private ManagerView mv;
        Controller.Controller con = new Controller.Controller();
        public EditProjectForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

            int rowIndex = mv.projectsDataGridView.CurrentCell.RowIndex;
            string no = mv.projectsDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            pnoTextBox.Text = no.ToString();
            pnoTextBox.ReadOnly = true;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

             int rowIndex = mv.projectsDataGridView.CurrentCell.RowIndex;
            string no = mv.projectsDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            string pName = projectNameBox.Text;
            string pBudget = estimatedBudgetBox.Text;
            string description = descriptionBox.Text;
            string date = deadlineDatePicker.Text;
            DateTime a = Convert.ToDateTime(date);
            int projectLeaderPnr = Convert.ToInt32(projectLeaderPnrComboBox.SelectedValue.ToString());

            double num;

            bool isNum = double.TryParse(no, out num);

            bool isNumBudget = double.TryParse(pBudget, out num);


            if (isNum && isNumBudget && !pName.Equals("") && !pBudget.Equals("") && !description.Equals("") && !date.Equals("") && !a.Equals("") && projectLeaderPnr != null)
            {

                int pNo = Convert.ToInt32(no);
                int budget = Convert.ToInt32(estimatedBudgetBox.Text);


                con.updateProject(pNo, pName, budget, description, a, projectLeaderPnr);

                mv.projectsDataGridView.DataSource = con.fillProject();

                this.Close();
            }

            else
            {

                MessageBox.Show("Check if Pnr is in the correct format and everything is typed correctly in the remaining boxes");

            }

        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet1.ProjectMember' table. You can move, or remove it, as needed.
            this.projectMemberTableAdapter.Fill(this.pMSDataSet1.ProjectMember);

        }
    }
}
