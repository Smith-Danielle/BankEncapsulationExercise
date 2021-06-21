using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Please enter your name to begin.");
            Name = Console.ReadLine();

        }
        
        public string Name { get; set; }

        private double balance = 0;

        public void Deposit(double addMoney)
        {
            balance = balance + addMoney;
            Console.WriteLine($"Thank you {Name}. You have made a deposit of {addMoney} to your account.");
        }
        public void GetBalance()
        {
            Console.WriteLine($"{Name} Account Balance: {balance}");
        }
    }
}
