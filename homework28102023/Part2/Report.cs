using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Report
    {
        private string description;
        private DateTime dateOfCompletion;
        private Employee assignedEmployee;

        public Report(string Description, DateTime DateOfCompletion, Employee AssignedEmployee)
        {
            description = Description;
            dateOfCompletion = DateOfCompletion;
            assignedEmployee = AssignedEmployee;
        }
    }
}
