using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Report
    {
        public Report()
        {

        }

        public void ListAccounts(Account[] accounts)
        {
            string accountsInfo = "";
            foreach (var account in accounts)
            {
                accountsInfo += account.GetAccountInfo() + "\n";
            }
            Console.Write(accountsInfo);
        }
    }
}
