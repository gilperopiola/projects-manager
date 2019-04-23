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

namespace Projects_Manager
{
    public partial class MainForm : Form
    {
        private Project selectedProject;
        private Task selectedTask;

        public MainForm()
        {
            InitializeComponent();

            Holder holder = null;
            string json = FileHandler.Read("holder.json");
            if (json != "")
            {
                holder = JsonConvert.DeserializeObject<Holder>(json);
                holder.AssignProjectsToTasks();
            }

            Storage.Init(this, holder);
            groupTasks.Visible = false;
        }

        #region Actions
        public void SelectProject(Project project)
        {
            selectedProject = project;

            listToDo.Items.Clear();
            listDoing.Items.Clear();
            listDone.Items.Clear();

            foreach (Task toDo in selectedProject.tasksToDo)
            {
                listToDo.Items.Add(toDo.name);
            }
            foreach (Task doing in selectedProject.tasksDoing)
            {
                listDoing.Items.Add(doing.name);
            }
            foreach (Task done in selectedProject.tasksDone)
            {
                listDone.Items.Add(done.name);
            }

            txtProjectName.Text = project.name;
            txtProjectDescription.Text = project.description;
            labelProjectHours.Text = project.GetSpentHours() + " / " + project.GetEstimatedHours() + " hours";
            labelProjectPercentage.Text = project.GetDonePercentage() + "% done";
            labelProjectTasksToDo.Text = "To Do: " + project.tasksToDo.Count;
            labelProjectTasksDoing.Text = "Doing: " + project.tasksDoing.Count;
            labelProjectTasksDone.Text = "Done: " + project.tasksDone.Count;

            for (int i = 0; i < Storage.holder.projects.Count; i++)
            {
                if (Storage.holder.projects[i].Equals(project))
                {
                    listProjects.SelectedIndex = i;
                }
            }

            Storage.Save();
        }

        public void SelectTask(Task task)
        {
            selectedTask = task;

            txtTaskName.Text = task.name;
            txtTaskDescription.Text = task.description;
            txtTaskSpentHours.Text = task.spentHours.ToString();
            txtTaskEstimatedHours.Text = task.estimatedHours.ToString();

            for (int i = 0; i < selectedProject.tasksToDo.Count; i++)
            {
                if (selectedProject.tasksToDo[i].Equals(task))
                {
                    listToDo.SelectedIndex = i;
                    listDoing.ClearSelected();
                    listDone.ClearSelected();
                }
            }
            for (int i = 0; i < selectedProject.tasksDoing.Count; i++)
            {
                if (selectedProject.tasksDoing[i].Equals(task))
                {
                    listDoing.SelectedIndex = i;
                    listToDo.ClearSelected();
                    listDone.ClearSelected();
                }
            }

            for (int i = 0; i < selectedProject.tasksDone.Count; i++)
            {
                if (selectedProject.tasksDone[i].Equals(task))
                {
                    listDone.SelectedIndex = i;
                    listToDo.ClearSelected();
                    listDoing.ClearSelected();
                }
            }

            bool inDaily = false;
            for (int i = 0; i < Storage.holder.daily.Count; i++)
            {
                if (Storage.holder.daily[i].Equals(task))
                {
                    listDaily.SelectedIndex = i;
                    inDaily = true;
                }
            }

            if (!inDaily)
            {
                listDaily.ClearSelected();
            }

            Storage.Save();
        }
        #endregion

        #region List Controls
        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedIndex < 0)
            {
                return;
            }
            groupTasks.Visible = true;

