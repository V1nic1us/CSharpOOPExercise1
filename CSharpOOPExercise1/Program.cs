using CSharpOOPExercise1;
using System;
using System.Security.Principal;

namespace CSharpOOPExecise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o número da conta:");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta:");
            string name = Console.ReadLine();
            Console.WriteLine("Você deseja adicionar um saldo inicial? (S para Sim, N para Não):");
            string choice = Console.ReadLine();

            Account account;

            if (choice.ToUpper() == "S")
            {
                Console.WriteLine("Digite o saldo inicial:");
                int initialDepositAmount = int.Parse(Console.ReadLine());

                account = new Account(accountNumber, name, initialDepositAmount);
            }
            else
            {
                account = new Account(accountNumber, name);
            }

            Console.WriteLine("Digite um valor para saque:");
            account.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine(account.ToString());

            Console.WriteLine("Digite um valor para deposito:");
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine(account.ToString());
        }
    }
}