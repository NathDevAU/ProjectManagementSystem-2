namespace ProjectManagementSystem_v_0_1.View
{
    partial class TaskAddWindowsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PNoComboBox = new System.Windows.Forms.ComboBox();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.TDescTextBox = new System.Windows.Forms.TextBox();
            this.TDeadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Belongs to project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task Deadline";
            // 
            // PNoComboBox
            // 
            this.PNoComboBox.FormattingEnabled = true;
            this.PNoComboBox.Location = new System.Drawing.Point(144, 33);
            this.PNoComboBox.Name = "PNoComboBox";
            this.PNoComboBox.Size = new System.Drawing.Size(121, 21);
            this.PNoComboBox.TabIndex = 6;
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(144, 79);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.TNameTextBox.TabIndex = 7;
            // 
            // TDescTextBox
            // 
            this.TDescTextBox.Location = new System.Drawing.Point(144, 122);
            this.TDescTextBox.Name = "TDescTextBox";
            this.TDescTextBox.Size = new System.Drawing.Size(120, 20);
            this.TDescTextBox.TabIndex = 8;
            // 
            // TDeadlineDateTimePicker
            // 
            this.TDeadlineDateTimePicker.Location = new System.Drawing.Point(147, 164);
            this.TDeadlineDateTimePicker.Name = "TDeadlineDateTimePicker";
            this.TDeadlineDateTimePicker.Size = new System.Drawing.Size(157, 20);
            this.TDeadlineDateTimePicker.TabIndex = 9;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(147, 217);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 26);
            this.AddTaskButton.TabIndex = 10;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(242, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 26);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TaskAddWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 268);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.TDeadlineDateTimePicker);
            this.Controls.Add(this.TDescTextBox);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.PNoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TaskAddWindowsForm";
            this.Text = "TaskAddWindowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PNoComboBox;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.TextBox TDescTextBox;
        private System.Windows.Forms.DateTimePicker TDeadlineDateTimePicker;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}