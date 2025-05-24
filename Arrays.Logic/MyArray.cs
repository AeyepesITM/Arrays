namespace Arrays.Logic;

public class MyArray
{
    #region Constructors

    public MyArray(int n)
    {
        N = n;
        _array = new int[n];
        _top = 0;
    }

    #endregion Constructors

    #region Atributes

    private int _top;
    private int[] _array;

    #endregion Atributes

    #region Properties

    public int N { get; }

    public bool IsFull => _top == N;
    public bool IsEmpty => _top == 0;

    #endregion Properties

    #region Methods

    public void Fill(int minimun, int maximun)
    {
        Random random = new();
        for (int i = 0; i < N; i++)
        {
            _array[i] = random.Next(minimun, maximun);
        }
        _top = N;
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

        #endregion Methods
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
}