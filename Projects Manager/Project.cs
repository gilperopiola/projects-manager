using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Manager {
    public class Project {
        public string name;
        public string description;

        public List<Task> tasksToDo;
        public List<Task> tasksDone;
        public List<Task> tasksArchived;

        public Project(string name, string description) {
            this.name = name;
            this.description = description;

            tasksToDo = new List<Task>();
            tasksDone = new List<Task>();
            tasksArchived = new List<Task>();
        }

        public Project DeepCopy() {
            Project copy = new Project(name, description);
            copy.tasksToDo = new List<Task>(tasksToDo);
            copy.tasksDone = new List<Task>(tasksDone);
            copy.tasksArchived = new List<Task>(tasksArchived);
            return copy;
        }

        public float GetSpentHours() {
            float spentHours = 0;

            foreach (Task task in tasksToDo) {
                spentHours += task.spentHours;
            }
            foreach (Task task in tasksDone) {
                spentHours += task.spentHours;
            }
            foreach (Task task in tasksArchived) {
                spentHours += task.spentHours;
            }

            return spentHours;
        }

        public float GetEstimatedHours() {
            float totalHours = 0;

            foreach (Task task in tasksToDo) {
                totalHours += task.estimatedHours;
            }
            foreach (Task task in tasksDone) {
                totalHours += task.estimatedHours;
            }
            foreach (Task task in tasksArchived) {
                totalHours += task.estimatedHours;
            }

            return totalHours;
        }

        public float GetDonePercentage() {
            return float.Parse((100 / GetEstimatedHours() * GetSpentHours()).ToString("0.00"));
        }
    }
}
