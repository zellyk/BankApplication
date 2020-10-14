using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class GlobalSavings : SavingsAccount, IExchangeable
    {
        public GlobalSavings(double balance, double interestRate) : base(balance, interestRate)
        {
        
        }

        public double USValue(double rate)
        {
            double balanceUSD = base.currentBalance * rate;
            return balanceUSD;
        }
    }
}
