using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication

{
    class WrongAmountException : ApplicationException
    {
        private string messageDetails = string.Empty;

        public WrongAmountException() { }
        public WrongAmountException(string messageDetails)
        {
            messageDetails = Message;
        }
        public override string Message
        {
            get
            {
                return ("An error has occured: " + messageDetails);
            }
        }
    }
}