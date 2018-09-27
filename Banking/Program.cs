using Banking.Models.Domain;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-123123123-23");
            BankAccount otherBA = new BankAccount("456-456456456-45", 1000);

            Console.WriteLine($"Balance of otherBa is currently: {otherBA.Balance} Euro");

            Console.WriteLine($"withdraw cost is currently: {BankAccount.withdrawCost} Euro");

            Console.WriteLine($"Balance is currently: {myBA.Balance} Euro");
            myBA.Deposit(100);
            myBA.Deposit(500,2);
            Console.WriteLine($"Balance is currently: {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is currently: {myBA.Balance} Euro");
            myBA.Withdraw(10);
            Console.WriteLine($"Balance is currently: {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
