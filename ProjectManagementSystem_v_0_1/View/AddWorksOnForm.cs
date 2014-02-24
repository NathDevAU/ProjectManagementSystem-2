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
    public partial class AddWorksOnForm : Form
    {
        Controller.Controller con = new Controller.Controller();

        private ManagerView mv;
        public AddWorksOnForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

            int rowIndex = mv.projectMemberDataGridView.CurrentCell.RowIndex;
            string no = mv.projectMemberDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            textBox1.Text = no;
            textBox1.ReadOnly = true;

            //Set values of combobox
            comboBox2.DataSource = con.getProjectNumbers();
            comboBox1.DataSource = con.getTaskNumbers();
        }

        private void AddWorksOnForm_Load(object sender, EventArgs e)
        {

        }


        private void okButton_Click(object sender, EventArgs e)
        {

            //get new values
            string pn = comboBox2.Text;
            string tn = comboBox1.Text;
            string pnr = textBox1.Text;
            string date = dateTimePicker1.Text;

            DateTime a = Convert.ToDateTime(date);

            double num;

            bool isPnNum = double.TryParse(pn, out num);
            bool isTnNum = double.TryParse(tn, out num);
            bool isPnrNum = double.TryParse(pnr, out num);

            if (pn != null && isPnNum && tn != null && isTnNum && pnr != null && isPnrNum && date != null && a != null)
            {

                int pno = Convert.ToInt32(pn);
                int tno = Convert.ToInt32(tn);
                int Pnr = Convert.ToInt32(pnr);


                con.setWorksOn(Pnr, tno, pno, a);

                mv.worksOnDataGridView.DataSource = con.getWorksOn(Pnr);

                this.Close();
            }

            else {


                MessageBox.Show("Please, check taht everything is typed and entered correctly!");

            
            }

        }

         

    }
}
