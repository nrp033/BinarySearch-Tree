namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch<int> binary = new BinarySearch<int>(56);        //56 taken as a root element
            binary.Add(30);
            binary.Add(70);
            Console.Write("Root Node is : ");
            binary.Display();
            Console.ReadKey();
        }
    }
}