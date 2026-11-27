using System;

namespace AdventOfCode2026;

public class Grid //: IEnumerable<IEnumerable<T>>
{
    public int _yMax { get; set; }
    public int _xMax { get; set; }
    private char[,] _array;

    public Grid(string multipleLineInput)
    {
        var allLines = multipleLineInput.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        _yMax = allLines.Count() - 1;
        _xMax = allLines.First().Length - 1;

        _array = new char[_xMax + 1, _yMax + 1];

        for (int y = _yMax; y >= 0; y--)
        {
            var line = allLines[_yMax - y].ToCharArray();

            for (int x = 0; x <= _xMax; x++)
            {
                _array[x, y] = line[x];
            }
        }
    }

    public int Width() => _xMax + 1;
    public int Height() => _yMax + 1;
    public char Value(int x, int y) => _array[x, y];

    public void Print()
    {
        for (int y = _yMax; y >= 0; y--)
        {
            for (int x = 0; x <= _xMax; x++)
            {
                Console.Write(_array[x, y]);
            }
            Console.Write("\n");
        }
        Console.WriteLine();
    }
}