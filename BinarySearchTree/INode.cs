namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T Key { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }
}
