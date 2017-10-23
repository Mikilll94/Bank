using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Bank
    {
        private Account[] _accounts;
        private decimal _money;

        public Bank(Account[] accounts, decimal money = 0)
        {
            _accounts = accounts;
            _money = money;
        }

        public decimal MakeInterbankPayment(decimal amount, Bank target_bank)
        {
            _money -= amount;
            target_bank._money += amount;
            return _money;
        }
    }
}
