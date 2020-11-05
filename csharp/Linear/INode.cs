namespace Linear
{
    public interface INode<T>
    {
        T Value { get; set; }
        INode<T> Next { get; set; }
    }
}