using System;
using System.Collections.Generic;

namespace Part2
{
    class Task
    {
        private enum TaskStatus
        {
            NotAssigned,
            Assigned,
            InProgress,
            UnderReview,
            Completed
        }
        private string description;
        private DateTime deadline;
        private Employee initiator;
        private Employee executor;
        private TaskStatus status;
        private List<Report> reports;

        public Task(string Description, DateTime Deadline, Employee Initiator, Employee Executor)
        {
            description = Description;
            deadline = Deadline;
            initiator = Initiator;
            status = TaskStatus.NotAssigned;
            executor = Executor;
            reports = new List<Report>();
        }
        public void PrintDescription()
        {
            Console.WriteLine(description);
        }
    }
}
