namespace ProjectManagementSystem_v_0_1.View
{
    partial class TaskEditWindowsForm
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
            this.TNoLabel = new System.Windows.Forms.Label();
            this.PNoLabel = new System.Windows.Forms.Label();
            this.TNameLabel = new System.Windows.Forms.Label();
            this.TDescLabel = new System.Windows.Forms.Label();
            this.TDeadlineLabel = new System.Windows.Forms.Label();
            this.TNoTextBox = new System.Windows.Forms.TextBox();
            this.PNoTextBox = new System.Windows.Forms.TextBox();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.TDescTextBox = new System.Windows.Forms.TextBox();
            this.TDeadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNoLabel
            // 
            this.TNoLabel.AutoSize = true;
            this.TNoLabel.Location = new System.Drawing.Point(39, 56);
            this.TNoLabel.Name = "TNoLabel";
            this.TNoLabel.Size = new System.Drawing.Size(74, 13);
            this.TNoLabel.TabIndex = 30;
            this.TNoLabel.Text = "Task Number:";
            // 
            // PNoLabel
            // 
            this.PNoLabel.AutoSize = true;
            this.PNoLabel.Location = new System.Drawing.Point(39, 97);
            this.PNoLabel.Name = "PNoLabel";
            this.PNoLabel.Size = new System.Drawing.Size(83, 13);
            this.PNoLabel.TabIndex = 31;
            this.PNoLabel.Text = "Project Number:";
            // 
            // TNameLabel
            // 
            this.TNameLabel.AutoSize = true;
            this.TNameLabel.Location = new System.Drawing.Point(39, 139);
            this.TNameLabel.Name = "TNameLabel";
            this.TNameLabel.Size = new System.Drawing.Size(65, 13);
            this.TNameLabel.TabIndex = 32;
            this.TNameLabel.Text = "Task Name:";
            // 
            // TDescLabel
            // 
            this.TDescLabel.AutoSize = true;
            this.TDescLabel.Location = new System.Drawing.Point(39, 181);
            this.TDescLabel.Name = "TDescLabel";
            this.TDescLabel.Size = new System.Drawing.Size(90, 13);
            this.TDescLabel.TabIndex = 33;
            this.TDescLabel.Text = "Task Description:";
            // 
            // TDeadlineLabel
            // 
            this.TDeadlineLabel.AutoSize = true;
            this.TDeadlineLabel.Location = new System.Drawing.Point(43, 225);
            this.TDeadlineLabel.Name = "TDeadlineLabel";
            this.TDeadlineLabel.Size = new System.Drawing.Size(79, 13);
            this.TDeadlineLabel.TabIndex = 34;
            this.TDeadlineLabel.Text = "Task Deadline:";
            // 
            // TNoTextBox
            // 
            this.TNoTextBox.Enabled = false;
            this.TNoTextBox.Location = new System.Drawing.Point(140, 53);
            this.TNoTextBox.Name = "TNoTextBox";
            this.TNoTextBox.Size = new System.Drawing.Size(120, 20);
            this.TNoTextBox.TabIndex = 35;
            // 
            // PNoTextBox
            // 
            this.PNoTextBox.Enabled = false;
            this.PNoTextBox.Location = new System.Drawing.Point(140, 94);
            this.PNoTextBox.Name = "PNoTextBox";
            this.PNoTextBox.Size = new System.Drawing.Size(120, 20);
            this.PNoTextBox.TabIndex = 36;
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(140, 136);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.TNameTextBox.TabIndex = 37;
            // 
            // TDescTextBox
            // 
            this.TDescTextBox.Location = new System.Drawing.Point(140, 178);
            this.TDescTextBox.Name = "TDescTextBox";
            this.TDescTextBox.Size = new System.Drawing.Size(120, 20);
            this.TDescTextBox.TabIndex = 38;
            // 
            // TDeadlineDateTimePicker
            // 
            this.TDeadlineDateTimePicker.Location = new System.Drawing.Point(140, 219);
            this.TDeadlineDateTimePicker.Name = "TDeadlineDateTimePicker";
            this.TDeadlineDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.TDeadlineDateTimePicker.TabIndex = 39;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(235, 285);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 40;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Location = new System.Drawing.Point(140, 285);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(75, 23);
            this.EditTaskButton.TabIndex = 41;
            this.EditTaskButton.Text = "Apply";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click_1);
            // 
            // TaskEditWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 350);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TDeadlineDateTimePicker);
            this.Controls.Add(this.TDescTextBox);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.PNoTextBox);
            this.Controls.Add(this.TNoTextBox);
            this.Controls.Add(this.TDeadlineLabel);
            this.Controls.Add(this.TDescLabel);
            this.Controls.Add(this.TNameLabel);
            this.Controls.Add(this.PNoLabel);
            this.Controls.Add(this.TNoLabel);
            this.Name = "TaskEditWindowsForm";
            this.Text = "TaskEditWindowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TNoLabel;
        private System.Windows.Forms.Label PNoLabel;
        private System.Windows.Forms.Label TNameLabel;
        private System.Windows.Forms.Label TDescLabel;
        private System.Windows.Forms.Label TDeadlineLabel;
        private System.Windows.Forms.TextBox TNoTextBox;
        private System.Windows.Forms.TextBox PNoTextBox;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.TextBox TDescTextBox;
        private System.Windows.Forms.DateTimePicker TDeadlineDateTimePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditTaskButton;
    }
}