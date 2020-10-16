using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public abstract class Account
    {

        // Variables
        public double startingBalance { get; set; }
        public double currentBalance { get; set; }
        public double totalDepositCumul { get; set; }
        public int totalDeposits { get; set; }
        public double totalWithdrawCumul { get; set; }
        public int totalWithdraws { get; set;  }
        public double annualInterest { get; set; }
        public double monthlyCharge { get; set;  }
        public enum AccountState { Active = 1, Inactive = 0};
        public string accountStatus { get; set; }


        // Constructor for Account

        public Account(double balance, double interestRate)
        {
            this.startingBalance = balance;
            this.currentBalance = balance;
            this.annualInterest = interestRate;
            this.accountStatus = AccountState.Active.ToString();
        }


        public void MakeDeposit(double depositAmount)
        {
            currentBalance += depositAmount;
            totalDeposits++;
        }
        public void MakeWithdraw(double withdrawAmount)
        {
            currentBalance += withdrawAmount;
            totalWithdraws++;
        }

        public void CalculateInterest()
        {
            double monthlyInterestRate = (annualInterest / 12.0);
            double monthlyInterest = currentBalance * monthlyInterestRate;
            currentBalance += monthlyInterest;
        }

        public void CloseAndReport()
        {
            currentBalance -= monthlyCharge;
            CalculateInterest();
            totalDeposits = 0;
            totalWithdraws = 0;
            monthlyCharge = 0;

            double percentChange = 0;
            if (currentBalance > startingBalance)
            {
                double increase = currentBalance - startingBalance;
                percentChange = (increase / startingBalance);
            }
            else
            {
                double increase = startingBalance - currentBalance;
                percentChange = (increase / startingBalance);
            }

            Console.WriteLine(String.Format("\nPrevious Account Balance: {0:C2}\nNew Account Balance: {1:C2}\nPercent change from old balance: {2:P2}\nMonthly interest: {3:C2}",
                startingBalance, currentBalance, percentChange, currentBalance * (annualInterest / 12.0)));

            startingBalance = currentBalance;
        }







    }
}
