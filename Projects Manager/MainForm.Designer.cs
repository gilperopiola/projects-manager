namespace Projects_Manager
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.groupTaskInfo = new System.Windows.Forms.GroupBox();
            this.labelStatic2 = new System.Windows.Forms.Label();
            this.labelStatic1 = new System.Windows.Forms.Label();
            this.txtTaskEstimatedHours = new System.Windows.Forms.TextBox();
            this.txtTaskSpentHours = new System.Windows.Forms.TextBox();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.groupProjectInfo = new System.Windows.Forms.GroupBox();
            this.groupProjectInfoMini = new System.Windows.Forms.GroupBox();
            this.labelProjectHours = new System.Windows.Forms.Label();
            this.labelProjectTasksDone = new System.Windows.Forms.Label();
            this.labelProjectPercentage = new System.Windows.Forms.Label();
            this.labelProjectTasksDoing = new System.Windows.Forms.Label();
            this.labelProjectTasksToDo = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.groupTasks = new System.Windows.Forms.GroupBox();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.btnMarkAsDoing = new System.Windows.Forms.Button();
            this.btnMarkAsToDo = new System.Windows.Forms.Button();
            this.groupDone = new System.Windows.Forms.GroupBox();
            this.listDone = new System.Windows.Forms.ListBox();
            this.groupDoing = new System.Windows.Forms.GroupBox();
            this.listDoing = new System.Windows.Forms.ListBox();
            this.btnAddToDaily = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.groupToDo = new System.Windows.Forms.GroupBox();
            this.listToDo = new System.Windows.Forms.ListBox();
            this.groupProjects = new System.Windows.Forms.GroupBox();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.groupDaily = new System.Windows.Forms.GroupBox();
            this.btnRemoveDaily = new System.Windows.Forms.Button();
            this.listDaily = new System.Windows.Forms.ListBox();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.groupTaskInfo.SuspendLayout();
            this.groupProjectInfo.SuspendLayout();
            this.groupProjectInfoMini.SuspendLayout();
            this.groupTasks.SuspendLayout();
            this.groupDone.SuspendLayout();
            this.groupDoing.SuspendLayout();
            this.groupToDo.SuspendLayout();
            this.groupProjects.SuspendLayout();
            this.groupDaily.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProjects);
            this.tabControl1.Controls.Add(this.tabSkills);
            this.tabControl1.Controls.Add(this.tabCalendar);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 801);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.groupTaskInfo);
            this.tabProjects.Controls.Add(this.groupProjectInfo);
            this.tabProjects.Controls.Add(this.groupTasks);
            this.tabProjects.Controls.Add(this.groupProjects);
            this.tabProjects.Controls.Add(this.groupDaily);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(1109, 775);
            this.tabProjects.TabIndex = 0;
            this.tabProjects.Text = "Projects";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // groupTaskInfo
            // 
            this.groupTaskInfo.Controls.Add(this.labelStatic2);
            this.groupTaskInfo.Controls.Add(this.labelStatic1);
            this.groupTaskInfo.Controls.Add(this.txtTaskEstimatedHours);
            this.groupTaskInfo.Controls.Add(this.txtTaskSpentHours);
            this.groupTaskInfo.Controls.Add(this.btnSaveTask);
            this.groupTaskInfo.Controls.Add(this.txtTaskDescription);
            this.groupTaskInfo.Controls.Add(this.txtTaskName);
            this.groupTaskInfo.Location = new System.Drawing.Point(548, 502);
            this.groupTaskInfo.Name = "groupTaskInfo";
            this.groupTaskInfo.Size = new System.Drawing.Size(552, 270);
            this.groupTaskInfo.TabIndex = 2;
            this.groupTaskInfo.TabStop = false;
            this.groupTaskInfo.Text = "Task Information";
            // 
            // labelStatic2
            // 
            this.labelStatic2.AutoSize = true;
            this.labelStatic2.Location = new System.Drawing.Point(270, 48);
            this.labelStatic2.Name = "labelStatic2";
            this.labelStatic2.Size = new System.Drawing.Size(81, 13);
            this.labelStatic2.TabIndex = 20;
            this.labelStatic2.Text = "estimated hours";
            // 
            // labelStatic1
            // 
            this.labelStatic1.AutoSize = true;
            this.labelStatic1.Location = new System.Drawing.Point(270, 22);
            this.labelStatic1.Name = "labelStatic1";
            this.labelStatic1.Size = new System.Drawing.Size(62, 13);
            this.labelStatic1.TabIndex = 19;
            this.labelStatic1.Text = "spent hours";
            // 
            // txtTaskEstimatedHours
            // 
            this.txtTaskEstimatedHours.Location = new System.Drawing.Point(220, 45);
            this.txtTaskEstimatedHours.Name = "txtTaskEstimatedHours";
            this.txtTaskEstimatedHours.Size = new System.Drawing.Size(45, 20);
            this.txtTaskEstimatedHours.TabIndex = 18;
            // 
            // txtTaskSpentHours
            // 
            this.txtTaskSpentHours.Location = new System.Drawing.Point(220, 19);
            this.txtTaskSpentHours.Name = "txtTaskSpentHours";
            this.txtTaskSpentHours.Size = new System.Drawing.Size(45, 20);
            this.txtTaskSpentHours.TabIndex = 17;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(4, 207);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(210, 47);
            this.btnSaveTask.TabIndex = 16;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(6, 45);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(208, 156);
            this.txtTaskDescription.TabIndex = 15;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(6, 19);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(208, 20);
            this.txtTaskName.TabIndex = 14;
            // 
            // groupProjectInfo
            // 
            this.groupProjectInfo.Controls.Add(this.groupProjectInfoMini);
            this.groupProjectInfo.Controls.Add(this.btnSaveProject);
            this.groupProjectInfo.Controls.Add(this.txtProjectDescription);
            this.groupProjectInfo.Controls.Add(this.txtProjectName);
            this.groupProjectInfo.Location = new System.Drawing.Point(6, 502);
            this.groupProjectInfo.Name = "groupProjectInfo";
            this.groupProjectInfo.Size = new System.Drawing.Size(536, 270);
            this.groupProjectInfo.TabIndex = 1;
            this.groupProjectInfo.TabStop = false;
            this.groupProjectInfo.Text = "Project Information";
            // 
            // groupProjectInfoMini
            // 
            this.groupProjectInfoMini.Controls.Add(this.labelProjectHours);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectTasksDone);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectPercentage);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectTasksDoing);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectTasksToDo);
            this.groupProjectInfoMini.Location = new System.Drawing.Point(228, 19);
            this.groupProjectInfoMini.Name = "groupProjectInfoMini";
            this.groupProjectInfoMini.Size = new System.Drawing.Size(194, 123);
            this.groupProjectInfoMini.TabIndex = 13;
            this.groupProjectInfoMini.TabStop = false;
            this.groupProjectInfoMini.Text = "Info";
            // 
            // labelProjectHours
            // 
            this.labelProjectHours.AutoSize = true;
            this.labelProjectHours.Location = new System.Drawing.Point(6, 26);
            this.labelProjectHours.Name = "labelProjectHours";
            this.labelProjectHours.Size = new System.Drawing.Size(59, 13);
            this.labelProjectHours.TabIndex = 8;
            this.labelProjectHours.Text = "0 / 0 hours";
            // 
            // labelProjectTasksDone
            // 
            this.labelProjectTasksDone.AutoSize = true;
            this.labelProjectTasksDone.Location = new System.Drawing.Point(140, 61);
            this.labelProjectTasksDone.Name = "labelProjectTasksDone";
            this.labelProjectTasksDone.Size = new System.Drawing.Size(45, 13);
            this.labelProjectTasksDone.TabIndex = 12;
            this.labelProjectTasksDone.Text = "Done: 0";
            // 
            // labelProjectPercentage
            // 
            this.labelProjectPercentage.AutoSize = true;
            this.labelProjectPercentage.Location = new System.Drawing.Point(6, 44);
            this.labelProjectPercentage.Name = "labelProjectPercentage";
            this.labelProjectPercentage.Size = new System.Drawing.Size(48, 13);
            this.labelProjectPercentage.TabIndex = 9;
            this.labelProjectPercentage.Text = "0% done";
            // 
            // labelProjectTasksDoing
            // 
            this.labelProjectTasksDoing.AutoSize = true;
            this.labelProjectTasksDoing.Location = new System.Drawing.Point(138, 44);
            this.labelProjectTasksDoing.Name = "labelProjectTasksDoing";
            this.labelProjectTasksDoing.Size = new System.Drawing.Size(47, 13);
            this.labelProjectTasksDoing.TabIndex = 11;
            this.labelProjectTasksDoing.Text = "Doing: 0";
            // 
            // labelProjectTasksToDo
            // 
            this.labelProjectTasksToDo.AutoSize = true;
            this.labelProjectTasksToDo.Location = new System.Drawing.Point(136, 26);
            this.labelProjectTasksToDo.Name = "labelProjectTasksToDo";
            this.labelProjectTasksToDo.Size = new System.Drawing.Size(49, 13);
            this.labelProjectTasksToDo.TabIndex = 10;
            this.labelProjectTasksToDo.Text = "To Do: 0";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(6, 207);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(210, 47);
            this.btnSaveProject.TabIndex = 7;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(8, 45);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(208, 156);
            this.txtProjectDescription.TabIndex = 1;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(8, 19);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(208, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // groupTasks
            // 
            this.groupTasks.Controls.Add(this.btnMarkAsDone);
            this.groupTasks.Controls.Add(this.btnMarkAsDoing);
            this.groupTasks.Controls.Add(this.btnMarkAsToDo);
            this.groupTasks.Controls.Add(this.groupDone);
            this.groupTasks.Controls.Add(this.groupDoing);
            this.groupTasks.Controls.Add(this.btnAddToDaily);
            this.groupTasks.Controls.Add(this.btnNewTask);
            this.groupTasks.Controls.Add(this.groupToDo);
            this.groupTasks.Location = new System.Drawing.Point(459, 6);
            this.groupTasks.Name = "groupTasks";
            this.groupTasks.Size = new System.Drawing.Size(645, 490);
            this.groupTasks.TabIndex = 5;
            this.groupTasks.TabStop = false;
            this.groupTasks.Text = "Tasks";
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.Location = new System.Drawing.Point(434, 433);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(207, 47);
            this.btnMarkAsDone.TabIndex = 11;
            this.btnMarkAsDone.Text = "Mark as Done";
            this.btnMarkAsDone.UseVisualStyleBackColor = true;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // btnMarkAsDoing
            // 
            this.btnMarkAsDoing.Location = new System.Drawing.Point(221, 433);
            this.btnMarkAsDoing.Name = "btnMarkAsDoing";
            this.btnMarkAsDoing.Size = new System.Drawing.Size(207, 47);
            this.btnMarkAsDoing.TabIndex = 10;
            this.btnMarkAsDoing.Text = "Mark as Doing";
            this.btnMarkAsDoing.UseVisualStyleBackColor = true;
            this.btnMarkAsDoing.Click += new System.EventHandler(this.btnMarkAsDoing_Click);
            // 
            // btnMarkAsToDo
            // 
            this.btnMarkAsToDo.Location = new System.Drawing.Point(8, 433);
            this.btnMarkAsToDo.Name = "btnMarkAsToDo";
            this.btnMarkAsToDo.Size = new System.Drawing.Size(207, 47);
            this.btnMarkAsToDo.TabIndex = 9;
            this.btnMarkAsToDo.Text = "Mark as To Do";
            this.btnMarkAsToDo.UseVisualStyleBackColor = true;
            this.btnMarkAsToDo.Click += new System.EventHandler(this.btnMarkAsToDo_Click);
            // 
            // groupDone
            // 
            this.groupDone.Controls.Add(this.listDone);
            this.groupDone.Location = new System.Drawing.Point(434, 17);
            this.groupDone.Name = "groupDone";
            this.groupDone.Size = new System.Drawing.Size(207, 357);
            this.groupDone.TabIndex = 8;
            this.groupDone.TabStop = false;
            this.groupDone.Text = "Done";
            // 
            // listDone
            // 
            this.listDone.FormattingEnabled = true;
            this.listDone.Location = new System.Drawing.Point(6, 19);
            this.listDone.Name = "listDone";
            this.listDone.Size = new System.Drawing.Size(195, 329);
            this.listDone.TabIndex = 6;
            this.listDone.SelectedIndexChanged += new System.EventHandler(this.listDone_SelectedIndexChanged);
            // 
            // groupDoing
            // 
            this.groupDoing.Controls.Add(this.listDoing);
            this.groupDoing.Location = new System.Drawing.Point(221, 17);
            this.groupDoing.Name = "groupDoing";
            this.groupDoing.Size = new System.Drawing.Size(207, 357);
            this.groupDoing.TabIndex = 7;
            this.groupDoing.TabStop = false;
            this.groupDoing.Text = "Doing";
            // 
            // listDoing
            // 
            this.listDoing.FormattingEnabled = true;
            this.listDoing.Location = new System.Drawing.Point(6, 19);
            this.listDoing.Name = "listDoing";
            this.listDoing.Size = new System.Drawing.Size(195, 329);
            this.listDoing.TabIndex = 6;
            this.listDoing.SelectedIndexChanged += new System.EventHandler(this.listDoing_SelectedIndexChanged);
            // 
            // btnAddToDaily
            // 
            this.btnAddToDaily.Location = new System.Drawing.Point(221, 380);
            this.btnAddToDaily.Name = "btnAddToDaily";
            this.btnAddToDaily.Size = new System.Drawing.Size(207, 47);
            this.btnAddToDaily.TabIndex = 6;
            this.btnAddToDaily.Text = "Add to Daily";
            this.btnAddToDaily.UseVisualStyleBackColor = true;
            this.btnAddToDaily.Click += new System.EventHandler(this.btnAddToDaily_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(8, 380);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(207, 47);
            this.btnNewTask.TabIndex = 4;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // groupToDo
            // 
            this.groupToDo.Controls.Add(this.listToDo);
            this.groupToDo.Location = new System.Drawing.Point(8, 17);
            this.groupToDo.Name = "groupToDo";
            this.groupToDo.Size = new System.Drawing.Size(207, 357);
            this.groupToDo.TabIndex = 0;
            this.groupToDo.TabStop = false;
            this.groupToDo.Text = "To Do";
            // 
            // listToDo
            // 
            this.listToDo.FormattingEnabled = true;
            this.listToDo.Location = new System.Drawing.Point(6, 19);
            this.listToDo.Name = "listToDo";
            this.listToDo.Size = new System.Drawing.Size(195, 329);
            this.listToDo.TabIndex = 6;
            this.listToDo.SelectedIndexChanged += new System.EventHandler(this.listToDo_SelectedIndexChanged);
            // 
            // groupProjects
            // 
            this.groupProjects.Controls.Add(this.listProjects);
            this.groupProjects.Controls.Add(this.btnNewProject);
            this.groupProjects.Location = new System.Drawing.Point(234, 6);
            this.groupProjects.Name = "groupProjects";
            this.groupProjects.Size = new System.Drawing.Size(219, 490);
            this.groupProjects.TabIndex = 4;
            this.groupProjects.TabStop = false;
            this.groupProjects.Text = "Projects";
            // 
            // listProjects
            // 
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(6, 19);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(207, 355);
            this.listProjects.TabIndex = 3;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(6, 380);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(207, 47);
            this.btnNewProject.TabIndex = 0;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // groupDaily
            // 
            this.groupDaily.Controls.Add(this.btnRemoveDaily);
            this.groupDaily.Controls.Add(this.listDaily);
            this.groupDaily.Location = new System.Drawing.Point(6, 6);
            this.groupDaily.Name = "groupDaily";
            this.groupDaily.Size = new System.Drawing.Size(222, 490);
            this.groupDaily.TabIndex = 2;
            this.groupDaily.TabStop = false;
            this.groupDaily.Text = "Daily";
            // 
            // btnRemoveDaily
            // 
            this.btnRemoveDaily.Location = new System.Drawing.Point(6, 380);
            this.btnRemoveDaily.Name = "btnRemoveDaily";
            this.btnRemoveDaily.Size = new System.Drawing.Size(210, 47);
            this.btnRemoveDaily.TabIndex = 6;
            this.btnRemoveDaily.Text = "Remove from Daily";
            this.btnRemoveDaily.UseVisualStyleBackColor = true;
            this.btnRemoveDaily.Click += new System.EventHandler(this.btnRemoveDaily_Click);
            // 
            // listDaily
            // 
            this.listDaily.FormattingEnabled = true;
            this.listDaily.Location = new System.Drawing.Point(6, 19);
            this.listDaily.Name = "listDaily";
            this.listDaily.Size = new System.Drawing.Size(210, 355);
            this.listDaily.TabIndex = 1;
            this.listDaily.SelectedIndexChanged += new System.EventHandler(this.listDaily_SelectedIndexChanged);
            // 
            // tabSkills
            // 
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(1109, 775);
            this.tabSkills.TabIndex = 1;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabCalendar
            // 
            this.tabCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1109, 775);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 802);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            this.groupTaskInfo.ResumeLayout(false);
            this.groupTaskInfo.PerformLayout();
            this.groupProjectInfo.ResumeLayout(false);
            this.groupProjectInfo.PerformLayout();
            this.groupProjectInfoMini.ResumeLayout(false);
            this.groupProjectInfoMini.PerformLayout();
            this.groupTasks.ResumeLayout(false);
            this.groupDone.ResumeLayout(false);
            this.groupDoing.ResumeLayout(false);
            this.groupToDo.ResumeLayout(false);
            this.groupProjects.ResumeLayout(false);
            this.groupDaily.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.GroupBox groupDaily;
        private System.Windows.Forms.ListBox listDaily;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.GroupBox groupTasks;
        private System.Windows.Forms.GroupBox groupToDo;
        private System.Windows.Forms.GroupBox groupProjects;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnAddToDaily;
        private System.Windows.Forms.Button btnRemoveDaily;
        private System.Windows.Forms.GroupBox groupDone;
        private System.Windows.Forms.ListBox listDone;
        private System.Windows.Forms.GroupBox groupDoing;
        private System.Windows.Forms.ListBox listDoing;
        private System.Windows.Forms.ListBox listToDo;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.Button btnMarkAsDoing;
        private System.Windows.Forms.Button btnMarkAsToDo;
        private System.Windows.Forms.GroupBox groupTaskInfo;
        private System.Windows.Forms.GroupBox groupProjectInfo;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label labelProjectPercentage;
        private System.Windows.Forms.Label labelProjectHours;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label labelProjectTasksDone;
        private System.Windows.Forms.Label labelProjectTasksDoing;
        private System.Windows.Forms.Label labelProjectTasksToDo;
        private System.Windows.Forms.GroupBox groupProjectInfoMini;
        private System.Windows.Forms.Label labelStatic2;
        private System.Windows.Forms.Label labelStatic1;
        private System.Windows.Forms.TextBox txtTaskEstimatedHours;
        private System.Windows.Forms.TextBox txtTaskSpentHours;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskName;
    }
}

