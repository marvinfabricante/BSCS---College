using System;

namespace EmployeeApplication
{
    public class PartTimeEmployee : IEmployee
    {
        #region -- Properties, Encapsulation --
        public string first_name;
        public string last_name;
        public string department;
        public string job_title;
        public double basic_salary;

        public string FirstName
        {
            get => this.first_name;
            set => this.first_name = value;
        }

        public string LastName
        {
            get => this.last_name;
            set => this.last_name = value;
        }

        public string Department
        {
            get => this.department;
            set => this.department = value;
        }

        public string JobTitle
        {
            get => this.job_title;
            set => this.job_title = value;
        }

        public double BasicSalary
        {
            get => this.basic_salary;
            set => this.basic_salary = value;
        }
        #endregion


        #region -- Compute and retrieve datas --
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            double salary = ratePerHour * hoursWorked;
            this.BasicSalary = salary;
        }

        public double getSalary()
        {
            return this.basic_salary;
        }
        #endregion
    }
}
