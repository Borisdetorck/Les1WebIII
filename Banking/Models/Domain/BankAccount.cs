using System;       //imports zoals java
using System.Collections.Generic;
using System.Text;

//bij compilatie wordt dll aangemaakt in assembly

namespace Banking.Models.Domain
{
    public class BankAccount
    {

        private decimal _balance;
        public const decimal withdrawCost = 0.10M;

        /* jave methode setter en getter
         
        public decimal GetBalance()
        {
            return _balance;
        }

        private void SetBalance(decimal value)
        {
            _balance = value;
        } */

        /*automatic property Balance (hier maakt property setter/getter voor balance var
         vb. gebruik van de property
              ba.Balance = 20; -> roept setter
              ba.Balance; -> roept getter aan

         public decimal Balance { get; private set; }
         */

        //full property Balance(kan setter/getter volledig definieren) tesst 
        public decimal Balance
        {
            get { return _balance; }    
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value");
                }
                else
                {
                    _balance = value;   //value bevat 20 uit vb
                }
            }
        }

        public string AccountNumber { get; set; }

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)  // andere constructor aanroepen
        {
            Balance = balance;
        } 
        #endregion

        public void Deposit(decimal amount, int nrOfTimes = 1)  // door waarde toe te kennen aan parameter wordt het een optionele parameter --> waarde meegegeven neem die waarde, anders neem default waarde
        {
            Balance += amount * nrOfTimes;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount + withdrawCost;
        }

    }
}
