namespace Linear.Linked
{
    public interface INode<T>
    {
        T Value { get; set; }
        INode<T> Next { get; set; }
    }
    
    public class Node<T> : INode<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public INode<T> Next { get; set; }
    }
}