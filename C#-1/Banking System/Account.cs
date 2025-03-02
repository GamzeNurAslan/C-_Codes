using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.classes
{
    class Account
    {
        public int AccountNumber
        {
            get;  set;
        }
        public double Balance
        {
            get;   private set;
        }

    }
}
