using System.Globalization;

namespace Banco
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get;private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0; //não precisa,pois ja inicia com zero;
        }
        public ContaBancaria(int numero, string titular, double saldo): this(numero, titular)
        {
            Saldo = saldo; 
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia +5.00;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero 
                +", Titular: "
                + Titular +
                ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
