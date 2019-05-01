using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Projects_Manager {
    public class Holder {
        public List<Project> projects;
        public List<Task> daily;
        public List<Task> weekly;

        public Holder() {
            projects = new List<Project>();
            daily = new List<Task>();
            weekly = new List<Task>();
        }

        public void Save() {
            string json = JsonConvert.SerializeObject(this, new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            FileHandler.Write("holder.json", json);
        }

        //this function needs to be called at the start of the program because exporting to json cuts off the reference loop between some objects
        public void AssignProjectsToTasks() {
            foreach (Project project in projects) {
                foreach (Task task in project.tasksToDo) {
                    task.project = project;
                }
                foreach (Task task in project.tasksDone) {
                    task.project = project;
                }
                foreach (Task task in project.tasksArchived) {
                    task.project = project;
                }
            }
        }

        #region Item Swapping
        public void SwapProjects(int index, int index2) {
            Project temp = projects[index].DeepCopy();
            projects[index] = projects[index2].DeepCopy();
            projects[index2] = temp;
        }
        public void SwapToDo(Project selectedProject, int index, int index2) {
            Task temp = selectedProject.tasksToDo[index].DeepCopy();
            selectedProject.tasksToDo[index] = selectedProject.tasksToDo[index2].DeepCopy();
            selectedProject.tasksToDo[index2] = temp;
        }

        public void SwapDaily(int index, int index2) {
            Task temp = daily[index].DeepCopy();
            daily[index] = daily[index2].DeepCopy();
            daily[index2] = temp;
        }
        public void SwapWeekly(int index, int index2) {
            Task temp = weekly[index].DeepCopy();
            weekly[index] = weekly[index2].DeepCopy();
            weekly[index2] = temp;
        }

        #endregion
    }
}
