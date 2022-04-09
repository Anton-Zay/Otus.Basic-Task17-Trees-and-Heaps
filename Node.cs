namespace HomeWorkOfLesson19
{
    public class Node
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public Node left { get; set; }
        public Node right { get; set; }

        public Node(string Name, int Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }
        public Node()
        {
        }

        public override string ToString()
        {
            return ("Имя сотрудника - " + Name + ". Зарплата сотрудника - " + Salary + ".");
        }
    }
}
