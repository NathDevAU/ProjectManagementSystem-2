namespace ProjectManagementSystem_v_0_1.View
{
    partial class EditProjectForm
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
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.projectBudgetLabel = new System.Windows.Forms.Label();
            this.estimatedBudgetBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.deadlineDateLabel = new System.Windows.Forms.Label();
            this.deadlineDatePicker = new System.Windows.Forms.DateTimePicker();
            this.projectleaderPnrLabel = new System.Windows.Forms.Label();
            this.projectLeaderPnrComboBox = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pnoLabel = new System.Windows.Forms.Label();
            this.pnoTextBox = new System.Windows.Forms.TextBox();
            this.pMSDataSet = new ProjectManagementSystem_v_0_1.PMSDataSet();
            this.pMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet1 = new ProjectManagementSystem_v_0_1.PMSDataSet1();
            this.projectMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectMemberTableAdapter = new ProjectManagementSystem_v_0_1.PMSDataSet1TableAdapters.ProjectMemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(32, 58);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(71, 13);
            this.projectNameLabel.TabIndex = 2;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectNameBox
            // 
            this.projectNameBox.Location = new System.Drawing.Point(148, 55);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(100, 20);
            this.projectNameBox.TabIndex = 7;
            // 
            // projectBudgetLabel
            // 
            this.projectBudgetLabel.AutoSize = true;
            this.projectBudgetLabel.Location = new System.Drawing.Point(32, 94);
            this.projectBudgetLabel.Name = "projectBudgetLabel";
            this.projectBudgetLabel.Size = new System.Drawing.Size(90, 13);
            this.projectBudgetLabel.TabIndex = 8;
            this.projectBudgetLabel.Text = "Estimated Budget";
            // 
            // estimatedBudgetBox
            // 
            this.estimatedBudgetBox.Location = new System.Drawing.Point(148, 91);
            this.estimatedBudgetBox.Name = "estimatedBudgetBox";
            this.estimatedBudgetBox.Size = new System.Drawing.Size(100, 20);
            this.estimatedBudgetBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(32, 134);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(148, 131);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionBox.TabIndex = 11;
            // 
            // deadlineDateLabel
            // 
            this.deadlineDateLabel.AutoSize = true;
            this.deadlineDateLabel.Location = new System.Drawing.Point(32, 179);
            this.deadlineDateLabel.Name = "deadlineDateLabel";
            this.deadlineDateLabel.Size = new System.Drawing.Size(49, 13);
            this.deadlineDateLabel.TabIndex = 12;
            this.deadlineDateLabel.Text = "Deadline";
            // 
            // deadlineDatePicker
            // 
            this.deadlineDatePicker.Location = new System.Drawing.Point(148, 173);
            this.deadlineDatePicker.Name = "deadlineDatePicker";
            this.deadlineDatePicker.Size = new System.Drawing.Size(151, 20);
            this.deadlineDatePicker.TabIndex = 13;
            // 
            // projectleaderPnrLabel
            // 
            this.projectleaderPnrLabel.AutoSize = true;
            this.projectleaderPnrLabel.Location = new System.Drawing.Point(34, 221);
            this.projectleaderPnrLabel.Name = "projectleaderPnrLabel";
            this.projectleaderPnrLabel.Size = new System.Drawing.Size(88, 13);
            this.projectleaderPnrLabel.TabIndex = 14;
            this.projectleaderPnrLabel.Text = "Projectleader Pnr";
            // 
            // projectLeaderPnrComboBox
            // 
            this.projectLeaderPnrComboBox.DataSource = this.projectMemberBindingSource;
            this.projectLeaderPnrComboBox.DisplayMember = "PNR";
            this.projectLeaderPnrComboBox.FormattingEnabled = true;
            this.projectLeaderPnrComboBox.Location = new System.Drawing.Point(148, 218);
            this.projectLeaderPnrComboBox.Name = "projectLeaderPnrComboBox";
            this.projectLeaderPnrComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectLeaderPnrComboBox.TabIndex = 15;
            this.projectLeaderPnrComboBox.ValueMember = "PNR";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(105, 259);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(194, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pnoLabel
            // 
            this.pnoLabel.AutoSize = true;
            this.pnoLabel.Location = new System.Drawing.Point(34, 16);
            this.pnoLabel.Name = "pnoLabel";
            this.pnoLabel.Size = new System.Drawing.Size(80, 13);
            this.pnoLabel.TabIndex = 18;
            this.pnoLabel.Text = "Project Number";
            // 
            // pnoTextBox
            // 
            this.pnoTextBox.Location = new System.Drawing.Point(148, 16);
            this.pnoTextBox.Name = "pnoTextBox";
            this.pnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnoTextBox.TabIndex = 19;
            // 
            // pMSDataSet
            // 
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pMSDataSetBindingSource
            // 
            this.pMSDataSetBindingSource.DataSource = this.pMSDataSet;
            this.pMSDataSetBindingSource.Position = 0;
            // 
            // pMSDataSet1
            // 
            this.pMSDataSet1.DataSetName = "PMSDataSet1";
            this.pMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectMemberBindingSource
            // 
            this.projectMemberBindingSource.DataMember = "ProjectMember";
            this.projectMemberBindingSource.DataSource = this.pMSDataSet1;
            // 
            // projectMemberTableAdapter
            // 
            this.projectMemberTableAdapter.ClearBeforeFill = true;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 298);
            this.Controls.Add(this.pnoTextBox);
            this.Controls.Add(this.pnoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.projectLeaderPnrComboBox);
            this.Controls.Add(this.projectleaderPnrLabel);
            this.Controls.Add(this.deadlineDatePicker);
            this.Controls.Add(this.deadlineDateLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.estimatedBudgetBox);
            this.Controls.Add(this.projectBudgetLabel);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameBox;
        private System.Windows.Forms.Label projectBudgetLabel;
        private System.Windows.Forms.TextBox estimatedBudgetBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label deadlineDateLabel;
        private System.Windows.Forms.DateTimePicker deadlineDatePicker;
        private System.Windows.Forms.Label projectleaderPnrLabel;
        private System.Windows.Forms.ComboBox projectLeaderPnrComboBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pnoLabel;
        private System.Windows.Forms.TextBox pnoTextBox;
        private System.Windows.Forms.BindingSource pMSDataSetBindingSource;
        private PMSDataSet pMSDataSet;
        private PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource projectMemberBindingSource;
        private PMSDataSet1TableAdapters.ProjectMemberTableAdapter projectMemberTableAdapter;
    }
}