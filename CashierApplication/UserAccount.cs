using System;

namespace CashierApplication
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string full_name, string user_name, string user_password)
        {
            this.full_name = full_name;
            this.user_name = user_name;
            this.user_password = user_password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return this.full_name;
        }
    }
}

/*  andali naman neto tanginang sti yan oh sayang tuition  */