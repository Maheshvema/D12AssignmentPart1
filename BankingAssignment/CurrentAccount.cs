using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment
{
    public class CurrentAccount : IAccount
    {
        double currentBal;
        public CurrentAccount()
        {
            currentBal = 50000;
        }

        public double Balance => currentBal;

        public double Deposit(double Amount)
        {
            currentBal += Amount;
            return currentBal;
        }

        public double WithDraw(double Amount)
        {
            if (Amount <= currentBal)
            {
                Console.WriteLine("current account  transcation success!!!");
                currentBal -= Amount;
            }
            else
            {
                Console.WriteLine("Insufficient Amount!!!");
            }
            return currentBal;
        }
    }
}
