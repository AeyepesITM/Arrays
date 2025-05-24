namespace Arrays.Logic;

public class MyArray
{
    #region Atributes

    private int _top;
    private int[] _array;

    #endregion Atributes

    #region Constructors

    public MyArray(int n)
    {
        N = n;
        _array = new int[n];
        _top = 0;
    }

    #endregion Constructors

    #region Properties

    public int N { get; }

    public bool IsFull => _top == N;
    public bool IsEmpty => _top == 0;

    #endregion Properties

    #region Methods

    public void Add(int value)
    {
        if (IsFull)
        {
            throw new Exception("Array is full.");
        }
        _array[_top] = value;
        _top++;
    }

    public void Insert(int value, int index)
    {
        if (IsFull)
        {
            throw new Exception("Array is full.");
        }

        if (index < 0)
        {
            index = 0;
        }

        if (index > _top)
        {
            index = _top;
        }
        for (int i = _top; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }
        _array[index] = value;
        _top++;
    }

    public void Remove(int index)
    {
        if (IsEmpty)
        {
            throw new Exception("Array is empty.");
        }
        if (index < 0)
        {
            index = 0;
        }
        if (index > _top)
        {
            index = _top;
        }
        for (int i = index; i < _top - 1; i++)
        {
            _array[i] = _array[i + 1];
        }
        _top--;
    }

    public void Fill()
    {
        Fill(0, 100);
    }

    public void Fill(int minimun, int maximun)
    {
        Random random = new();
        for (int i = 0; i < N; i++)
        {
            _array[i] = random.Next(minimun, maximun);
        }
        _top = N;
    }

    public MyArray GetOdds()
    {
        var countOdds = 0;
        for (int i = 0; i < _top; i++)
        {
            if (_array[i] % 2 != 0)
            {
                countOdds++;
            }
        }
        var oddsArray = new MyArray(countOdds);
        for (int i = 0; i < _top; i++)
        {
            if (_array[i] % 2 == 0)
            {
                oddsArray.Add(_array[i]);
            }
        }
        return oddsArray;
    }

    public override string ToString()
    {
        if (IsEmpty)
        {
            return "Empty array.";
        }

        string output = string.Empty;
        int count = 0;
        for (int i = 0; i < _top; i++)
        {
            {
                output += $"{_array[i],5}\t";
                count++;
                if (count % 9 == 0)
                {
                    output += Environment.NewLine;
                }
            }
        }
        return output;
    }

    public void Sort()
    {
        Sort(false);
    }

    public void Sort(bool descending)
    {
        for (int i = 0; i < _top - 1; i++)
        {
            for (int j = i + 1; j < _top; j++)
            {
                if (descending)
                {
                    if (_array[i] > _array[j])
                    {
                        Change(ref _array[i], ref _array[j]);
                    }
                }
                else
                {
                    if (_array[i] < _array[j])
                    {
                        Change(ref _array[i], ref _array[j]);
                    }
                }
            }
        }
    }

    private void Change(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    #endregion Methods
}