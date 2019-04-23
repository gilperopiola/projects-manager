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
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            string projectName = txtNewProjectName.Text;
            string projectDescription = txtNewProjectDescription.Text;

            Storage.AddProject(new Project(projectName, projectDescription));

            this.Hide();
        }
    }
}
