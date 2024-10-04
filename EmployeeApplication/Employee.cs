using System;

namespace EmployeeApplication
{
    public class Employee
    {
        public string? EmployeeId;
        public string? Lastname;
        public string? FirstName;
        public string? Position;

        #region -- Overloaded Constructors --
        public Employee(string employeeId)
        {
            this.EmployeeId = employeeId;
        }

        public Employee(string employeeId, string firstname)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstname;
        }

        public Employee(string employeeId, string firstname, string lastname)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstname;
            this.Lastname = lastname;
        }

        public Employee(string EmployeeId, string firstname, string lastname, string position)
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = firstname;
            this.Lastname = lastname;
            this.Position = position;
        }
        #endregion
    }
}
