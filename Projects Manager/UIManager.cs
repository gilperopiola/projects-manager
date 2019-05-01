using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_Manager {
    public static class UIManager {

        public static ListBox listProjects;
        public static ListBox listToDo;

        public static ListBox listDaily;
        public static ListBox listWeekly;

        public static TextBox txtProjectName;
        public static TextBox txtProjectDescription;
        public static Label labelProjectHours;
        public static Label labelProjectPercentage;
        public static Label labelTasksToDo;
        public static Label labelTasksDone;

        public static TextBox txtTaskName;
        public static TextBox txtTaskDescription;
        public static TextBox txtTaskSpentHours;
        public static TextBox txtTaskEstimatedHours;


        public static void Init(ListBox _listProjects, ListBox _listDaily, ListBox _listWeekly, ListBox _listToDo,
                                TextBox _txtProjectName, TextBox _txtProjectDescription, Label _labelProjectHours, Label _labelProjectPercentage, Label _labelTasksToDo,
                                Label _labelTasksDone, TextBox _txtTaskName, TextBox _txtTaskDescription, TextBox _txtTaskSpentHours,
                                TextBox _txtTaskEstimatedHours) {
            listProjects = _listProjects;
            listToDo = _listToDo;

            listDaily = _listDaily;
            listWeekly = _listWeekly;

            txtProjectName = _txtProjectName;
            txtProjectDescription = _txtProjectDescription;
            labelProjectHours = _labelProjectHours;
            labelProjectPercentage = _labelProjectPercentage;
            labelTasksToDo = _labelTasksToDo;
            labelTasksDone = _labelTasksDone;

            txtTaskName = _txtTaskName;
            txtTaskDescription = _txtTaskDescription;
            txtTaskSpentHours = _txtTaskSpentHours;
            txtTaskEstimatedHours = _txtTaskEstimatedHours;
        }

        public static void Refresh(Holder holder, Project selectedProject, Task selectedTask) {
            ClearLists();
            FillLists(holder, selectedProject, selectedTask);
            SelectLists(holder, selectedProject, selectedTask);
            FillProjectPanel(selectedProject);
            FillTaskPanel(selectedTask);
            holder.Save();
        }

        private static void FillProjectPanel(Project selectedProject) {
            if (selectedProject == null) {
                return;
            }

            txtProjectName.Text = selectedProject.name;
            txtProjectDescription.Text = selectedProject.description;
            labelProjectHours.Text = selectedProject.GetSpentHours() + "/" + selectedProject.GetEstimatedHours().ToString();
            labelProjectPercentage.Text = selectedProject.GetDonePercentage().ToString() + "% done";
            labelTasksToDo.Text = "To do: " + selectedProject.tasksToDo.Count().ToString();
            labelTasksDone.Text = "Done: " + selectedProject.tasksDone.Count().ToString();
        }

        private static void FillTaskPanel(Task selectedTask) {
            if (selectedTask == null) {
                return;
            }

            txtTaskName.Text = selectedTask.name;
            txtTaskDescription.Text = selectedTask.description;
            txtTaskSpentHours.Text = selectedTask.spentHours.ToString();
            txtTaskEstimatedHours.Text = selectedTask.estimatedHours.ToString();
        }


        private static void FillLists(Holder holder, Project selectedProject, Task selectedTask) {
            foreach (var project in holder.projects) {
                listProjects.Items.Add(project.name);

                if (selectedProject != null && project.name == selectedProject.name) {
                    foreach (var task in project.tasksToDo) {
                        listToDo.Items.Add(task.name);
                    }
                }
            }

            foreach (var daily in holder.daily) {
                listDaily.Items.Add(daily.name);
            }

            foreach (var weekly in holder.weekly) {
                listWeekly.Items.Add(weekly.name);
            }
        }

        private static void SelectLists(Holder holder, Project project, Task task) {
            if (project != null) {
                for (var i = 0; i < listProjects.Items.Count; i++) {
                    if (listProjects.Items[i].ToString() == project.name) {
                        listProjects.SelectedIndex = i;
                    }
                }
            }

            if (task != null) {
                for (var i = 0; i < listToDo.Items.Count; i++) {
                    if (listToDo.Items[i].ToString() == task.name) {
                        listToDo.SelectedIndex = i;
                    }
                }

                for (var i = 0; i < listDaily.Items.Count; i++) {
                    if (listDaily.Items[i].ToString() == task.name) {
                        listDaily.SelectedIndex = i;
                    }
                }

                for (var i = 0; i < listWeekly.Items.Count; i++) {
                    if (listWeekly.Items[i].ToString() == task.name) {
                        listWeekly.SelectedIndex = i;
                    }
                }
            }
        }

        private static void ClearLists() {
            listProjects.Items.Clear();
            listDaily.Items.Clear();
            listWeekly.Items.Clear();
            listToDo.Items.Clear();
        }
    }
}
