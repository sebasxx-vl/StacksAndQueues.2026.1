namespace StacksAndQueus.Backend;

public class QueueUsingArray<T> : IQueue<T>
{
    private T[] _queue;
    private int _front;
    private int _rear;
    private int _count;

    public QueueUsingArray(int capacity)
    {
        _queue = new T[capacity];
        _front = 0;
        _rear = -1;
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _queue.Length)
        {
            throw new InvalidOperationException("La cola está llena.");
        }
        _rear = (_rear + 1) % _queue.Length;
        _queue[_rear] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("La cola está vacía.");
        }
        var item = _queue[_front];
        _front = (_front + 1) % _queue.Length;
        _count--;
        return item;
    }
}
