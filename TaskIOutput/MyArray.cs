using TaskIMath;
using TaskISort;

namespace TaskIOutput;

internal class MyArray : IOutput, IMath, ISort
{
    private int[] _numArray;

    public MyArray(params int[] numArray)
    {
        _numArray = numArray;
    }

    #region IMath


    public int Max()
    {
        return _numArray.Max();
    }

    public int Min()
    {
        return _numArray.Min();
    }
    public float Avg()
    {
        return (float)_numArray.Average();
    }

    public bool Search(int valueToSearch)
    {
        return _numArray.Contains(valueToSearch);
    }

    #endregion

    #region IOutput
    public void Show()
    {
        Console.Write("The numbers we have: ");
        for (int i = 0; i < _numArray.Length; i++)
        {
            if (i == _numArray.Length - 1)
            {
                Console.Write($"{_numArray[i]}.\n\n");
            }
            else
            {
                Console.Write($"{_numArray[i]}, ");
            }
        }
    }

    public void Show(string info)
    {
        Console.WriteLine($"Info: {info}");
        Show();
    }

    #endregion

    #region ISort
    public void SortAsc()
    {
        Array.Sort(_numArray);
    }

    public void SortDesc()
    {
        Array.Sort( _numArray);
        Array.Reverse(_numArray);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }
    #endregion
}
