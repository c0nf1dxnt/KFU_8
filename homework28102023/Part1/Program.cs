using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nВ классе BankAccount удалить методы заполнения полей, создать вместо них конструкторы\n");
            
            BankAccount account1 = new BankAccount(142.52m, BankAccount.AccountType.Savings);
            BankAccount account2 = new BankAccount(124.52m);
            BankAccount account3 = new BankAccount(BankAccount.AccountType.Current);
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nCоздать класс BankTransaction, который будет хранить информацию о банковских операциях, добавить в класс BankAccount закрытое поле типа System.Collections.Queue");
            
            BankAccount account1 = new BankAccount(1823.52m, BankAccount.AccountType.Current);
            BankAccount account2 = new BankAccount(124.51m, BankAccount.AccountType.Current);
            account1.TransferMoney(account2, 1000);
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3:\nВ классе BankAccount создать метод Dispose, который переписывает данные о переводах счёта в файл");
            //Выходной файл с историей транзакций сохраняется в \homework28102023\Part1\bin\Debug\output.txt
            BankAccount account1 = new BankAccount(1823.52m, BankAccount.AccountType.Current);
            BankAccount account2 = new BankAccount(124.51m, BankAccount.AccountType.Current);
            account1.TransferMoney(account2, 1000);
            account1.Dispose(account1);
        }
        static void Task4()
        {
            Console.WriteLine("Задание №4:\nДобавить в класс Song конструкторы, создать объект mySong без параметров в его конструкторе");

            Song song1 = new Song("Wishing Well", "Juice WRLD", null);
            Song song2 = new Song("Up Up And Away", "Juice WRLD", song1);
            Song song3 = new Song();

            Console.WriteLine(song1.Title());
            Console.WriteLine(song2.Title());
            Console.WriteLine(song3.Title());
        }
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadKey();
        }
    }
}
