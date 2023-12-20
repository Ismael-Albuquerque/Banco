using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            //instanciamos a conta caso a resposta seja sim, ela tenha saldo inicial
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            //se ela não tiver o saldo inicial, esse construtor joga o saldo zero pra conta
            else
            {
                conta = new ContaBancaria(numero,titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //chamar a operação deposito
            conta.Deposito(quantia);

            Console.WriteLine("Dados da consta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //chamar a operação deposito
            conta.Saque(quantia);

            Console.WriteLine("Dados da consta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}