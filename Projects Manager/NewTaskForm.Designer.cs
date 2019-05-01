namespace Projects_Manager
{
    partial class NewTaskForm
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
            this.txtNewTaskName = new System.Windows.Forms.TextBox();
            this.txtNewTaskDescription = new System.Windows.Forms.TextBox();
            this.txtNewTaskHours = new System.Windows.Forms.TextBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewTaskName
            // 
            this.txtNewTaskName.Location = new System.Drawing.Point(5, 6);
            this.txtNewTaskName.Name = "txtNewTaskName";
            this.txtNewTaskName.Size = new System.Drawing.Size(265, 20);
            this.txtNewTaskName.TabIndex = 0;
            this.txtNewTaskName.Text = "Task Name";
            // 
            // txtNewTaskDescription
            // 
            this.txtNewTaskDescription.Location = new System.Drawing.Point(5, 32);
            this.txtNewTaskDescription.Multiline = true;
            this.txtNewTaskDescription.Name = "txtNewTaskDescription";
            this.txtNewTaskDescription.Size = new System.Drawing.Size(265, 161);
            this.txtNewTaskDescription.TabIndex = 1;
            // 
            // txtNewTaskHours
            // 
            this.txtNewTaskHours.Location = new System.Drawing.Point(5, 199);
            this.txtNewTaskHours.Name = "txtNewTaskHours";
            this.txtNewTaskHours.Size = new System.Drawing.Size(265, 20);
            this.txtNewTaskHours.TabIndex = 2;
            this.txtNewTaskHours.Text = "0.25";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(5, 223);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(265, 42);
            this.btnCreateTask.TabIndex = 3;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 269);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtNewTaskHours);
            this.Controls.Add(this.txtNewTaskDescription);
            this.Controls.Add(this.txtNewTaskName);
            this.Name = "NewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewTaskName;
        private System.Windows.Forms.TextBox txtNewTaskDescription;
        private System.Windows.Forms.TextBox txtNewTaskHours;
        private System.Windows.Forms.Button btnCreateTask;
    }
}