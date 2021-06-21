using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount();
            newAccount.Deposit(25);
            newAccount.GetBalance();
        }
    }
}
