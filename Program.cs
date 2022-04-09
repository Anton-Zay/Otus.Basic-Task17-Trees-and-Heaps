using System;
using System.Collections;

namespace HomeWorkOfLesson19
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        private void start()
        {
            EmployeeTree employeeTree = new EmployeeTree();
            bool finishCreate = false;

            while (!finishCreate)
            {
                Node node = NodeCreator.CreateNode();
                employeeTree.Add(node);
                finishCreate = AskAboutFinish();
            }

            Traverse(employeeTree.root);

            Console.WriteLine("Для продолжения работы программы нажмите любую кнопку");
            Console.ReadKey();

            SearchBySalaryStartMethod(employeeTree);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Если вы хотите создать новый список сотрудников, нажмите цифру 0.\n" +
                    "Если хотите выполнить новый поиск по зарплате в текущем списке, нажмите цифру 1.\n" +
                    "Если хотите завершить программу нажмите любую кнопку.");

                int x = (int)Console.ReadKey().Key;

                if (x == 48 || x == 96)
                {
                    start();
                }
                else if (x == 49 || x == 97)
                {
                    SearchBySalaryStartMethod(employeeTree);
                }
                else
                {
                    break;
                }
            }
        }

        private bool AskAboutFinish()
        {
            Console.Clear();
            Console.WriteLine("Вы закончили вводить данные?\nНажмите Enter, если нет. Любую другую клавишу, если да");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SearchBySalaryStartMethod(EmployeeTree emplotyeeTree)
        {
            Console.Clear();
            Console.WriteLine("Введите зарплату, по которой найти сотрудников.");
            var searchSalary = Console.ReadLine();
            int valueSearchSalary;
            bool tryParse = int.TryParse(searchSalary, out valueSearchSalary);

            emplotyeeTree.searchList = new ArrayList();
            emplotyeeTree.SearchBySalary(emplotyeeTree.root, valueSearchSalary);

            if (emplotyeeTree.searchList.Count == 0)
            {
                Console.WriteLine("Сотрудника(-ов) с такой зарплатой не найдено.");
            }
            else
            {
                foreach (Node searchNode in emplotyeeTree.searchList)
                {
                    Console.WriteLine(searchNode);
                }
            }
            Console.WriteLine("Для продолжения работы программы нажмите любую кнопку");
            Console.ReadKey();
        }

        private void Traverse(Node node)
        {
            if (node.left != null)
            {
                Traverse(node.left);
            }

            Console.WriteLine(node);

            if (node.right != null)
            {
                Traverse(node.right);
            }
        }
    }
}