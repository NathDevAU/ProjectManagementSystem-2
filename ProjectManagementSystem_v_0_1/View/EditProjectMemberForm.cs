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
    public partial class EditProjectMemberForm : Form
    {
        Controller.Controller con = new Controller.Controller();
        private string userId;

        private ManagerView mv;
        public EditProjectMemberForm(ManagerView form)
        {
            InitializeComponent();
            mv = form;

            int rowIndex = mv.projectMemberDataGridView.CurrentCell.RowIndex;
            string no = mv.projectMemberDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            string userName = mv.projectMemberDataGridView.Rows[rowIndex].Cells[3].Value.ToString();

            textBox1.Text = no;
            textBox4.Text = userName;

            setUserId(userId);

            textBox1.ReadOnly = true;
        }

        public void setUserId(string userId)
        {

            this.userId = userId;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String pnr = textBox1.Text;
            

            String forename = textBox2.Text;
            String surname = textBox3.Text;
            String username = textBox4.Text;
            String password = textBox5.Text;
            String role = textBox6.Text;

            double num;

            bool isPnrNum = double.TryParse(pnr, out num);

            if (isPnrNum && !pnr.Equals("") && !forename.Equals("") && !surname.Equals("") && !password.Equals("") && !role.Equals(""))
            {

                var crypto = new SimpleCrypto.PBKDF2();

              //  string userName = con.getUserNameWithPnr(a);

                int pnrI = Convert.ToInt32(pnr);

                string passwordSalt = con.getCurrentUser(this.userId);

                string hashedPassword = crypto.Compute(password, passwordSalt);

                con.editProjectMember(pnrI, forename, surname, username, hashedPassword, role);

                mv.projectMemberDataGridView.DataSource = con.fillProjectMember();

                this.Close();
            }
            else
            {

                MessageBox.Show("Make sure everything is typed correctly");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProjectMemberForm_Load(object sender, EventArgs e)
        {
            setUserId(textBox4.Text);

            Console.WriteLine(userId);

        }




    }
}
