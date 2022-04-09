using System.Collections;

namespace HomeWorkOfLesson19
{
    class EmployeeTree
    {
        public ArrayList searchList;
        public Node root { get; private set; }
        public Node cellHolder { get; private set; }

        public void Add(Node node)
        {


            if (root == null)
            {
                root = node;
            }
            else
            {
                cellHolder = root;
                Add(node, cellHolder);
            }
        }
        public void Add(Node node, Node cellHolder)
        {
            if (cellHolder.left == null && node.Salary <= cellHolder.Salary)
            {
                cellHolder.left = node;
            }
            else if (cellHolder.left != null && node.Salary <= cellHolder.Salary)
            {
                Add(node, cellHolder.left);
            }
            else if (cellHolder.right == null && node.Salary > cellHolder.Salary)
            {
                cellHolder.right = node;
            }
            else
            {
                Add(node, cellHolder.right);
            }

        }

        public void SearchBySalary(Node current, int valueSearchSalary)
        {
            if (current.left != null)
            {
                SearchBySalary(current.left, valueSearchSalary);
            }

            if (current.Salary == valueSearchSalary)
            {
                searchList.Add(current);
            }

            if (current.right != null)
            {
                SearchBySalary(current.right, valueSearchSalary);
            }
        }
    }
}
