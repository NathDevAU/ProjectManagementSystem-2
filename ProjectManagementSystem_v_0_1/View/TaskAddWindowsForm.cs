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
namespace ProjectManagementSystem_v_0_1.View
{
    public partial class TaskAddWindowsForm : Form
    {

        private ManagerView mv;
        Controller.Controller con = new Controller.Controller();

        public TaskAddWindowsForm(ManagerView form)
        {
            mv = form;
            InitializeComponent();
            PNoComboBox.DataSource = con.returnProjectNumbers();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            int TNo = con.generateTno();

            Console.WriteLine(TNo.ToString());

            int PNo = Convert.ToInt32(PNoComboBox.SelectedValue);
            String TName = TNameTextBox.Text;
            String TDesc = TDescTextBox.Text;
            DateTime TDeadline = TDeadlineDateTimePicker.Value;

            Console.WriteLine("Just inserted the awesome task with the awesome Task Number: " + TNo + "And Project Number: " + PNo);

            con.insertTaskIntoDatabase(TNo, PNo, TName, TDesc, TDeadline);

            mv.tasksDataGridView.DataSource = con.getAllTasks();
            
            this.Close();
        }

    

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
