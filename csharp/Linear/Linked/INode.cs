namespace Linear.Linked
{
    public interface INode<T>
    {
        T Value { get; set; }
        INode<T> Next { get; set; }
    }

    public interface IDoublyNode<T> : INode<T>
    {
        new IDoublyNode<T> Next { get; set; }
        IDoublyNode<T> Previous { get; set; }
    }

    public class Node<T> : INode<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public Node(T value, INode<T> next) : this(value)
        {
            this.Next = next;
        }

        public T Value { get; set; }
        public INode<T> Next { get; set; }
    }

    public class DoublyNode<T> : Node<T>, IDoublyNode<T>
    {
        public DoublyNode(T value) : base(value)
        {
        }

        public DoublyNode(T value, INode<T> next) : base(value, next)
        {
        }
        public DoublyNode(T value, IDoublyNode<T> next, IDoublyNode<T> previous) : base(value, next)
        {
            this.Previous = previous;
        }

        public new IDoublyNode<T> Next { get; set; }
        public IDoublyNode<T> Previous { get; set; }
    }
}