using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ProjectManagementSystem_v_0_1.Model;
using ProjectManagementSystem_v_0_1.View;
using ProjectManagementSystem_v_0_1.User;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;

namespace ProjectManagementSystem_v_0_1.Controller
{


    class Controller
    {

        ProjectManagementDatabaseClassesDataContext db = new ProjectManagementDatabaseClassesDataContext();
        private View.ProjectView pv;
        private View.ManagerView mv;
        User.CurrentUser cu = new CurrentUser();


        public int validateUser(string userName, string pwd)
        {


            // var userExists = db.checkUserPassword(userName, pwd);

            //  var userExists = db.ProjectMembers.FirstOrDefault(x => x.MUsername == userName && x.MPassword == pwd) != null;

            var result = db.checkUserPassword(userName, pwd);

            int i = result;

            //  Console.WriteLine(userExists.ToString() + ", " + i);

            return i;
        }





        public void createUser(int pnr, string forename, string surname, string mUsername, string mPassword, string mRole, string passwordSalt, string userType)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.setProjectMember(pnr, forename, surname, mUsername, mPassword, mRole, passwordSalt, userType);
                    db.SubmitChanges();
                    //Commit transaction
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            Console.WriteLine(pnr + forename + surname + mUsername + mPassword + mRole);

        }

        public int tryLogin(string userName, string pwd, string userType)
        {

            int valid = 0;

            Console.WriteLine(pwd);

            int validated = validateUser(userName, pwd);

            if (validated == 1)
            {

                cu.SetUserId(userName);

                Console.WriteLine(cu.getUserId());

                Console.WriteLine("you have successfully logged in");

                var result = db.getCurrentUser(userName);

                Console.WriteLine(result);


                if (userType.Equals("standard"))
                {
                    pv = new ProjectView();

                    pv.SetUserId(userName);

                    pv.Show();

                }

                else if (userType.Equals("manager"))
                {
                    mv = new ManagerView();

                    mv.setUserName(userName);

                    mv.Show();
                }
                valid = 1;
            }
            else if (validated == 0)
            {
                Console.WriteLine("The username/password combination does not match! Please try again, Make sure caps lock is not pressed");
                valid = 0;
            }
            return valid;
        }

        public void insertTaskIntoDatabase(int tno, int pno, string tname, string tdesc, DateTime tDeadline)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.setTask(tno, pno, tname, tdesc, tDeadline);
                    Console.WriteLine("Just inserted a task into DB with TNO= " + tno + " FUCKING NINJA!");
                    db.SubmitChanges();
                    //Commit transaction
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<int> returnProjectNumbers()
        {
            List<int> pNoList = new List<int>();


            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getAllProject();

                    if (result != null)
                    {
                        foreach (var sResult in result)
                        {
                            Console.WriteLine(sResult.PNo);
                            pNoList.Add(sResult.PNo);
                        }
                    }
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return pNoList;
        }

        public List<Project> FillCurrentUserProjects(string userId)
        {
            List<Project> currentProjects = new List<Project>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getProjectsForCurrentUser(userId);

                    currentProjects = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return currentProjects;

        }

        public List<ProjectMember> fillMembersForCurrentProject(int pno)
        {

            List<ProjectMember> projectMemberList = new List<ProjectMember>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {

                    var result = db.getProjectMemebersForCurrentProject(pno);

                    projectMemberList = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }

                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return projectMemberList;

        }

        public List<Tasks> fillCurrentTasksForCurrentUser(int pno, string userName)
        {

            List<Tasks> taskForCurrentUserList = new List<Tasks>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getTaskByProjectUser(userName, pno);

                    taskForCurrentUserList = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return taskForCurrentUserList;

        }

        public int fillUserPnr(string userName)
        {

            int pnr = 0;

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {

                try
                {
                    var result = db.getCurrentUser(userName);

                    foreach (var res in result)
                    {
                        pnr = Convert.ToInt32(res.PNR.ToString());

                        Console.WriteLine(pnr.ToString());
                    }
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }

            }
            return pnr;

        }

