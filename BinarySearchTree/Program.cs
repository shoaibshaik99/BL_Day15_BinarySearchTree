namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter use case number (1 or 2):");
            int useCase = Convert.ToInt32(Console.ReadLine());

            switch (useCase)
            {
                case 1:
                    ExecuteUseCase1();
                    break;
                case 2:
                    ExecuteUseCase2();
                    break;
                default:
                    Console.WriteLine("Invalid use case number");
                    break;
            }
        }

        static void ExecuteUseCase1()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);

            Console.WriteLine("BST created with elements 56, 30, and 70");
        }

        static void ExecuteUseCase2()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Add(22);
            bst.Add(40);
            bst.Add(60);
            bst.Add(95);
            bst.Add(11);
            bst.Add(65);
            bst.Add(3);
            bst.Add(16);
            bst.Add(63);
            bst.Add(67);

            Console.WriteLine("BST created with elements 56, 30, 70, 22, 40, 60, 95, 11, 65, 3, 16, 63, and 67");
            Console.WriteLine("Number of nodes in BST: " + bst.Size());
        }
    }
}