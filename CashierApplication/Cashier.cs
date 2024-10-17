namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        #region -- Cashier Class: Derived from UserAccount --
        private string department;

        public Cashier(string name, string uName, string password, string department) : base(name, uName, password)
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
        #endregion
    }
}
