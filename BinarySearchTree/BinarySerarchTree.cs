namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(T key)
        {
            Root = AddRecursively(Root, key);
        }

        private Node<T> AddRecursively(Node<T> current, T key)
        {
            if (current == null)
            {
                current = new Node<T>(key);
                return current;
            }

            if (key.CompareTo(current.Key) < 0)
                current.Left = AddRecursively(current.Left, key);
            else if (key.CompareTo(current.Key) > 0)
                current.Right = AddRecursively(current.Right, key);

            return current;
        }

        public int Size()
        {
            return SizeRecursively(Root);
        }

        private int SizeRecursively(Node<T> current)
        {
            if (current == null)
                return 0;
            else
                return (SizeRecursively(current.Left) + 1 + SizeRecursively(current.Right));
        }
    }
}