using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Задание \"Task Manager\"\n");

            Console.WriteLine("Создание работников...\n");
            Thread.Sleep(1000);
            Employee Ivan = new Employee("Ivan");
            Employee Sergay = new Employee("Sergay");
            Employee Grigory = new Employee("Grigory");
            Employee Anton = new Employee("Anton");
            Employee Yakov = new Employee("Yakov");
            Employee Masha = new Employee("Masha");
            Employee Sasha = new Employee("Sasha");
            Employee Tanya = new Employee("Tanya");
            Employee Kristina = new Employee("Kristina");
            Employee Dasha = new Employee("Dasha");

            Project MainProject = new Project("Помощь в разработке Counter-Strike 2", DateTime.Now.AddYears(5), "Steam", Ivan);
            Console.WriteLine($"Проект: {MainProject.ReturnDescription()}\n");
            Thread.Sleep(1000);

            Console.WriteLine("Задачи проекта:\n");
            MainProject.CreateTask("Начать перенос игры на новый движок", DateTime.Now, Ivan, Sergay);
            MainProject.CreateTask("Разработать адекватный соревновательный режим", DateTime.Now.AddMonths(6), Ivan, Grigory);
            MainProject.CreateTask("Устраненить конкурентов в лице FACEIT и ESEA (Легальными путями)", DateTime.Now.AddYears(3), Ivan, Anton);
            MainProject.CreateTask("Разработать новый анти-чит (как у Riot Games)", DateTime.Now.AddYears(1), Ivan, Yakov);
            MainProject.CreateTask("Запустить закрытый бета тест", DateTime.Now.AddYears(3), Ivan, Masha);
            MainProject.CreateTask("Оптимировать движка и устраненить баги", DateTime.Now.AddYears(4), Ivan, Sasha);
            MainProject.CreateTask("Релиз игры", DateTime.Now.AddYears(5), Ivan, Tanya);
            MainProject.CreateTask("Инвестировать в киберспорт для развития игры", DateTime.Now.AddYears(5), Ivan, Kristina);
            MainProject.CreateTask("Поддерживать игру и регурярно её обновлять", DateTime.Now.AddYears(5), Ivan, Dasha);
            MainProject.CreateTask("Забить на всё вышеперечисленное и выпустить сырую, неоптимизированную игру с плохим античитом", DateTime.Now.AddYears(5), Ivan, Ivan);
            MainProject.PrintTasks();

            Console.WriteLine("\nВсе задачи заданы и назначены\n");

            List<Report> reportList = new List<Report>
            {
                new Report("Задача выполнена",DateTime.Now, Sergay),
                new Report("Задача почти выполнена", DateTime.Now.AddMonths(6), Grigory),
                new Report("Задача не выполнена, все живы (к счастью)", DateTime.Now.AddYears(3), Anton),
                new Report("Задача провалена", DateTime.Now.AddYears(1),Yakov),
                new Report("Задача выполнена", DateTime.Now.AddYears(3), Masha),
                new Report("Задача провалена", DateTime.Now.AddYears(4), Sasha),
                new Report("Задача выполнена", DateTime.Now.AddYears(5), Tanya),
                new Report("Задача проигнорирована", DateTime.Now.AddYears(5), Kristina),
                new Report("Задача ну типа выполняется", DateTime.Now.AddYears(5), Dasha),
                new Report("Задача выполнена", DateTime.Now.AddYears(5), Ivan),
            };

            Console.ReadKey();
        }
    }
}
