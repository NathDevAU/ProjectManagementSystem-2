namespace ProjectManagementSystem_v_0_1.View
{
    partial class ProjectView
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.myProjectsTabPage = new System.Windows.Forms.TabPage();
            this.currentMembersDataGrid = new System.Windows.Forms.DataGridView();
            this.projectMemberLabel = new System.Windows.Forms.Label();
            this.currentTasksDataGrid = new System.Windows.Forms.DataGridView();
            this.taskLabel = new System.Windows.Forms.Label();
            this.currentProjectLabel = new System.Windows.Forms.Label();
            this.usersProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.applyNewSettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.forenameLabel = new System.Windows.Forms.Label();
            this.pnrLabel = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.forenameTextBox = new System.Windows.Forms.TextBox();
            this.pnrTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.finishedProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.myProjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTasksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersProjectDataGridView)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedProjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.myProjectsTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Location = new System.Drawing.Point(5, 5);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1198, 616);
            this.mainTabControl.TabIndex = 0;
            // 
            // myProjectsTabPage
            // 
            this.myProjectsTabPage.BackColor = System.Drawing.Color.White;
            this.myProjectsTabPage.Controls.Add(this.currentMembersDataGrid);
            this.myProjectsTabPage.Controls.Add(this.projectMemberLabel);
            this.myProjectsTabPage.Controls.Add(this.currentTasksDataGrid);
            this.myProjectsTabPage.Controls.Add(this.taskLabel);
            this.myProjectsTabPage.Controls.Add(this.currentProjectLabel);
            this.myProjectsTabPage.Controls.Add(this.usersProjectDataGridView);
            this.myProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.myProjectsTabPage.Name = "myProjectsTabPage";
            this.myProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myProjectsTabPage.Size = new System.Drawing.Size(1190, 590);
            this.myProjectsTabPage.TabIndex = 1;
            this.myProjectsTabPage.Text = "My Projects";
            // 
            // currentMembersDataGrid
            // 
            this.currentMembersDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.currentMembersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentMembersDataGrid.Location = new System.Drawing.Point(36, 317);
            this.currentMembersDataGrid.Name = "currentMembersDataGrid";
            this.currentMembersDataGrid.Size = new System.Drawing.Size(540, 259);
            this.currentMembersDataGrid.TabIndex = 5;
            // 
            // projectMemberLabel
            // 
            this.projectMemberLabel.AutoSize = true;
            this.projectMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectMemberLabel.Location = new System.Drawing.Point(210, 289);
            this.projectMemberLabel.Name = "projectMemberLabel";
            this.projectMemberLabel.Size = new System.Drawing.Size(174, 25);
            this.projectMemberLabel.TabIndex = 4;
            this.projectMemberLabel.Text = "Project Members";
            // 
            // currentTasksDataGrid
            // 
            this.currentTasksDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.currentTasksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentTasksDataGrid.Location = new System.Drawing.Point(617, 31);
            this.currentTasksDataGrid.Name = "currentTasksDataGrid";
            this.currentTasksDataGrid.Size = new System.Drawing.Size(537, 255);
            this.currentTasksDataGrid.TabIndex = 3;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(802, 3);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(147, 25);
            this.taskLabel.TabIndex = 2;
            this.taskLabel.Text = "Current Tasks";
            // 
            // currentProjectLabel
            // 
            this.currentProjectLabel.AutoSize = true;
            this.currentProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProjectLabel.Location = new System.Drawing.Point(210, 3);
            this.currentProjectLabel.Name = "currentProjectLabel";
            this.currentProjectLabel.Size = new System.Drawing.Size(167, 25);
            this.currentProjectLabel.TabIndex = 1;
            this.currentProjectLabel.Text = "Current Projects";
            // 
            // usersProjectDataGridView
            // 
            this.usersProjectDataGridView.AllowUserToAddRows = false;
            this.usersProjectDataGridView.AllowUserToDeleteRows = false;
            this.usersProjectDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.usersProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersProjectDataGridView.Location = new System.Drawing.Point(36, 31);
            this.usersProjectDataGridView.Name = "usersProjectDataGridView";
            this.usersProjectDataGridView.ReadOnly = true;
            this.usersProjectDataGridView.Size = new System.Drawing.Size(540, 255);
            this.usersProjectDataGridView.TabIndex = 0;
            this.usersProjectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersProjectDataGridView_CellContentClick);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.White;
            this.settingsTabPage.Controls.Add(this.applyNewSettingsButton);
            this.settingsTabPage.Controls.Add(this.label1);
            this.settingsTabPage.Controls.Add(this.roleLabel);
            this.settingsTabPage.Controls.Add(this.passwordLabel);
            this.settingsTabPage.Controls.Add(this.usernameLabel);
            this.settingsTabPage.Controls.Add(this.surnameLabel);
            this.settingsTabPage.Controls.Add(this.forenameLabel);
            this.settingsTabPage.Controls.Add(this.pnrLabel);
            this.settingsTabPage.Controls.Add(this.roleTextBox);
            this.settingsTabPage.Controls.Add(this.passwordTextBox);
            this.settingsTabPage.Controls.Add(this.usernameTextBox);
            this.settingsTabPage.Controls.Add(this.surnameTextBox);
            this.settingsTabPage.Controls.Add(this.forenameTextBox);
            this.settingsTabPage.Controls.Add(this.pnrTextBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(1190, 590);
            this.settingsTabPage.TabIndex = 2;
            this.settingsTabPage.Text = "Settings";
            // 
            // applyNewSettingsButton
            // 
            this.applyNewSettingsButton.Location = new System.Drawing.Point(127, 445);
            this.applyNewSettingsButton.Name = "applyNewSettingsButton";
            this.applyNewSettingsButton.Size = new System.Drawing.Size(123, 23);
            this.applyNewSettingsButton.TabIndex = 14;
            this.applyNewSettingsButton.Text = "Apply New Settings";
            this.applyNewSettingsButton.UseVisualStyleBackColor = true;
            this.applyNewSettingsButton.Click += new System.EventHandler(this.applyNewSettingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "My Settings";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(47, 366);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 12;
            this.roleLabel.Text = "Role";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(45, 317);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(45, 256);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(45, 191);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 8;
            this.surnameLabel.Text = "Surname";
            // 
            // forenameLabel
            // 
            this.forenameLabel.AutoSize = true;
            this.forenameLabel.Location = new System.Drawing.Point(45, 140);
            this.forenameLabel.Name = "forenameLabel";
            this.forenameLabel.Size = new System.Drawing.Size(54, 13);
            this.forenameLabel.TabIndex = 7;
            this.forenameLabel.Text = "Forename";
            // 
            // pnrLabel
            // 
            this.pnrLabel.AutoSize = true;
            this.pnrLabel.Location = new System.Drawing.Point(45, 87);
            this.pnrLabel.Name = "pnrLabel";
            this.pnrLabel.Size = new System.Drawing.Size(88, 13);
            this.pnrLabel.TabIndex = 6;
            this.pnrLabel.Text = "Personal Number";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(150, 363);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(100, 20);
            this.roleTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(150, 310);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(150, 249);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(150, 191);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 2;
            // 
            // forenameTextBox
            // 
            this.forenameTextBox.Location = new System.Drawing.Point(150, 140);
            this.forenameTextBox.Name = "forenameTextBox";
            this.forenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.forenameTextBox.TabIndex = 1;
            // 
            // pnrTextBox
            // 
            this.pnrTextBox.Location = new System.Drawing.Point(150, 85);
            this.pnrTextBox.Name = "pnrTextBox";
            this.pnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnrTextBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.finishedProjectsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 590);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Finished Projects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // finishedProjectsDataGridView
            // 
            this.finishedProjectsDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.finishedProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finishedProjectsDataGridView.Location = new System.Drawing.Point(29, 72);
            this.finishedProjectsDataGridView.Name = "finishedProjectsDataGridView";
            this.finishedProjectsDataGridView.Size = new System.Drawing.Size(1133, 473);
            this.finishedProjectsDataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finished Projects";
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 623);
            this.Controls.Add(this.mainTabControl);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            this.mainTabControl.ResumeLayout(false);
            this.myProjectsTabPage.ResumeLayout(false);
            this.myProjectsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTasksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersProjectDataGridView)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedProjectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage myProjectsTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.DataGridView usersProjectDataGridView;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label forenameLabel;
        private System.Windows.Forms.Label pnrLabel;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox forenameTextBox;
        private System.Windows.Forms.TextBox pnrTextBox;
        private System.Windows.Forms.Button applyNewSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView currentMembersDataGrid;
        private System.Windows.Forms.Label projectMemberLabel;
        private System.Windows.Forms.DataGridView currentTasksDataGrid;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label currentProjectLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView finishedProjectsDataGridView;
    }
}