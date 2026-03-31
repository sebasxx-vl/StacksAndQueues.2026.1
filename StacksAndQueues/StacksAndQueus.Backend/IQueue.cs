namespace StacksAndQueus.Backend;

public interface IQueue<T>
{
    T Dequeue();
    void Enqueue(T item);
}