        public List<Tasks> getAllTasks()
        {
            List<Tasks> taskList = new List<Tasks>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {

                try
                {
                    var result = db.getAllTask();

                    taskList = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return taskList;
        }


        public void updateTask(int TNo, int PNo, String TName, String TDesc, DateTime TDeadline)
        {
            Console.WriteLine("JUST WENT INSIDE THE UPDATETASK");

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.updateTask(TNo, PNo, TName, TDesc, TDeadline);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

        }


        public void deleteTask(int TNo)
        {
            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.deleteTask(TNo);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<ProjectMember> fillProjectMember()
        {

            List<ProjectMember> pmem = new List<ProjectMember>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {

                try
                {
                    var result = db.getAllPmem();
                    pmem = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return pmem;
        }

        public void deleteProjectMember(int pnr)
        {
            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.deleteProjectMember(pnr);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

        }

        public void editProjectMember(int pnr, String forename, String surname, String username,
                                        String password, string role)
        {
            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.updateProjectMember(pnr, forename, surname, username, password, role);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<Project> fillProject()
        {

            List<Project> projectList = new List<Project>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getProject();
                    projectList = result.ToList<Project>();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return projectList;
        }

        public void deleteProject(int pNr)
        {
            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.deleteProject(pNr);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<WorksOn> getWorksOn(int pnr)
        {
            List<WorksOn> wo = new List<WorksOn>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getWorksOn(pnr);
                    wo = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return wo;
        }

        public void editWorksOn(int pnr, int tno, int pno, int tnoIN, int pnoIN, DateTime date)
        {
            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.updateWorksOn(pnr, tno, pno, tnoIN, pnoIN, date);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public void deleteWorksOn(int pnr, int tno, int pno)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.deleteWorksOn(pnr, tno, pno);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<int> getProjectNumbers()
        {
            List<int> pNoList = new List<int>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getProject();

                    if (result != null)
                    {
                        foreach (var sResult in result)
                        {
                            Console.WriteLine(sResult.PNo);
                            pNoList.Add(sResult.PNo);
                        }
                    }
                    //Commit transaction
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return pNoList;
        }

        public List<int> getTaskNumbers()
        {

            List<int> tNoList = new List<int>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getTask();

                    if (result != null)
                    {
                        foreach (var sResult in result)
                        {
                            Console.WriteLine(sResult.TNo);
                            tNoList.Add(sResult.TNo);
                        }
                    }
                    db.SubmitChanges();
                    //Commit transaction
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return tNoList;
        }

        public void setWorksOn(int pnr, int tno, int pno, DateTime date)
        {

            //Set isolation level of transaction
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp the transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    //db.Connection.Open();
                    //db.Transaction = db.Connection.BeginTransaction();

                    db.setWorksOn(pnr, tno, pno, date);
                    db.SubmitChanges();
                    //db.Transaction.Commit();

                    //Commit transaction
                    trans.Complete();

                    //db.Transaction.Commit();

                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }


        public int generateTno()
        {
            int value = 0;

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getHighestTno();

                    foreach (var res in result)
                    {

                        if (res.Column1 == null)
                        {
                            value = 0;
                        }

                        else if (res.Column1 != null)
                        {
                            value = Convert.ToInt32(res.Column1.ToString());
                        }
                    }
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return value + 1;
        }

        public int checkMaxPnoPlusOne()
        {
            int value = 0;

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getHighestPno();

                    foreach (var res in result)
                    {

                        if (res.Column1 == null)
                        {
                            value = 0;
                        }
                        else if (res.Column1 != null)
                        {
                            value = Convert.ToInt32(res.Column1.ToString());
                        }
                    }
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return value + 1;
        }

        public void addNewProject(int pNo, string pName, int pBudget, string description, DateTime a, int projectLeaderPnr)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.setProject(pNo, pName, pBudget, description, a, projectLeaderPnr);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public void updateProject(int pNo, string pName, int pBudget, string description, DateTime a, int projectLeaderPnr)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    db.updateProject(pNo, pName, pBudget, description, a, projectLeaderPnr);
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
        }

        public List<FinishedProject> fillFinishedProjectsForUser(string userId)
        {

            List<FinishedProject> fpl = new List<FinishedProject>();

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.finishedProjectsForCurrentUser(userId);

                    fpl = result.ToList();
                    db.SubmitChanges();
                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

            return fpl;

        }

        public void createEmailAndPhoneListForUser(int pnr, string email, int phoneNumber)
        {

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {

                    db.setPMemEmailList(pnr, email);
                    db.setPMemPhoneList(pnr, phoneNumber);


                    trans.Complete();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }

        }
        /*
        public string getUserNameWithPnr(int pnr)
        {

            string userName = "";

            var result = db.getUserNameWithPnr(pnr);
            
            foreach (var res in result)
            {

                userName = res.MUsername;

            }

            Console.WriteLine(userName);

            return userName;

        }
         * */

        public string getCurrentUser(string userName)
        {

            string passwordSalt = " ";

            //Set isolation level
            TransactionOptions ops = new TransactionOptions();
            ops.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //Wrapp transaction
            using (TransactionScope trans = new TransactionScope(TransactionScopeOption.Required, ops))
            {
                try
                {
                    var result = db.getCurrentUser(userName);
                    db.SubmitChanges();
                    

                    foreach (var res in result)
                    {
                        passwordSalt = res.PasswordSalt.ToString();
                    }

                    Console.WriteLine(passwordSalt);

                    trans.Complete();

                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                catch (TransactionAbortedException tab)
                {
                    MessageBox.Show(tab.Message.ToString());
                }
                catch (TransactionInDoubtException tib)
                {
                    MessageBox.Show(tib.Message.ToString());
                }
            }
            return passwordSalt;
        }

    }
}
