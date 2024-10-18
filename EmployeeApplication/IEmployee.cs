using System;

namespace EmployeeApplication
{
    public interface IEmployee
    {
        #region -- Interface members --
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }

        void computeSalary(int hoursWorked, double ratePerHour);
        #endregion
    }
}
