using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Projects_Manager {
    public partial class MainForm : Form {
        private Holder holder;

        private ListBox selectedList;
        private Project selectedProject;
        private Task selectedTask;

        public MainForm() {
            InitializeComponent();

            UIManager.Init(listProjects, listDaily, listWeekly, listToDo, txtProjectName, txtProjectDescription, labelProjectHours,
                labelProjectPercentage, labelProjectTasksToDo, labelProjectTasksDone, txtTaskName, txtTaskDescription, txtTaskSpentHours,
                txtTaskEstimatedHours);

            string json = FileHandler.Read("holder.json");
            if (json != "") {
                holder = JsonConvert.DeserializeObject<Holder>(json);
                holder.AssignProjectsToTasks();
            }

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        #region Actions
        public void SelectProject(Project project) {
            if (selectedProject == project) {
                return;
            }

            selectedProject = project;
            selectedTask = null;

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        public void SelectTask(Task task) {
            if (selectedTask == task) {
                return;
            }

            selectedProject = task.project;
            selectedTask = task;

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        public void SelectList(ListBox list) {
            selectedList = list;
        }
        #endregion

        #region List Controls
        private void listProjects_MouseClick(object sender, MouseEventArgs e) {
            if (listProjects.SelectedIndex < 0) {
                return;
            }

            SelectProject(holder.projects[listProjects.SelectedIndex]);
            SelectList(listProjects);
        }
        private void listToDo_MouseClick(object sender, MouseEventArgs e) {
            if (listToDo.SelectedIndex < 0) {
                return;
            }

            SelectTask(selectedProject.tasksToDo[listToDo.SelectedIndex]);
            SelectList(listToDo);
        }

        private void listDaily_MouseClick(object sender, MouseEventArgs e) {
            if (listDaily.SelectedIndex < 0) {
                return;
            }

            SelectTask(holder.daily[listDaily.SelectedIndex]);
            SelectList(listDaily);

        }
        private void listWeekly_MouseClick(object sender, MouseEventArgs e) {
            if (listWeekly.SelectedIndex < 0) {
                return;
            }

            SelectTask(holder.weekly[listWeekly.SelectedIndex]);
            SelectList(listWeekly);
        }
        #endregion

        #region Button Controls

        private void btnNewProject_Click_1(object sender, EventArgs e) {
            NewProjectForm newProjectForm = new NewProjectForm(holder, selectedProject, selectedTask);
            newProjectForm.Show();
        }

        private void btnNewTask_Click(object sender, EventArgs e) {
            NewTaskForm newTaskForm = new NewTaskForm(holder, selectedProject, selectedTask);
            newTaskForm.Show();
        }

        private void btnSaveProject_Click(object sender, EventArgs e) {
            if (selectedProject == null) {
                return;
            }

            selectedProject.name = txtProjectName.Text;
            selectedProject.description = txtProjectDescription.Text;

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        private void btnSaveTask_Click(object sender, EventArgs e) {
            if (selectedTask == null) {
                return;
            }

            selectedTask.name = txtTaskName.Text;
            selectedTask.description = txtTaskDescription.Text;
            selectedTask.spentHours = float.Parse(txtTaskSpentHours.Text);
            selectedTask.estimatedHours = float.Parse(txtTaskEstimatedHours.Text);

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }


        private void btnMarkAsToDo_Click(object sender, EventArgs e) {
            selectedTask.project.tasksDone.Remove(selectedTask);
            selectedTask.project.tasksToDo.Add(selectedTask);

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e) {
            if (selectedTask.spentHours == 0) {
                selectedTask.spentHours = selectedTask.estimatedHours;
            }

            selectedTask.project.tasksToDo.Remove(selectedTask);
            selectedTask.project.tasksDone.Add(selectedTask);

            if (holder.daily.Contains(selectedTask)) {
                holder.daily.Remove(selectedTask);
            }

            if (holder.weekly.Contains(selectedTask)) {
                holder.weekly.Remove(selectedTask);
            }

            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        private void btnArchiveAllDone_Click(object sender, EventArgs e) {
            foreach (var task in selectedProject.tasksDone) {
                selectedProject.tasksArchived.Add(task.DeepCopy());
            }

            selectedProject.tasksDone.Clear();
            UIManager.Refresh(holder, selectedProject, selectedTask);
        }

        private void btnAddToDaily_Click(object sender, EventArgs e) {
            if (selectedTask == null || holder.daily.Contains(selectedTask)) {
                return;
            }

            holder.weekly.Remove(selectedTask);
            holder.daily.Add(selectedTask);
            UIManager.Refresh(holder, selectedProject, selectedTask);
        }


        private void btnRemoveFromDaily_Click(object sender, EventArgs e) {
            if (selectedTask == null) {
                return;
            }

            if (holder.daily.Remove(selectedTask)) {
                UIManager.Refresh(holder, selectedProject, selectedTask);
            }
        }

        private void btnAddToWeekly_Click(object sender, EventArgs e) {
            if (selectedTask == null || holder.weekly.Contains(selectedTask)) {
                return;
            }

            holder.daily.Remove(selectedTask);
            holder.weekly.Add(selectedTask);
            UIManager.Refresh(holder, selectedProject, selectedTask);

        }

        private void btnRemoveFromWeekly_Click(object sender, EventArgs e) {
            if (selectedTask == null) {
                return;
            }

            if (holder.weekly.Remove(selectedTask)) {
                UIManager.Refresh(holder, selectedProject, selectedTask);
            }
        }

        private void btnAddChores_Click(object sender, EventArgs e) {
            foreach (Project project in holder.projects) {
                if (project.name == "Misc") {
                    SelectProject(project);

                    Task evernoteDiary = new Task(project, "Evernote Diary", "", 0.25f);
                    Task monthly = new Task(project, "Monthly", "", 0.25f);
                    Task calendarDollarbird = new Task(project, "Calendar & Dollarbird", "", 0.25f);

                    project.tasksToDo.Add(evernoteDiary);
                    project.tasksToDo.Add(monthly);
                    project.tasksToDo.Add(calendarDollarbird);

                    holder.daily.Add(evernoteDiary);
                    holder.daily.Add(monthly);
                    holder.daily.Add(calendarDollarbird);

                    UIManager.Refresh(holder, selectedProject, selectedTask);
                }
            }
        }

        #endregion

        #region Key Bindings
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            int upDownIndex;

            switch (keyData) {
                case Keys.Up:
                    upDownIndex = selectedList.SelectedIndex;

                    if (selectedList == listProjects && upDownIndex > 0) {
                        holder.SwapProjects(upDownIndex, upDownIndex - 1);
                    }
                    if (selectedList == listToDo && upDownIndex > 0) {
                        holder.SwapToDo(selectedProject, upDownIndex, upDownIndex - 1);
                    }
                    if (selectedList == listDaily && upDownIndex > 0) {
                        holder.SwapDaily(upDownIndex, upDownIndex - 1);
                    }
                    if (selectedList == listWeekly && upDownIndex > 0) {
                        holder.SwapWeekly(upDownIndex, upDownIndex - 1);
                    }

                    UIManager.Refresh(holder, selectedProject, selectedTask);
                    return true;
                case Keys.Down:
                    upDownIndex = selectedList.SelectedIndex;

                    if (selectedList == listProjects && upDownIndex < selectedList.Items.Count - 1) {
                        holder.SwapProjects(upDownIndex, upDownIndex + 1);
                    }
                    if (selectedList == listToDo && upDownIndex < selectedList.Items.Count - 1) {
                        holder.SwapToDo(selectedProject, upDownIndex, upDownIndex + 1);
                    }
                    if (selectedList == listDaily && upDownIndex < selectedList.Items.Count - 1) {
                        holder.SwapDaily(upDownIndex, upDownIndex + 1);
                    }
                    if (selectedList == listWeekly && upDownIndex < selectedList.Items.Count - 1) {
                        holder.SwapWeekly(upDownIndex, upDownIndex + 1);
                    }

                    UIManager.Refresh(holder, selectedProject, selectedTask);
                    return true;
                case Keys.P:
                    btnNewProject.PerformClick();
                    return true;
                case Keys.T:
                    btnNewTask.PerformClick();
                    return true;
                case Keys.D:
                    btnAddToDaily.PerformClick();
                    return true;
                case Keys.W:
                    btnAddToWeekly.PerformClick();
                    return true;
                case Keys.Space:
                    btnMarkAsDone.PerformClick();
                    return true;
            }
            return false;
        }
        #endregion
    }
}
