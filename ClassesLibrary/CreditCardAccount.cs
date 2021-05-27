using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //private int _accountNumber;
        //private Customer _customerInfo;
        //private decimal _balance;
        //private bool _isPastDue;
        //private decimal _annualInterestRate;

        //properties
        public int AccountNumber { get; set; }
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctors
        public CreditCardAccount()
        {

        }
        public CreditCardAccount(int accountNumber, Customer customer, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Account Number: {0}\n" +
                "Customer: {1}\n" +
                "Balance: {2:c}\n" +
                "Is Past Due: {3}\n" +
                "Annual Interest Rate: {4}",
                AccountNumber, Customer, Balance, IsPastDue, AnnualInterestRate);
        }
    }
}
