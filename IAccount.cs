using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    interface IAccount
    {
        void MakeWithdrawl(double amount);
        void MakeDeposit(double amount);
        void CalculateInterest();
        void CloseAndReport();



    }
}
