using System;
using System.Collections.Generic;
using System.IO;

namespace Part1
{
    class BankAccount
    {
        public enum AccountType
        {
            Current,
            Savings
        }
        
        private static int generatedAccountNumber = 1;
        private int accountNumber;
        private decimal accountBalance;
        private AccountType accountType;
        private Queue<BankTransaction> transactionHistory = new Queue<BankTransaction>();

        /// <summary>
        /// Конструктор, используемый для заполнения полей экземпляра класса BankAccount,
        /// вызывающийся при передаче в него значений accountBalance и accountType
        /// </summary>
        /// <param name="accountBalance">Баланс счёта</param>
        /// <param name="accountType">Тип счёта</param>
        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            accountNumber = GenerateAccountNumber();
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }

        /// <summary>
        /// Конструктор, используемый для заполнения полей экземпляра класса BankAccount,
        /// вызывающийся при передаче в него значения accountBalance
        /// </summary>
        /// <param name="accountBalance">Баланс счёта</param>
        public BankAccount(decimal accountBalance)
        {
            accountNumber = GenerateAccountNumber();
            this.accountBalance = accountBalance;
            accountType = AccountType.Current;
        }

        /// <summary>
        /// Конструктор, используемый для заполнения полей экземпляра класса BankAccount,
        /// вызывающийся при передаче в него значения accountType
        /// </summary>
        /// <param name="accountType">Тип счёта</param>
        public BankAccount(AccountType accountType)
        {
            accountNumber = GenerateAccountNumber();
            accountBalance = 0;
            this.accountType = accountType;
        }

        public static int GenerateAccountNumber()
        {
            return generatedAccountNumber++;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetAccountBalance()
        {
            return accountBalance;
        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= accountBalance)
            {
                accountBalance -= amount;
                AddTransactionToHistory(amount);
                Console.WriteLine($"Со счёта {accountNumber} было успешно снято {amount}₽!\nТеперь баланс данного счёта составляет {accountBalance}₽\n");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Снятие отрицательной суммы невозможно!");
            }
            else
            {
                Console.WriteLine($"Невозможно снять {amount}₽, так как текущий баланс составляет {accountBalance}₽!\nНедостаточно средств!\n");
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                AddTransactionToHistory(amount);
                Console.WriteLine($"Со счёта {accountNumber} было успешно снято {amount}₽!\nТеперь баланс данного счёта составляет {accountBalance}₽\n");
            }
            else
            {
                Console.WriteLine("Внесение отрицательной суммы невозможно!\n");
            }
        }
        public void TransferMoney(BankAccount recipient, decimal amount)
        {
            if (amount > 0 && accountBalance >= amount && accountNumber != recipient.accountNumber)
            {
                accountBalance -= amount;
                recipient.accountBalance += amount;
                AddTransactionToHistory(amount);
                Console.WriteLine($"Пользователь со счётом {accountNumber} успешно перевёл {amount}₽ на счёт {recipient.accountNumber}!\nТеперь на его счету {accountBalance}₽\n");
            }
            else if (accountNumber.Equals(recipient.accountNumber))
            {
                Console.WriteLine("Перевод самому себе невозможен!");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Переводимая сумма должна быть положительной!");
            }
            else
            {
                Console.WriteLine("Перевод невозможен, на счету отправителя недостаточно средств!\nПополните счёт и повторите попытку\n");
            }
        }
        /// <summary>
        /// Метод, добавляющий транзакцию в историю транзакций, для упрощения кода
        /// </summary>
        /// <param name="amount">Сумма</param>
        private void AddTransactionToHistory(decimal amount)
        {
            BankTransaction transaction = new BankTransaction(amount);
            transactionHistory.Enqueue(transaction);
            Console.Write(transaction.PrintInfoAboutTransaction());
        }
        /// <summary>
        /// Метод Dispose, сохраняющий данные о транзакциях аккаунта в файл output.txt, находящийся в \homework28102023\Part1\bin\Debug\output.txt
        /// </summary>
        /// <param name="account">Аккаунт, историю транзакций которого мы сохраняем в файл</param>
        public void Dispose(BankAccount account)
        {
            string outputFileName = "output.txt";
            File.Delete(outputFileName);
            for (int i = 0; i < transactionHistory.Count; i++)
            {
                BankTransaction transaction = transactionHistory.Dequeue();
                File.AppendAllText(outputFileName, transaction.PrintInfoAboutTransaction());
            }
            GC.SuppressFinalize(account);
        }
    }
}
