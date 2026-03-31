namespace StacksAndQueus.Backend;

public class QueueUsingList<T> : IQueue<T>
{
    private List<T> _queue = [];
    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = _queue[0];
        _queue.RemoveAt(0);
        return item;
    }

    public void Enqueue(T item)
    {
        _queue.Add(item);
    }
}
