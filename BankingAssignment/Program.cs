using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment
{
    public class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Account Type \n 1.Saving Account \n 2.Current Account");
            IAccount account = null;
            int acType = int.Parse(Console.ReadLine());
            switch (acType)
            {
                case 1:
                    {
                        Console.WriteLine("Welcome to saving Account");
                        account = new SavingAccount();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Welcome to current account");
                        account = new SavingAccount();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Account Type");
                        return;
                    }
            }
            Console.WriteLine("Choose operation 1.balance \n 2.withdraw 3.Deposit");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine("Balance" + account.Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter amount to withdraw");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance after transaction " + account.WithDraw(amount));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter amount to deposit");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("balance after transaction" + account.Deposit(amount));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        return;
                    }
            }
            Console.ReadKey();
        }
    }
}


