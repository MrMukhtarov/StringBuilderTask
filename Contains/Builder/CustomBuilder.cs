namespace Containss.Builder;

public class CustomBuilder
{
    private char[] _arr;
    private int _capacity = 16;
    private int _length = 0;
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            if (value < _length)
            {
                throw new Exception($"Length must be more than {_length}");
            }
            if (value > _capacity && value <= 2 * _capacity)
            {
                Capacity *= 2;
            }
            if (value > 2 * _capacity)
            {
                Capacity = value;
            }
            _length = value;
        }
    }
    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value cannot be less than zero");
            }
            if (value < Length)
            {
                throw new Exception($"Capacity must be more than {Length}");
            }
            _capacity = value;
            Array.Resize(ref _arr, _capacity);
        }
    }

    public CustomBuilder()
    {
        _arr = new char[_capacity];
    }
    public override string ToString()
    {
        return new string(_arr, 0, _length);
    }
    public void Append(char item)
    {
        if (Length > Capacity)
        {
            Capacity *= 2;
        }
        _arr[_length] = item;
        _length++;
    }

    public void Replace(char oldChar, char newChar)
    {
        for (int i = 0; i < Length; i++)
        {
            if (_arr[i] == oldChar)
            {
                _arr[i] = newChar;
            }
            else
            {
                _arr[i] = _arr[i];
            }
        }
    }

}
