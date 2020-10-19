using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication

{
    class WrongMenuChoice: ApplicationException
    {
        private string messageDetails = string.Empty;

        public WrongMenuChoice() { }
        public WrongMenuChoice(string messageDetails)
        {
            this.Message = Message;
        }
        public override string Message
        {
            get
            {
                return "Please choose from the following: A, B, C or R" 
            }
        }
    }
}