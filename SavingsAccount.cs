using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingsAccount : Account
    {

        public static int withdraws = 0;

        public SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
        {

        }

        public void MakeWithdraw(double withdraw)
        {
            if (base.accountStatus == AccountState.Active.ToString())
            {
                base.MakeWithdraw(withdraw);
            }
            else
                Console.Write("Account is inactive.");
            withdraws += 1;
        }

        public void MakeDeposit(double deposit)
        {
            if (base.accountStatus == AccountState.Active.ToString())
            {
                base.MakeDeposit(deposit);
            }
            else
                Console.WriteLine("Account is inactive.");

        }

        public void CloseAndReport()
        {
            if (withdraws > 4)
            {
                for (int i = 0; withdraws > 4; i++)
                {
                    base.monthlyCharge += 1;
                }
            }
            if (base.currentBalance < 25)
            {
                base.accountStatus = AccountState.Inactive.ToString();
            }

            base.CloseAndReport();
        }

    }
}
