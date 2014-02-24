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
    public partial class ManagerView : Form
    {


        private string userName;
        Controller.Controller con = new Controller.Controller();

        public ManagerView()
        {
            InitializeComponent();
            
            tasksDataGridView.DataSource = con.getAllTasks();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            projectMemberDataGridView.DataSource = null;
            projectMemberDataGridView.DataSource = con.fillProjectMember();
            projectsDataGridView.DataSource = con.fillProject();
        }

        public void setUserName(string userName)
        {

            this.userName = userName;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {

            TaskAddWindowsForm taw = new TaskAddWindowsForm(this);
            taw.Visible = true;

            

        }

        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {

            TaskEditWindowsForm tdw = new TaskEditWindowsForm(this);
            tdw.Visible = true;

        }

        private void removeTaskButton_Click(object sender, EventArgs e)
        {

            
            int rowIndex = this.tasksDataGridView.CurrentCell.RowIndex;
            con.deleteTask(Convert.ToInt32(this.tasksDataGridView.Rows[rowIndex].Cells[0].Value));
            tasksDataGridView.DataSource = con.getAllTasks();

        }

        private void projectMemberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = projectMemberDataGridView.CurrentCell.RowIndex;
            String no = projectMemberDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            int pnr = Convert.ToInt32(no);

            worksOnDataGridView.DataSource = con.getWorksOn(pnr);

        }

        private void editWorksOnButton_Click(object sender, EventArgs e)
        {

            EditWorksOnForm wo = new EditWorksOnForm(this);
            wo.Show();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = worksOnDataGridView.CurrentCell.RowIndex;
            String pnr = worksOnDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            String pno = worksOnDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            String tno = worksOnDataGridView.Rows[rowIndex].Cells[1].Value.ToString();

            int Pnr = Convert.ToInt32(pnr);
            int Pno = Convert.ToInt32(pno);
            int Tno = Convert.ToInt32(tno);

            con.deleteWorksOn(Pnr, Tno, Pno);

            worksOnDataGridView.DataSource = con.getWorksOn(Pnr);
        
        }

        private void addWorksOnButton_Click(object sender, EventArgs e)
        {

            AddWorksOnForm awof = new AddWorksOnForm(this);

            awof.Show();

        }

        private void projectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {


            AddNewProjectForm anpf = new AddNewProjectForm(this);
            anpf.Show();


        }

        private void editButton_Click(object sender, EventArgs e)
        {

            EditProjectForm epf = new EditProjectForm(this);
            epf.Show();

        }

        private void removeProjectButton_Click(object sender, EventArgs e)
        {

            int rowIndex = projectsDataGridView.CurrentCell.RowIndex;
            string no = projectsDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            int pNo = Convert.ToInt32(no);

            Console.WriteLine(pNo.ToString());

            con.deleteProject(pNo);

            projectsDataGridView.DataSource = con.fillProject();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = projectMemberDataGridView.CurrentCell.RowIndex;
            string no = projectMemberDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            int pnr = Convert.ToInt32(no);
            con.deleteProjectMember(pnr);
            projectMemberDataGridView.DataSource = con.fillProjectMember();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            EditProjectMemberForm epmf = new EditProjectMemberForm(this);

            epmf.Show();
            

        }

        

  
    }
}
