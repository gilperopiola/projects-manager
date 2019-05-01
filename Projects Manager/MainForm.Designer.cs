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
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.groupDailyWeekly = new System.Windows.Forms.GroupBox();
            this.listDaily = new System.Windows.Forms.ListBox();
            this.listWeekly = new System.Windows.Forms.ListBox();
            this.groupTaskInfo = new System.Windows.Forms.GroupBox();
            this.btnRemoveFromWeekly = new System.Windows.Forms.Button();
            this.btnAddToWeekly = new System.Windows.Forms.Button();
            this.btnRemoveFromDaily = new System.Windows.Forms.Button();
            this.labelStatic2 = new System.Windows.Forms.Label();
            this.labelStatic1 = new System.Windows.Forms.Label();
            this.txtTaskEstimatedHours = new System.Windows.Forms.TextBox();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.btnAddToDaily = new System.Windows.Forms.Button();
            this.btnMarkAsToDo = new System.Windows.Forms.Button();
            this.txtTaskSpentHours = new System.Windows.Forms.TextBox();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.groupProjectInfo = new System.Windows.Forms.GroupBox();
            this.groupProjectInfoMini = new System.Windows.Forms.GroupBox();
            this.labelProjectHours = new System.Windows.Forms.Label();
            this.labelProjectTasksDone = new System.Windows.Forms.Label();
            this.labelProjectPercentage = new System.Windows.Forms.Label();
            this.labelProjectTasksToDo = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.listToDo = new System.Windows.Forms.ListBox();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.btnAddChores = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.groupDailyWeekly.SuspendLayout();
            this.groupTaskInfo.SuspendLayout();
            this.groupProjectInfo.SuspendLayout();
            this.groupProjectInfoMini.SuspendLayout();
            this.groupMain.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1162, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.Color.SlateBlue;
            this.tabProjects.Controls.Add(this.groupActions);
            this.tabProjects.Controls.Add(this.groupDailyWeekly);
            this.tabProjects.Controls.Add(this.groupTaskInfo);
            this.tabProjects.Controls.Add(this.groupProjectInfo);
            this.tabProjects.Controls.Add(this.groupMain);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(1154, 565);
            this.tabProjects.TabIndex = 0;
            this.tabProjects.Text = "Projects";
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.btnAddChores);
            this.groupActions.Controls.Add(this.btnNewProject);
            this.groupActions.Controls.Add(this.btnNewTask);
            this.groupActions.ForeColor = System.Drawing.SystemColors.Control;
            this.groupActions.Location = new System.Drawing.Point(927, 6);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(219, 358);
            this.groupActions.TabIndex = 8;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Actions";
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Tomato;
            this.btnNewProject.Location = new System.Drawing.Point(6, 18);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(207, 47);
            this.btnNewProject.TabIndex = 6;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click_1);
            // 
            // btnNewTask
            // 
            this.btnNewTask.BackColor = System.Drawing.Color.Tomato;
            this.btnNewTask.Location = new System.Drawing.Point(6, 71);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(207, 47);
            this.btnNewTask.TabIndex = 4;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // groupDailyWeekly
            // 
            this.groupDailyWeekly.Controls.Add(this.listDaily);
            this.groupDailyWeekly.Controls.Add(this.listWeekly);
            this.groupDailyWeekly.Location = new System.Drawing.Point(3, 267);
            this.groupDailyWeekly.Name = "groupDailyWeekly";
            this.groupDailyWeekly.Size = new System.Drawing.Size(438, 294);
            this.groupDailyWeekly.TabIndex = 7;
            this.groupDailyWeekly.TabStop = false;
            // 
            // listDaily
            // 
            this.listDaily.FormattingEnabled = true;
            this.listDaily.Location = new System.Drawing.Point(9, 17);
            this.listDaily.Name = "listDaily";
            this.listDaily.Size = new System.Drawing.Size(207, 264);
            this.listDaily.TabIndex = 1;
            this.listDaily.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listDaily_MouseClick);
            // 
            // listWeekly
            // 
            this.listWeekly.FormattingEnabled = true;
            this.listWeekly.Location = new System.Drawing.Point(222, 17);
            this.listWeekly.Name = "listWeekly";
            this.listWeekly.Size = new System.Drawing.Size(207, 264);
            this.listWeekly.TabIndex = 4;
            this.listWeekly.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listWeekly_MouseClick);
            // 
            // groupTaskInfo
            // 
            this.groupTaskInfo.Controls.Add(this.btnRemoveFromWeekly);
            this.groupTaskInfo.Controls.Add(this.btnAddToWeekly);
            this.groupTaskInfo.Controls.Add(this.btnRemoveFromDaily);
            this.groupTaskInfo.Controls.Add(this.labelStatic2);
            this.groupTaskInfo.Controls.Add(this.labelStatic1);
            this.groupTaskInfo.Controls.Add(this.txtTaskEstimatedHours);
            this.groupTaskInfo.Controls.Add(this.btnMarkAsDone);
            this.groupTaskInfo.Controls.Add(this.btnAddToDaily);
            this.groupTaskInfo.Controls.Add(this.btnMarkAsToDo);
            this.groupTaskInfo.Controls.Add(this.txtTaskSpentHours);
            this.groupTaskInfo.Controls.Add(this.btnSaveTask);
            this.groupTaskInfo.Controls.Add(this.txtTaskDescription);
            this.groupTaskInfo.Controls.Add(this.txtTaskName);
            this.groupTaskInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.groupTaskInfo.Location = new System.Drawing.Point(452, 240);
            this.groupTaskInfo.Name = "groupTaskInfo";
            this.groupTaskInfo.Size = new System.Drawing.Size(460, 321);
            this.groupTaskInfo.TabIndex = 2;
            this.groupTaskInfo.TabStop = false;
            this.groupTaskInfo.Text = "Task Information";
            // 
            // btnRemoveFromWeekly
            // 
            this.btnRemoveFromWeekly.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveFromWeekly.Location = new System.Drawing.Point(229, 180);
            this.btnRemoveFromWeekly.Name = "btnRemoveFromWeekly";
            this.btnRemoveFromWeekly.Size = new System.Drawing.Size(207, 47);
            this.btnRemoveFromWeekly.TabIndex = 23;
            this.btnRemoveFromWeekly.Text = "Remove From Weekly";
            this.btnRemoveFromWeekly.UseVisualStyleBackColor = false;
            this.btnRemoveFromWeekly.Click += new System.EventHandler(this.btnRemoveFromWeekly_Click);
            // 
            // btnAddToWeekly
            // 
            this.btnAddToWeekly.BackColor = System.Drawing.Color.Tomato;
            this.btnAddToWeekly.Location = new System.Drawing.Point(229, 131);
            this.btnAddToWeekly.Name = "btnAddToWeekly";
            this.btnAddToWeekly.Size = new System.Drawing.Size(207, 47);
            this.btnAddToWeekly.TabIndex = 22;
            this.btnAddToWeekly.Text = "Add to Weekly";
            this.btnAddToWeekly.UseVisualStyleBackColor = false;
            this.btnAddToWeekly.Click += new System.EventHandler(this.btnAddToWeekly_Click);
            // 
            // btnRemoveFromDaily
            // 
            this.btnRemoveFromDaily.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveFromDaily.Location = new System.Drawing.Point(229, 68);
            this.btnRemoveFromDaily.Name = "btnRemoveFromDaily";
            this.btnRemoveFromDaily.Size = new System.Drawing.Size(207, 47);
            this.btnRemoveFromDaily.TabIndex = 21;
            this.btnRemoveFromDaily.Text = "Remove From Daily";
            this.btnRemoveFromDaily.UseVisualStyleBackColor = false;
            this.btnRemoveFromDaily.Click += new System.EventHandler(this.btnRemoveFromDaily_Click);
            // 
            // labelStatic2
            // 
            this.labelStatic2.AutoSize = true;
            this.labelStatic2.Location = new System.Drawing.Point(56, 240);
            this.labelStatic2.Name = "labelStatic2";
            this.labelStatic2.Size = new System.Drawing.Size(81, 13);
            this.labelStatic2.TabIndex = 20;
            this.labelStatic2.Text = "estimated hours";
            // 
            // labelStatic1
            // 
            this.labelStatic1.AutoSize = true;
            this.labelStatic1.Location = new System.Drawing.Point(56, 214);
            this.labelStatic1.Name = "labelStatic1";
            this.labelStatic1.Size = new System.Drawing.Size(62, 13);
            this.labelStatic1.TabIndex = 19;
            this.labelStatic1.Text = "spent hours";
            // 
            // txtTaskEstimatedHours
            // 
            this.txtTaskEstimatedHours.Location = new System.Drawing.Point(8, 237);
            this.txtTaskEstimatedHours.Name = "txtTaskEstimatedHours";
            this.txtTaskEstimatedHours.Size = new System.Drawing.Size(45, 20);
            this.txtTaskEstimatedHours.TabIndex = 18;
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.BackColor = System.Drawing.Color.Tomato;
            this.btnMarkAsDone.Location = new System.Drawing.Point(373, 245);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(63, 47);
            this.btnMarkAsDone.TabIndex = 11;
            this.btnMarkAsDone.Text = "Mark as Done";
            this.btnMarkAsDone.UseVisualStyleBackColor = false;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // btnAddToDaily
            // 
            this.btnAddToDaily.BackColor = System.Drawing.Color.Tomato;
            this.btnAddToDaily.Location = new System.Drawing.Point(229, 19);
            this.btnAddToDaily.Name = "btnAddToDaily";
            this.btnAddToDaily.Size = new System.Drawing.Size(207, 47);
            this.btnAddToDaily.TabIndex = 6;
            this.btnAddToDaily.Text = "Add to Daily";
            this.btnAddToDaily.UseVisualStyleBackColor = false;
            this.btnAddToDaily.Click += new System.EventHandler(this.btnAddToDaily_Click);
            // 
            // btnMarkAsToDo
            // 
            this.btnMarkAsToDo.BackColor = System.Drawing.Color.Tomato;
            this.btnMarkAsToDo.Location = new System.Drawing.Point(229, 246);
            this.btnMarkAsToDo.Name = "btnMarkAsToDo";
            this.btnMarkAsToDo.Size = new System.Drawing.Size(56, 47);
            this.btnMarkAsToDo.TabIndex = 9;
            this.btnMarkAsToDo.Text = "Mark as To Do";
            this.btnMarkAsToDo.UseVisualStyleBackColor = false;
            this.btnMarkAsToDo.Click += new System.EventHandler(this.btnMarkAsToDo_Click);
            // 
            // txtTaskSpentHours
            // 
            this.txtTaskSpentHours.Location = new System.Drawing.Point(8, 211);
            this.txtTaskSpentHours.Name = "txtTaskSpentHours";
            this.txtTaskSpentHours.Size = new System.Drawing.Size(45, 20);
            this.txtTaskSpentHours.TabIndex = 17;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.BackColor = System.Drawing.Color.Tomato;
            this.btnSaveTask.Location = new System.Drawing.Point(6, 268);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(210, 47);
            this.btnSaveTask.TabIndex = 16;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = false;
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
            this.groupProjectInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.groupProjectInfo.Location = new System.Drawing.Point(452, 6);
            this.groupProjectInfo.Name = "groupProjectInfo";
            this.groupProjectInfo.Size = new System.Drawing.Size(460, 228);
            this.groupProjectInfo.TabIndex = 1;
            this.groupProjectInfo.TabStop = false;
            this.groupProjectInfo.Text = "Project Information";
            // 
            // groupProjectInfoMini
            // 
            this.groupProjectInfoMini.Controls.Add(this.labelProjectHours);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectTasksDone);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectPercentage);
            this.groupProjectInfoMini.Controls.Add(this.labelProjectTasksToDo);
            this.groupProjectInfoMini.ForeColor = System.Drawing.SystemColors.Control;
            this.groupProjectInfoMini.Location = new System.Drawing.Point(222, 14);
            this.groupProjectInfoMini.Name = "groupProjectInfoMini";
            this.groupProjectInfoMini.Size = new System.Drawing.Size(232, 206);
            this.groupProjectInfoMini.TabIndex = 13;
            this.groupProjectInfoMini.TabStop = false;
            this.groupProjectInfoMini.Text = "Info";
            // 
            // labelProjectHours
            // 
            this.labelProjectHours.AutoSize = true;
            this.labelProjectHours.Location = new System.Drawing.Point(82, 38);
            this.labelProjectHours.Name = "labelProjectHours";
            this.labelProjectHours.Size = new System.Drawing.Size(59, 13);
            this.labelProjectHours.TabIndex = 8;
            this.labelProjectHours.Text = "0 / 0 hours";
            // 
            // labelProjectTasksDone
            // 
            this.labelProjectTasksDone.AutoSize = true;
            this.labelProjectTasksDone.Location = new System.Drawing.Point(90, 136);
            this.labelProjectTasksDone.Name = "labelProjectTasksDone";
            this.labelProjectTasksDone.Size = new System.Drawing.Size(45, 13);
            this.labelProjectTasksDone.TabIndex = 12;
            this.labelProjectTasksDone.Text = "Done: 0";
            // 
            // labelProjectPercentage
            // 
            this.labelProjectPercentage.AutoSize = true;
            this.labelProjectPercentage.Location = new System.Drawing.Point(86, 60);
            this.labelProjectPercentage.Name = "labelProjectPercentage";
            this.labelProjectPercentage.Size = new System.Drawing.Size(48, 13);
            this.labelProjectPercentage.TabIndex = 9;
            this.labelProjectPercentage.Text = "0% done";
            // 
            // labelProjectTasksToDo
            // 
            this.labelProjectTasksToDo.AutoSize = true;
            this.labelProjectTasksToDo.Location = new System.Drawing.Point(86, 113);
            this.labelProjectTasksToDo.Name = "labelProjectTasksToDo";
            this.labelProjectTasksToDo.Size = new System.Drawing.Size(49, 13);
            this.labelProjectTasksToDo.TabIndex = 10;
            this.labelProjectTasksToDo.Text = "To Do: 0";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.Color.Tomato;
            this.btnSaveProject.Location = new System.Drawing.Point(6, 173);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(210, 47);
            this.btnSaveProject.TabIndex = 7;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = false;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(8, 45);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(208, 122);
            this.txtProjectDescription.TabIndex = 1;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(8, 19);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(208, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.listProjects);
            this.groupMain.Controls.Add(this.listToDo);
            this.groupMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupMain.Location = new System.Drawing.Point(3, 6);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(438, 255);
            this.groupMain.TabIndex = 4;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Main";
            // 
            // listProjects
            // 
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(9, 17);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(207, 225);
            this.listProjects.TabIndex = 3;
            this.listProjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listProjects_MouseClick);
            // 
            // listToDo
            // 
            this.listToDo.FormattingEnabled = true;
            this.listToDo.Location = new System.Drawing.Point(222, 17);
            this.listToDo.Name = "listToDo";
            this.listToDo.Size = new System.Drawing.Size(207, 225);
            this.listToDo.TabIndex = 6;
            this.listToDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listToDo_MouseClick);
            // 
            // tabSkills
            // 
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(1154, 565);
            this.tabSkills.TabIndex = 1;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabCalendar
            // 
            this.tabCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(1154, 565);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // btnAddChores
            // 
            this.btnAddChores.BackColor = System.Drawing.Color.Tomato;
            this.btnAddChores.Location = new System.Drawing.Point(6, 123);
            this.btnAddChores.Name = "btnAddChores";
            this.btnAddChores.Size = new System.Drawing.Size(207, 47);
            this.btnAddChores.TabIndex = 7;
            this.btnAddChores.Text = "Add Everyday Chores";
            this.btnAddChores.UseVisualStyleBackColor = false;
            this.btnAddChores.Click += new System.EventHandler(this.btnAddChores_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 592);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            this.groupActions.ResumeLayout(false);
            this.groupDailyWeekly.ResumeLayout(false);
            this.groupTaskInfo.ResumeLayout(false);
            this.groupTaskInfo.PerformLayout();
            this.groupProjectInfo.ResumeLayout(false);
            this.groupProjectInfo.PerformLayout();
            this.groupProjectInfoMini.ResumeLayout(false);
            this.groupProjectInfoMini.PerformLayout();
            this.groupMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.ListBox listDaily;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnAddToDaily;
        private System.Windows.Forms.ListBox listToDo;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.Button btnMarkAsToDo;
        private System.Windows.Forms.GroupBox groupTaskInfo;
        private System.Windows.Forms.GroupBox groupProjectInfo;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label labelProjectPercentage;
        private System.Windows.Forms.Label labelProjectHours;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label labelProjectTasksDone;
        private System.Windows.Forms.Label labelProjectTasksToDo;
        private System.Windows.Forms.GroupBox groupProjectInfoMini;
        private System.Windows.Forms.Label labelStatic2;
        private System.Windows.Forms.Label labelStatic1;
        private System.Windows.Forms.TextBox txtTaskEstimatedHours;
        private System.Windows.Forms.TextBox txtTaskSpentHours;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ListBox listWeekly;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnRemoveFromWeekly;
        private System.Windows.Forms.Button btnAddToWeekly;
        private System.Windows.Forms.Button btnRemoveFromDaily;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.GroupBox groupDailyWeekly;
        private System.Windows.Forms.Button btnAddChores;
    }
}

