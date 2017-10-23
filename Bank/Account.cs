using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account : IOperation
    {
        private string _id;
        private string _owner;
        private DateTime _date_of_opening;
        private decimal _balance;
        private Deposit _deposit;
        private Loan _loan;
        private Interest _interest;

        public Account(string id, string owner, DateTime date_of_opening,
            decimal balance, Interest interest)
        {
            _id = id;
            _owner = owner;
            _date_of_opening = date_of_opening;
            _balance = balance;
            _deposit = new Deposit();
            _loan = new Loan();
            _interest = interest;
        }

        public string GetAccountInfo()
        {
            return "Id: " + _id.ToString() + "\n" +
                "Owner: " + _owner.ToString() + "\n" +
                "Date of opening: " + _date_of_opening.ToString("yyyy-MM-dd") + "\n" +
                "Balance: " + _balance.ToString() + "\n" +
                "Deposited money: " + _deposit._stored_money.ToString() + "\n" +
                "Borrowed money: " + _loan._loan_money.ToString() + "\n";
        }

        public decimal StoreMoney(decimal moneyToStore)
        {
            _deposit._stored_money = moneyToStore;
            _deposit._date_of_payment = DateTime.Now;
            _balance -= moneyToStore;
            return _balance;
        }

        public decimal ReturnMoney()
        {
            decimal money_to_return = _deposit._stored_money + _deposit._stored_money * _interest._interest_value;
            _balance = _balance + money_to_return;
            return money_to_return;
        }

        public decimal TakeLoan(decimal amount_of_loan)
        {
            _loan._loan_money += amount_of_loan;
            _balance += amount_of_loan;
            return _balance;
        }

        public decimal PayInstallment(decimal installment)
        {
            _loan._loan_money -= installment;
            _balance -= installment;
            return _balance;
        }
    }
}
