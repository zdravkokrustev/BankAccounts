using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks
{
    class Deposit : Account
    {
        public Deposit(double amount, double interestRate)
        {
            this.Balance = amount;
            this.InterestRate = interestRate;
        }

        public DateTime MaturityDate
        {
            get;
            set;
        }
    }
}
