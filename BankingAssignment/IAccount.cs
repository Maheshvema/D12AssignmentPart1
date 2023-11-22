using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment
{
    public interface IAccount
    {
        double Deposit(Double Amount);
        double WithDraw(Double Amount);
        double Balance { get; }
    }

}
