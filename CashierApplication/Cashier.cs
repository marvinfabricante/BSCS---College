using System;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string department, string full_name, string user_name, string user_password) : base(full_name, user_name, user_password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            return user_name.Equals(uName) && user_password.Equals(password);
        }

        public string getDepartment()
        {
            return this.department;
        }
    }
}

// P