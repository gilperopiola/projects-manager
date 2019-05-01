using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Manager {
    public class Task {

        public Project project;

        public string name;
        public string description;

        public float estimatedHours;
        public float spentHours;

        public Task(Project project, string name, string description, float estimatedHours, float spentHours = 0) {
            this.project = project;

            this.name = name;
            this.description = description;
            this.estimatedHours = estimatedHours;
            this.spentHours = spentHours;
        }

        public Task DeepCopy() {
            return new Task(project, name, description, estimatedHours, spentHours);
        }
    }
}
