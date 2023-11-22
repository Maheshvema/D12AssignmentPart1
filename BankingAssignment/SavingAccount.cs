using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment
{
    internal class SavingAccount : IAccount
    {
        double savingBal;

        public double Balance => savingBal;

        public double Deposit(double Amount)
        {
            savingBal += Amount;
            return savingBal;
        }

        public double WithDraw(double Amount)
        {
            if (Amount <= savingBal)
            {
                if (savingBal - Amount >= 10000)
                {
                    Console.WriteLine("saving account transaction success!!!");
                    savingBal -= Amount;
                }
                else
                {
                    Console.WriteLine("You have to maintain 18k MAB");
                }
            }
            else
            {
                Console.WriteLine("Insufficient Amount!!!");
            }
            return savingBal;
        }
    }
}
