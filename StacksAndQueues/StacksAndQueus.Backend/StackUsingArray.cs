namespace StacksAndQueus.Backend;

public class StackUsingArray<T> : IStack<T>
{
    private T[] _stack;
    private int _top;

    public StackUsingArray(int capacity)
    {
        _stack = new T[capacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == _stack.Length - 1)
        {
            throw new InvalidOperationException("Stack is full");
        }
        _stack[++_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_top--];
    }

    public T Peek()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_top];
    }
}
