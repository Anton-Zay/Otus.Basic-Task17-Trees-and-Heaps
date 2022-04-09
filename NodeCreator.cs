using System;

namespace HomeWorkOfLesson19
{
    public static class NodeCreator
    {
        public static Node CreateNode()
        {
            string name = AskAboutName();
            int salary = AskAboutSalary(name);

            return new Node(name, salary);
        }
        private static string AskAboutName()
        {
            string name = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите имя сотрудника.");
                name = Console.ReadLine();
                Console.WriteLine($"Вы ввели имя {name}. Вы подтверждаете, что имя корректно?");
                Console.WriteLine("Нажмите Enter, если да. Любую другую клавишу, если нет.");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    return name;
                }
                else
                {
                    return AskAboutName();
                }
            }
        }

        private static int AskAboutSalary(string name)
        {
            int salary;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите зарплату сотрудника.");
                bool tryParse = int.TryParse(Console.ReadLine(), out salary);
                Console.WriteLine($"Вы ввели зарплату для сотрудника {name} - {salary}. Вы подтверждаете, что зарплата корректна?");
                Console.WriteLine("Нажмите Enter, если да. Любую другую клавишу, если нет.");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    return salary;
                }
                else
                {
                    Console.Clear();
                    return AskAboutSalary(name);
                }
            }
        }
    }
}
