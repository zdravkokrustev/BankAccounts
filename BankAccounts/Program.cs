using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Name = "Ivan Ivanov";
            client.Egn = "1234567890";
            client.Accounts = new List<Account>();
            
            Deposit deposit = new Deposit(1000, 0.05);
            deposit.MaturityDate = new DateTime(2013, 07, 04);
            client.Accounts.Add(deposit);

            DebitAccount account1 = new DebitAccount();
            account1.Balance = 500;
            client.Accounts.Add(account1);

            DebitAccount account2 = new DebitAccount();
            account2.Balance = 300;
            client.Accounts.Add(account2);

            if (client.Withdraw(1850))
            {
                Console.WriteLine("Amount successfully withdrawn.");
            }
            else
            {
                Console.WriteLine("Not enough funds!");
            }
        }
    }
}
