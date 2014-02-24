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
    public partial class TaskEditWindowsForm : Form
    {
        private ManagerView mv;
        Controller.Controller con = new Controller.Controller();

        public TaskEditWindowsForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

            int rowIndex = form.tasksDataGridView.CurrentCell.RowIndex;
            TNoTextBox.Text = form.tasksDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            PNoTextBox.Text = form.tasksDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            TNameTextBox.Text = form.tasksDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            TDescTextBox.Text = form.tasksDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            TDeadlineDateTimePicker.Text = form.tasksDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTaskButton_Click_1(object sender, EventArgs e)
        {
            string t = TNoTextBox.Text;
            string p = PNoTextBox.Text;

            int tNo = Convert.ToInt32(t);
            int pNo = Convert.ToInt32(p);
            string tName = TNameTextBox.Text;
            string tDesc = TDescTextBox.Text;
            DateTime tDeadline = Convert.ToDateTime(TDeadlineDateTimePicker.Text);


            Console.WriteLine(TNoTextBox.Text + PNoTextBox.Text + TNameTextBox.Text + TDescTextBox.Text + TDeadlineDateTimePicker.Text);
            if (tNo != null & pNo != null & tName != null & tDesc != null & tDeadline != null)
            {
                Console.WriteLine("WENT THROUGH!!!");
                con.updateTask(tNo, pNo, tName, tDesc, tDeadline);
            }
            else
            {
                Console.WriteLine("DIDN'T WENT THROUGH!");
            }
            mv.tasksDataGridView.DataSource = con.getAllTasks();
            this.Close();
        }
    }
}
