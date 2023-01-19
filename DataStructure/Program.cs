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
            Console.WriteLine("\nElements in a Binary Tree ==>");
            objBinary.Display();
        }
    }
}