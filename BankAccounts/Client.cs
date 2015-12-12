using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks
{
    class Client
    {
        public string Name
        {
            get;
            set;
        }

        public string Egn
        {
            get;
            set;
        }

        public List<Account> Accounts
        {
            get;
            set;
        }

        public bool Withdraw(double amount)
        {
            foreach (Account account in this.Accounts)
            {
                if (account is Deposit)
                {
                    Deposit deposit = (Deposit)account;
                    if (deposit.MaturityDate == DateTime.Today)
                    {
                        double depositAmount = deposit.Balance * (1 + deposit.InterestRate);
                        if (amount >= depositAmount)
                        {
                            amount -= depositAmount;
                            deposit.Balance = 0;
                        }
                        else
                        {
                            amount = 0;
                            deposit.Balance = depositAmount - amount;
                        }
                    }
                }
                else if (account is DebitAccount)
                {
                    DebitAccount debitAccount = (DebitAccount)account;
                    if (amount >= debitAccount.Balance)
                    {
                        amount -= debitAccount.Balance;
                        debitAccount.Balance = 0;
                    }
                    else
                    {
                        amount = 0;
                        debitAccount.Balance -= amount;
                    }
                }

                if (amount == 0)
                {
                    break;
                }
            }

            return amount == 0;
        }
    }
}
