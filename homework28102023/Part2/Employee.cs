namespace Part2
{
    class Employee
    {
        private string name;
        private Task assignedTask;

        public Employee(string Name)
        {
            name = Name;
        }
        public void TakeTask(Task task)
        {
            assignedTask = task;
        }
        public void WriteAReport()
        {

        }
    }
}
