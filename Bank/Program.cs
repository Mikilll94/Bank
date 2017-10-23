using System;
using System.Globalization;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Interest interest = new Interest((decimal)0.08);
            Account[] accounts = new Account[]
            {
                new Account("44102000038758212314035006",
                    "jan.kowalski@gmail.com",
                    new DateTime(2013, 1, 24),
                    2000,
                    interest
                ),
                new Account("24249000054689148053160684",
                    "anna.pawlak@gmail.com",
                    new DateTime(2015, 1, 24),
                    1500,
                    interest
                ),
                new Account("44102000038758212314035006",
                    "nowakmariusz@gmail.com",
                    new DateTime(2013, 1, 24),
                    2000,
                    interest
                ),
                new Account("53249000050041310232555754",
                    "janina.dobosz@gmail.com",
                    new DateTime(2011, 6, 26),
                    3500,
                    interest
                )
            };
            Report report = new Report();
            Bank bank = new Bank(accounts, 800);

            Console.WriteLine("Listing accounts vol. 1\n");
            report.ListAccounts(accounts);

            Console.WriteLine("Account 0");
            Console.WriteLine("Stored 300 in deposit. Balance after: " + accounts[0].StoreMoney(300));
            Console.WriteLine("Returned money: " + accounts[0].ReturnMoney());

            Console.WriteLine("\nAccount 1");
            Console.WriteLine("Borrowed 600. Balance after: " + accounts[1].TakeLoan(600));
            Console.WriteLine("Paying 50 installment. Balance after: " + accounts[1].PayInstallment(50) + "\n");

            Console.WriteLine("Listing accounts vol. 2\n");
            report.ListAccounts(accounts);

            Bank other_bank = new Bank(new Account[] { });
            Console.WriteLine("Sending 300 to other bank. Bank funds after: " + bank.MakeInterbankPayment(300, other_bank));
            Console.ReadKey();
        }
    }
}