using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface IOperation
    {
        decimal StoreMoney(decimal moneyToStore);
        decimal ReturnMoney();
        decimal TakeLoan(decimal amount_of_loan);
        decimal PayInstallment(decimal installment);
    }
}
