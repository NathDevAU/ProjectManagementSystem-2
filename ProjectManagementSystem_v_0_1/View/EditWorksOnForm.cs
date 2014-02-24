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
    public partial class EditWorksOnForm : Form
    {

        Controller.Controller con = new Controller.Controller();

        private ManagerView mv;
        public EditWorksOnForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

            int rowIndex = mv.projectMemberDataGridView.CurrentCell.RowIndex;
            string no = mv.projectMemberDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            textBox1.Text = no;
            textBox1.ReadOnly = true;
            
            //Set values of combobox
            comboBox1.DataSource = con.getProjectNumbers();
            comboBox2.DataSource = con.getTaskNumbers();

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

            if (!pn.Equals("") && isPnNum && !tn.Equals("") && isTnNum && !pnr.Equals("")&& isPnrNum && !date.Equals("") && !a.Equals(""))
            {

                int pno = Convert.ToInt32(pn);
                int tno = Convert.ToInt32(tn);
                int Pnr = Convert.ToInt32(pnr);


                con.editWorksOn(Pnr, tno, pno, pno, tno, a);

                mv.worksOnDataGridView.DataSource = con.getWorksOn(Pnr);

                this.Close();
            }

            else
            {


                MessageBox.Show("Please, check taht everything is typed and entered correctly!");


            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       




    }
}
