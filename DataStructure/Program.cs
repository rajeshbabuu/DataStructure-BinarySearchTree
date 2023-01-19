namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");

            BinarySearchTree<int> objBinary = new BinarySearchTree<int>(56);
            objBinary.Add(30);
            objBinary.Add(70);
            objBinary.Add(22);
            objBinary.Add(40);
            objBinary.Add(60);
            objBinary.Add(95);
            objBinary.Add(11);
            objBinary.Add(65);
            objBinary.Add(3);
            objBinary.Add(16);
            objBinary.Add(63);
            objBinary.Add(67);

            Console.WriteLine("\nSorted Binary Tree ==>");
            objBinary.Display();

            objBinary.Size();

            BinarySearchTree<int> node = objBinary.FindElement(63, objBinary);
            Console.WriteLine($"\nElement is : {node.NodeData}");

            Console.ReadLine();
        }
    }
}