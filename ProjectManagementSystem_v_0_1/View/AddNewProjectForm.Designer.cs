namespace ProjectManagementSystem_v_0_1.View
{
    partial class AddNewProjectForm
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
            this.components = new System.ComponentModel.Container();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectBudgetLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineDateLabel = new System.Windows.Forms.Label();
            this.projectleaderPnrLabel = new System.Windows.Forms.Label();
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.estimatedBudgetBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.deadlineDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.projectLeaderPnrComboBox = new System.Windows.Forms.ComboBox();
            this.pMSDataSet = new ProjectManagementSystem_v_0_1.PMSDataSet();
            this.projectMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectMemberTableAdapter = new ProjectManagementSystem_v_0_1.PMSDataSetTableAdapters.ProjectMemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(37, 48);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(71, 13);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectBudgetLabel
            // 
            this.projectBudgetLabel.AutoSize = true;
            this.projectBudgetLabel.Location = new System.Drawing.Point(37, 80);
            this.projectBudgetLabel.Name = "projectBudgetLabel";
            this.projectBudgetLabel.Size = new System.Drawing.Size(90, 13);
            this.projectBudgetLabel.TabIndex = 2;
            this.projectBudgetLabel.Text = "Estimated Budget";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(37, 112);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // deadlineDateLabel
            // 
            this.deadlineDateLabel.AutoSize = true;
            this.deadlineDateLabel.Location = new System.Drawing.Point(37, 147);
            this.deadlineDateLabel.Name = "deadlineDateLabel";
            this.deadlineDateLabel.Size = new System.Drawing.Size(49, 13);
            this.deadlineDateLabel.TabIndex = 4;
            this.deadlineDateLabel.Text = "Deadline";
            // 
            // projectleaderPnrLabel
            // 
            this.projectleaderPnrLabel.AutoSize = true;
            this.projectleaderPnrLabel.Location = new System.Drawing.Point(37, 185);
            this.projectleaderPnrLabel.Name = "projectleaderPnrLabel";
            this.projectleaderPnrLabel.Size = new System.Drawing.Size(88, 13);
            this.projectleaderPnrLabel.TabIndex = 5;
            this.projectleaderPnrLabel.Text = "Projectleader Pnr";
            // 
            // projectNameBox
            // 
            this.projectNameBox.Location = new System.Drawing.Point(157, 48);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(100, 20);
            this.projectNameBox.TabIndex = 6;
            // 
            // estimatedBudgetBox
            // 
            this.estimatedBudgetBox.Location = new System.Drawing.Point(157, 80);
            this.estimatedBudgetBox.Name = "estimatedBudgetBox";
            this.estimatedBudgetBox.Size = new System.Drawing.Size(100, 20);
            this.estimatedBudgetBox.TabIndex = 7;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(157, 112);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionBox.TabIndex = 8;
            // 
            // deadlineDatePicker
            // 
            this.deadlineDatePicker.Location = new System.Drawing.Point(157, 147);
            this.deadlineDatePicker.Name = "deadlineDatePicker";
            this.deadlineDatePicker.Size = new System.Drawing.Size(151, 20);
            this.deadlineDatePicker.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(122, 228);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // projectLeaderPnrComboBox
            // 
            this.projectLeaderPnrComboBox.DataSource = this.projectMemberBindingSource;
            this.projectLeaderPnrComboBox.DisplayMember = "PNR";
            this.projectLeaderPnrComboBox.FormattingEnabled = true;
            this.projectLeaderPnrComboBox.Location = new System.Drawing.Point(157, 182);
            this.projectLeaderPnrComboBox.Name = "projectLeaderPnrComboBox";
            this.projectLeaderPnrComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectLeaderPnrComboBox.TabIndex = 13;
            this.projectLeaderPnrComboBox.ValueMember = "PNR";
            // 
            // pMSDataSet
            // 
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectMemberBindingSource
            // 
            this.projectMemberBindingSource.DataMember = "ProjectMember";
            this.projectMemberBindingSource.DataSource = this.pMSDataSet;
            // 
            // projectMemberTableAdapter
            // 
            this.projectMemberTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 267);
            this.Controls.Add(this.projectLeaderPnrComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deadlineDatePicker);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.estimatedBudgetBox);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.projectleaderPnrLabel);
            this.Controls.Add(this.deadlineDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.projectBudgetLabel);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "AddNewProjectForm";
            this.Text = "AddNewProjectForm";
            this.Load += new System.EventHandler(this.AddNewProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectBudgetLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label deadlineDateLabel;
        private System.Windows.Forms.Label projectleaderPnrLabel;
        private System.Windows.Forms.TextBox projectNameBox;
        private System.Windows.Forms.TextBox estimatedBudgetBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.DateTimePicker deadlineDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox projectLeaderPnrComboBox;
        private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource projectMemberBindingSource;
        private PMSDataSetTableAdapters.ProjectMemberTableAdapter projectMemberTableAdapter;
    }
}