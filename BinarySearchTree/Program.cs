namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);

            Console.WriteLine("BST created with elements 56, 30, and 70");
        }
    }
}