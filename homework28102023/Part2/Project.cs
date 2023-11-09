using System;
using System.Collections.Generic;

namespace Part2
{
    class Project
    {
        private enum ProjectStatus
        {
            Project,
            InProgress,
            Closed
        }

        private string description;
        private DateTime deadline;
        private string initiator;
        private Employee teamlead;
        private List<Task> tasks = new List<Task>();
        private ProjectStatus status;

        public string ReturnDescription()
        {
            return description;
        }
        public Project(string Description, DateTime Deadline, string Initiator, Employee Teamlead)
        {
            description = Description;
            deadline = Deadline;
            initiator = Initiator;
            teamlead = Teamlead;
            status = ProjectStatus.Project;
        }
        public void CreateTask(string description, DateTime deadline, Employee initiator, Employee executor)
        {
            Task task = new Task(description, deadline, initiator, executor);
            tasks.Add(task);
            executor.TakeTask(task);
        }
        public void PrintTasks()
        {
            foreach (Task task in tasks)
            {
                task.PrintDescription();
            }
        }
    }
}
