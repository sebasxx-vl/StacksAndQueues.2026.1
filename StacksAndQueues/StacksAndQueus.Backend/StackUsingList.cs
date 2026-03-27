namespace StacksAndQueus.Backend;

public class StackUsingList<T> : IStack<T>
{
    private List<T> _stack = [];

    public T Peek()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _stack[_stack.Count - 1];
        return item;
    }

    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }

    public void Push(T item)
    {
        _stack.Add(item);
    }
}
