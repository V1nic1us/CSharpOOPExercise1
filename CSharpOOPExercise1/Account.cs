using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOPExercise1
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Account(int accountNumber, string name, double initialDepositAmount) : this(accountNumber, name)
        {
            Deposit(initialDepositAmount);
        }

        public void Withdraw(double n)
        {
            Balance -= n + 5;
        }

        public void Deposit(double n)
        {
            Balance += n;
        }

        public override string ToString() { return $"Conta {AccountNumber}, Titular: {Name}, Saldo {Balance}"; }

    }
}
