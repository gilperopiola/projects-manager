using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_Manager
{
    public partial class NewTaskForm : Form
    {
        private Holder holder;
        private Project selectedProject;
        private Task selectedTask;

        public NewTaskForm(Holder holder, Project selectedProject, Task selectedTask)
        {
            InitializeComponent();
            this.holder = holder;
            this.selectedProject = selectedProject;
            this.selectedTask = selectedTask;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string taskName = txtNewTaskName.Text;
            string taskDescription = txtNewTaskDescription.Text;
            float taskEstimatedHours;

            bool parseSuccess = float.TryParse(txtNewTaskHours.Text, out taskEstimatedHours);
            taskEstimatedHours = parseSuccess ? taskEstimatedHours : 0;

            selectedProject.tasksToDo.Add(new Task(selectedProject, taskName, taskDescription, taskEstimatedHours));

            UIManager.Refresh(holder, selectedProject, selectedTask);

            this.Hide();
        }
    }
}
