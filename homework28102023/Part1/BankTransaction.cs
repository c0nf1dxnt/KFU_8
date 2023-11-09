using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class BankTransaction
    {
        private readonly DateTime transactionTime;
        private readonly decimal amount;

        public BankTransaction(decimal Amount)
        {
            transactionTime = DateTime.Now;
            amount = Amount;
        }
        public string PrintInfoAboutTransaction()
        {
            return $"Транзакция на сумму {amount}₽ была совершена в {transactionTime}\n";
        }
    }
}