            SelectProject(Storage.holder.projects[listProjects.SelectedIndex]);
        }
        private void listDaily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDaily.SelectedIndex < 0)
            {
                return;
            }

            SelectProject(Storage.holder.daily[listDaily.SelectedIndex].project);
            SelectTask(Storage.holder.daily[listDaily.SelectedIndex]);
        }

        public void AddProjectToList(Project newProject)
        {
            listProjects.Items.Add(newProject.name);
        }
        public void RemoveProjectFromList(Project oldProject)
        {
            listProjects.Items.Remove(oldProject.name);
        }

        public void AddToDoToList(Task newToDo)
        {
            listToDo.Items.Add(newToDo.name);
        }
        public void RemoveToDoFromList(Task oldToDo)
        {
            listToDo.Items.Remove(oldToDo.name);
        }

        public void AddDoingToList(Task newDoing)
        {
            listDoing.Items.Add(newDoing.name);
        }
        public void RemoveDoingFromList(Task oldDoing)
        {
            listDoing.Items.Remove(oldDoing.name);
        }
        public void AddDoneToList(Task newDone)
        {
            listDone.Items.Add(newDone.name);
        }
        public void RemoveDoneFromList(Task oldDone)
        {
            listDone.Items.Remove(oldDone.name);
        }
        public void AddDailyToList(Task newDaily)
        {
            listDaily.Items.Add(newDaily.name);
        }
        public void RemoveDailyFromList(Task oldDaily)
        {
            listDaily.Items.Remove(oldDaily.name);
        }
        private void listToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listToDo.SelectedIndex < 0)
            {
                return;
            }

            SelectTask(selectedProject.tasksToDo[listToDo.SelectedIndex]);
        }


        private void listDoing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDoing.SelectedIndex < 0)
            {
                return;
            }

            SelectTask(selectedProject.tasksDoing[listDoing.SelectedIndex]);
        }

        private void listDone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDone.SelectedIndex < 0)
            {
                return;
            }

            SelectTask(selectedProject.tasksDone[listDone.SelectedIndex]);
        }
        #endregion

        #region Buttons

        #region Form Flow
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();
            newProjectForm.Show();
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm(Storage.holder.projects[listProjects.SelectedIndex]);
            newTaskForm.Show();
        }
        #endregion

        #region Tasks
        private void btnMarkAsToDo_Click(object sender, EventArgs e)
        {
            Storage.RemoveTask(selectedTask, true);
            Storage.AddToDo(selectedTask);
        }

        private void btnMarkAsDoing_Click(object sender, EventArgs e)
        {
            Storage.RemoveTask(selectedTask, true);
            Storage.AddDoing(selectedTask);
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            Storage.RemoveTask(selectedTask, true);
            Storage.AddDone(selectedTask, true);
            Storage.RemoveDaily(selectedTask);
        }
        #endregion

        #region Daily
        private void btnAddToDaily_Click(object sender, EventArgs e)
        {
            if (selectedTask == null)
            {
                return;
            }

            Storage.AddDaily(selectedTask);
        }

        private void btnRemoveDaily_Click(object sender, EventArgs e)
        {
            if (Storage.holder.daily[listDaily.SelectedIndex] == null)
            {
                return;
            }

            Storage.RemoveDaily(Storage.holder.daily[listDaily.SelectedIndex]);
        }



        #endregion

        #endregion

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if (selectedProject == null)
            {
                return;
            }

            selectedProject.name = txtProjectName.Text;
            selectedProject.description = txtProjectDescription.Text;
            SelectProject(selectedProject);
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (selectedTask == null)
            {
                return;
            }
            selectedTask.name = txtTaskName.Text;
            selectedTask.description = txtTaskDescription.Text;
            selectedTask.spentHours = float.Parse(txtTaskSpentHours.Text);
            selectedTask.estimatedHours = float.Parse(txtTaskEstimatedHours.Text);
            SelectTask(selectedTask);
        }
    }


    public static class Storage
    {
        public static MainForm mainForm;
        public static Holder holder;

        public static void Init(MainForm mainForm, Holder _holder)
        {
            Storage.mainForm = mainForm;

            if (_holder == null)
            {
                holder = new Holder();
                return;
            }
            holder = _holder;
            
            foreach (Project project in holder.projects)
            {
                mainForm.AddProjectToList(project);
            }

            foreach(Task daily in holder.daily)
            {
                mainForm.AddDailyToList(daily);
            }
        }

        public static void Save()
        {
            string json = JsonConvert.SerializeObject(holder, new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
            FileHandler.Write("holder.json", json);
        }

        #region Projects
        public static void AddProject(Project newProject)
        {
            holder.projects.Add(newProject);
            mainForm.AddProjectToList(newProject);
            Storage.Save();
        }
        #endregion

        #region Tasks
        public static void AddToDo(Task newToDo)
        {
            newToDo.project.tasksToDo.Add(newToDo);
            mainForm.AddToDoToList(newToDo);
            Storage.Save();
        }

        public static void AddDoing(Task newDoing)
        {
            newDoing.project.tasksDoing.Add(newDoing);
            mainForm.AddDoingToList(newDoing);
            Storage.Save();
        }

        public static void AddDone(Task newDone, bool refresh)
        {
            newDone.project.tasksDone.Add(newDone);

            if (refresh)
            {
                mainForm.AddDoneToList(newDone);
            }
            Storage.Save();
        }

        public static void RemoveTask(Task oldTask, bool refresh)
        {
            if (oldTask.project.tasksToDo.Remove(oldTask) && refresh)
            {
                mainForm.RemoveToDoFromList(oldTask);
            }
            if (oldTask.project.tasksDoing.Remove(oldTask) && refresh)
            {
                mainForm.RemoveDoingFromList(oldTask);
            }
            if (oldTask.project.tasksDone.Remove(oldTask) && refresh)
            {
                mainForm.RemoveDoneFromList(oldTask);
            }
        }
        #endregion

        #region Daily 
        public static void AddDaily(Task task)
        {
            holder.daily.Add(task);
            mainForm.AddDailyToList(task);
            Storage.Save();
        }

        public static void RemoveDaily(Task task)
        {
            holder.daily.Remove(task);
            mainForm.RemoveDailyFromList(task);
            Storage.Save();
        }
        #endregion
    }

    public class Holder
    {
        public List<Project> projects;
        public List<Task> daily;

        public Holder()
        {
            projects = new List<Project>();
            daily = new List<Task>();
        }

        public void AssignProjectsToTasks()
        {
            foreach (Project project in projects)
            {
                foreach (Task task in project.tasksToDo)
                {
                    task.project = project;
                }
                foreach (Task task in project.tasksDoing)
                {
                    task.project = project;
                }
                foreach (Task task in project.tasksDone)
                {
                    task.project = project;
                }
            }
        }
    }

    public class Project
    {
        public string name;
        public string description;

        public List<Task> tasksToDo;
        public List<Task> tasksDoing;
        public List<Task> tasksDone;

        public Project(string name, string description)
        {
            this.name = name;
            this.description = description;

            tasksToDo = new List<Task>();
            tasksDoing = new List<Task>();
            tasksDone = new List<Task>();
        }

        public float GetSpentHours()
        {
            float spentHours = 0;

            foreach (Task task in tasksToDo)
            {
                spentHours += task.spentHours;
            }
            foreach (Task task in tasksDoing)
            {
                spentHours += task.spentHours;
            }
            foreach (Task task in tasksDone)
            {
                spentHours += task.spentHours;
            }

            return spentHours;
        }

        public float GetEstimatedHours()
        {
            float totalHours = 0;

            foreach (Task task in tasksToDo)
            {
                totalHours += task.estimatedHours;
            }
            foreach (Task task in tasksDoing)
            {
                totalHours += task.estimatedHours;
            }
            foreach (Task task in tasksDone)
            {
                totalHours += task.estimatedHours;
            }

            return totalHours;
        }

        public float GetDonePercentage()
        {
            return 100 / GetEstimatedHours() * GetSpentHours();
        }

    }

    public class Task
    {
        public Project project;

        public string name;
        public string description;

        public float estimatedHours;
        public float spentHours;

        public Task(Project project, string name, string description, float estimatedHours)
        {
            this.project = project;

            this.name = name;
            this.description = description;
            this.estimatedHours = estimatedHours;
            this.spentHours = 0;
        }
    }
}
