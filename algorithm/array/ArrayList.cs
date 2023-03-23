namespace algorithim.array;
public class ArrayList
{

    private int[] _array;
    private const int _defaultCapacity = 10;
    private int currentCount = 0;


    public int Length => currentCount;
    public ArrayList() : this(_defaultCapacity)
    {

    }

    public int this[int index]
    {
        get
        {
            return _array[index];
        }

        set
        {
            if (index <= 0) throw new ArgumentOutOfRangeException($"{index}必须大于0");
            if (index > currentCount - 1) throw new ArgumentOutOfRangeException($"{index}超出范围！");
            _array[index] = value;

        }

    }
    public ArrayList(int capacity)
    {
        if (capacity <= 0) throw new ArgumentOutOfRangeException($"{capacity}必须大于0");
        _array = new int[capacity];
    }

    private bool HaveCapacity()
    {
        return currentCount < _array.Length;
    }
    private void AddCapacity()
    {
        var newArray = new int[_array.Length * 2];
        for (var i = 0; i < currentCount - 1; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
    }

    public int FindIndex(int value)
    {

        for (var i = 0; i < currentCount - 1; i++)
        {
            if (value == _array[i])
            {

                return i;
            }
        }
        return -1;  //TODO:这里是返回-1好？还是抛出异常好呢?用户的预期是必须找到，还是可以不找到呢？
    }

    public void Add(int value)
    {

        if (HaveCapacity())
        {
            _array[currentCount++] = value;
        }
        else
        {
            AddCapacity();
            _array[currentCount++] = value;
        }

    }

    public void Insert(int index, int value)
    {

        if (HaveCapacity())
        {

            for (var i = currentCount - 1; i >= index; i--)
            {

                _array[i + 1] = _array[i];
            }
            _array[index] = value;
            currentCount++;

        }
        else
        {
            AddCapacity();
            Insert(index, value);

        }


    }

    public void Delete(int value)
    {
        var index = FindIndex(value);
        if (index != -1)
        {
            RemoveAt(index);
        }

    }

    public void RemoveAt(int index)
    {

        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("index不能小0");
        }
        if (index > currentCount - 1)
        {
            throw new ArgumentOutOfRangeException($"index不能大于{currentCount - 1}");
        }

        for (var i = index; i < currentCount - 1; i++)
        {
            _array[i] = i == currentCount - 1 ? 0 : _array[i + 1];
        }
        currentCount--;
        _array[currentCount - 1] = 0;

    }

    public override string ToString()
    {
        return string.Join('-', _array.Take(currentCount));
    }


}