using System.Transactions;

namespace LibraryIterator;

public class Iterator<T> : IIterator<T>
{
    public T CurrentItem { get; private set; }
    public T First { get; private set; }
    public bool IsDone { get; private set; }
    private int _current;
    private T[] _aggregate;


    public Iterator(T[] aggregate)
    {
        this._aggregate = aggregate;
        CurrentItem = aggregate[0];
        First = aggregate[0];
    }
    public bool HasNext()
    {
        if (_current < _aggregate.Length)
        {
            return true;
        }

        IsDone = true;
        return false;
    }

    public T Next()
    {
        if (HasNext())
        {
            _current++;
            CurrentItem = _aggregate[_current];
        }

        return First;
    }
}