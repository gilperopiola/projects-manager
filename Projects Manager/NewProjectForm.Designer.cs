namespace Projects_Manager
{
    partial class NewProjectForm
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
            this.txtNewProjectName = new System.Windows.Forms.TextBox();
            this.txtNewProjectDescription = new System.Windows.Forms.TextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewProjectName
            // 
            this.txtNewProjectName.Location = new System.Drawing.Point(6, 7);
            this.txtNewProjectName.Name = "txtNewProjectName";
            this.txtNewProjectName.Size = new System.Drawing.Size(260, 20);
            this.txtNewProjectName.TabIndex = 0;
            this.txtNewProjectName.Text = "Project Name";
            // 
            // txtNewProjectDescription
            // 
            this.txtNewProjectDescription.Location = new System.Drawing.Point(6, 33);
            this.txtNewProjectDescription.Multiline = true;
            this.txtNewProjectDescription.Name = "txtNewProjectDescription";
            this.txtNewProjectDescription.Size = new System.Drawing.Size(260, 179);
            this.txtNewProjectDescription.TabIndex = 1;
            this.txtNewProjectDescription.Text = "Project Description";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(6, 218);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(260, 41);
            this.btnCreateProject.TabIndex = 2;
            this.btnCreateProject.Text = "Create";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 268);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.txtNewProjectDescription);
            this.Controls.Add(this.txtNewProjectName);
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewProjectName;
        private System.Windows.Forms.TextBox txtNewProjectDescription;
        private System.Windows.Forms.Button btnCreateProject;
    }
}