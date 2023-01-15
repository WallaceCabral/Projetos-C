using System;
using System.Collections.Generic;
using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string name, double balance, double withdrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = withdrawLimit; ;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("O valor excede o limite de saque");
            }
            if (amount > Balance)
            {
                throw new DomainException("Saldo insuficiente");
            }

            Balance -= amount;
        }
    }
}

