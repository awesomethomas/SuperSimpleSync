using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{

    public class AccountManager
    {
        private static AccountManager instance;

        private AccountManager() { accounts = new List<Guid>(); }

        private List<Guid> accounts;

        public static AccountManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountManager();
                }
                return instance;
            }
        }

        public void InsertAccount(Guid newAct)
        {
            if(!accounts.Contains(newAct))
                accounts.Add(newAct);
        }

        public List<Guid> GetAccounts()
        {
            return accounts;
        }
    }
}