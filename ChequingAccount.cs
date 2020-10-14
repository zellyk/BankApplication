using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class ChequingAccount : Account
    {
        public ChequingAccount(double balance, double interestRate) : base(balance, interestRate)
        {
        
        }

        public void MakeWithdraw(double withdrawAmount)
        {
            if (base.currentBalance - withdrawAmount < 0)
            {
                base.currentBalance -= 15.00;
            }
            else
            {
                base.currentBalance -= withdrawAmount;
            }
        }

        public void MakeDeposit(double amountToDeposit)
        {
            base.MakeDeposit(amountToDeposit);
        }

        public void CloseAndReport()
        {
            base.monthlyCharge += 5.00 + (0.10 * base.totalWithdraws);
            base.CloseAndReport();
        }
    }

}

