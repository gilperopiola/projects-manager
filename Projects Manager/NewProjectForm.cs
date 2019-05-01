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
    public partial class NewProjectForm : Form
    {
        private Holder holder;
        private Project selectedProject;
        private Task selectedTask;

        public NewProjectForm(Holder holder, Project selectedProject, Task selectedTask)
        {
            InitializeComponent();
            this.holder = holder;
            this.selectedProject = selectedProject;
            this.selectedTask = selectedTask;
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            string projectName = txtNewProjectName.Text;
            string projectDescription = txtNewProjectDescription.Text;

            holder.projects.Add(new Project(projectName, projectDescription));

            UIManager.Refresh(holder, selectedProject, selectedTask);
            this.Hide();
        }
    }
}
