namespace ProjectManagementSystem_v_0_1.View
{
    partial class ManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managerTabControl = new System.Windows.Forms.TabControl();
            this.projectInformationTabPage = new System.Windows.Forms.TabPage();
            this.editButton = new System.Windows.Forms.Button();
            this.removeProjectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addWorksOnButton = new System.Windows.Forms.Button();
            this.editWorksOnButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.worksOnDataGridView = new System.Windows.Forms.DataGridView();
            this.worksOnLabel = new System.Windows.Forms.Label();
            this.projectMembersLabel = new System.Windows.Forms.Label();
            this.projectMemberDataGridView = new System.Windows.Forms.DataGridView();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.managerTabControl.SuspendLayout();
            this.projectInformationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worksOnDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberDataGridView)).BeginInit();
            this.tasksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerTabControl
            // 
            this.managerTabControl.Controls.Add(this.projectInformationTabPage);
            this.managerTabControl.Controls.Add(this.tabPage2);
            this.managerTabControl.Controls.Add(this.tasksTabPage);
            this.managerTabControl.Location = new System.Drawing.Point(5, 7);
            this.managerTabControl.Name = "managerTabControl";
            this.managerTabControl.SelectedIndex = 0;
            this.managerTabControl.Size = new System.Drawing.Size(1055, 692);
            this.managerTabControl.TabIndex = 0;
            // 
            // projectInformationTabPage
            // 
            this.projectInformationTabPage.Controls.Add(this.editButton);
            this.projectInformationTabPage.Controls.Add(this.removeProjectButton);
            this.projectInformationTabPage.Controls.Add(this.addButton);
            this.projectInformationTabPage.Controls.Add(this.label1);
            this.projectInformationTabPage.Controls.Add(this.projectsDataGridView);
            this.projectInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this.projectInformationTabPage.Name = "projectInformationTabPage";
            this.projectInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectInformationTabPage.Size = new System.Drawing.Size(1047, 666);
            this.projectInformationTabPage.TabIndex = 0;
            this.projectInformationTabPage.Text = "Project Information";
            this.projectInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(828, 555);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeProjectButton
            // 
            this.removeProjectButton.Location = new System.Drawing.Point(909, 555);
            this.removeProjectButton.Name = "removeProjectButton";
            this.removeProjectButton.Size = new System.Drawing.Size(75, 23);
            this.removeProjectButton.TabIndex = 3;
            this.removeProjectButton.Text = "Remove";
            this.removeProjectButton.UseVisualStyleBackColor = true;
            this.removeProjectButton.Click += new System.EventHandler(this.removeProjectButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(747, 555);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projects";
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AllowUserToDeleteRows = false;
            this.projectsDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Location = new System.Drawing.Point(51, 74);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.ReadOnly = true;
            this.projectsDataGridView.Size = new System.Drawing.Size(933, 428);
            this.projectsDataGridView.TabIndex = 0;
            this.projectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGridView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addWorksOnButton);
            this.tabPage2.Controls.Add(this.editWorksOnButton);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.worksOnDataGridView);
            this.tabPage2.Controls.Add(this.worksOnLabel);
            this.tabPage2.Controls.Add(this.projectMembersLabel);
            this.tabPage2.Controls.Add(this.projectMemberDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addWorksOnButton
            // 
            this.addWorksOnButton.Location = new System.Drawing.Point(754, 626);
            this.addWorksOnButton.Name = "addWorksOnButton";
            this.addWorksOnButton.Size = new System.Drawing.Size(75, 23);
            this.addWorksOnButton.TabIndex = 10;
            this.addWorksOnButton.Text = "Add";
            this.addWorksOnButton.UseVisualStyleBackColor = true;
            this.addWorksOnButton.Click += new System.EventHandler(this.addWorksOnButton_Click);
            // 
            // editWorksOnButton
            // 
            this.editWorksOnButton.Location = new System.Drawing.Point(842, 626);
            this.editWorksOnButton.Name = "editWorksOnButton";
            this.editWorksOnButton.Size = new System.Drawing.Size(75, 23);
            this.editWorksOnButton.TabIndex = 9;
            this.editWorksOnButton.Text = "Edit";
            this.editWorksOnButton.UseVisualStyleBackColor = true;
            this.editWorksOnButton.Click += new System.EventHandler(this.editWorksOnButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(923, 626);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(754, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit Project Member";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(873, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Project Member";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // worksOnDataGridView
            // 
            this.worksOnDataGridView.AllowUserToAddRows = false;
            this.worksOnDataGridView.AllowUserToDeleteRows = false;
            this.worksOnDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.worksOnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksOnDataGridView.Location = new System.Drawing.Point(50, 347);
            this.worksOnDataGridView.Name = "worksOnDataGridView";
            this.worksOnDataGridView.ReadOnly = true;
            this.worksOnDataGridView.Size = new System.Drawing.Size(948, 263);
            this.worksOnDataGridView.TabIndex = 3;
            // 
            // worksOnLabel
            // 
            this.worksOnLabel.AutoSize = true;
            this.worksOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worksOnLabel.Location = new System.Drawing.Point(459, 319);
            this.worksOnLabel.Name = "worksOnLabel";
            this.worksOnLabel.Size = new System.Drawing.Size(107, 25);
            this.worksOnLabel.TabIndex = 2;
            this.worksOnLabel.Text = "Works On";
            // 
            // projectMembersLabel
            // 
            this.projectMembersLabel.AutoSize = true;
            this.projectMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectMembersLabel.Location = new System.Drawing.Point(419, 3);
            this.projectMembersLabel.Name = "projectMembersLabel";
            this.projectMembersLabel.Size = new System.Drawing.Size(174, 25);
            this.projectMembersLabel.TabIndex = 1;
            this.projectMembersLabel.Text = "Project Members";
            // 
            // projectMemberDataGridView
            // 
            this.projectMemberDataGridView.AllowUserToAddRows = false;
            this.projectMemberDataGridView.AllowUserToDeleteRows = false;
            this.projectMemberDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.projectMemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectMemberDataGridView.Location = new System.Drawing.Point(50, 31);
            this.projectMemberDataGridView.Name = "projectMemberDataGridView";
            this.projectMemberDataGridView.ReadOnly = true;
            this.projectMemberDataGridView.Size = new System.Drawing.Size(948, 256);
            this.projectMemberDataGridView.TabIndex = 0;
            this.projectMemberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectMemberDataGridView_CellContentClick);
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.removeTaskButton);
            this.tasksTabPage.Controls.Add(this.editTaskButton);
            this.tasksTabPage.Controls.Add(this.addTaskButton);
            this.tasksTabPage.Controls.Add(this.tasksDataGridView);
            this.tasksTabPage.Controls.Add(this.tasksLabel);
            this.tasksTabPage.Location = new System.Drawing.Point(4, 22);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(1047, 666);
            this.tasksTabPage.TabIndex = 2;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(917, 572);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(75, 23);
            this.removeTaskButton.TabIndex = 4;
            this.removeTaskButton.Text = "Remove";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(836, 572);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(75, 23);
            this.editTaskButton.TabIndex = 3;
            this.editTaskButton.Text = "Edit";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(755, 572);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.Text = "Add New";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AllowUserToAddRows = false;
            this.tasksDataGridView.AllowUserToDeleteRows = false;
            this.tasksDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Location = new System.Drawing.Point(49, 66);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.Size = new System.Drawing.Size(943, 482);
            this.tasksDataGridView.TabIndex = 1;
            this.tasksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksDataGridView_CellContentClick);
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksLabel.Location = new System.Drawing.Point(449, 19);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(70, 25);
            this.tasksLabel.TabIndex = 0;
            this.tasksLabel.Text = "Tasks";
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 702);
            this.Controls.Add(this.managerTabControl);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.Load += new System.EventHandler(this.ManagerView_Load);
            this.managerTabControl.ResumeLayout(false);
            this.projectInformationTabPage.ResumeLayout(false);
            this.projectInformationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worksOnDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberDataGridView)).EndInit();
            this.tasksTabPage.ResumeLayout(false);
            this.tasksTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl managerTabControl;
        private System.Windows.Forms.TabPage projectInformationTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tasksTabPage;
        private System.Windows.Forms.Label projectMembersLabel;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label tasksLabel;
        public System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.Label worksOnLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addWorksOnButton;
        private System.Windows.Forms.Button editWorksOnButton;
        private System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.DataGridView worksOnDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeProjectButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView projectsDataGridView;
        public System.Windows.Forms.DataGridView projectMemberDataGridView;
    }
}