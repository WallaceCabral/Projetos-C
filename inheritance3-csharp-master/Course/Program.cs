using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "maria", 500, 400));
            list.Add(new SavingsAccount(1003, "bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "ana", 500, 500));


            double sum = 0;
            foreach (Account account in list)
                sum += account.Balance;


            Console.WriteLine("Total Balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            foreach (Account acc in list)
                acc.Withdraw(10);

            foreach (Account account in list)
                Console.WriteLine("Updated balance for account "+account.Number +" : "+ account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
