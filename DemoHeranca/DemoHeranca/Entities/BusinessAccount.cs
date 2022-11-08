using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeranca.Entities
{
    class BusinessAccount : Account //momento que ele herda os dados da clase account
    {
        public Double LoanLimit  { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance,double loanLimit) : base(number, holder, balance) // momento onde ele passa o construtor da clase account
        {
            
            this.LoanLimit = loanLimit;
        }
        public void Loan (double amount)
        {
        if (amount <= LoanLimit) //verifica se a quantia compativel com o valor pedido do emprestimo
            Balance += amount;
        else
                Console.WriteLine("Valor desejado estrapolou o valor de emprestimo ");
        }
    }
}
