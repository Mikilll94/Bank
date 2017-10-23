using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Bank
    {
        private Account[] _accounts;

        public Bank(Account[] accounts)
        {
            _accounts = accounts;
        }
    }
}
