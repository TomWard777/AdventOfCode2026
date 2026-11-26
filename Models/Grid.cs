using System;

namespace AdventOfCode2026;

public class Grid //: IEnumerable<IEnumerable<T>>
{
    // TODO [TW] Try and implement something like Queue in C#
    // https://github.com/dotnet/dotnet/blob/297acf930fb0f5c07fd4e51d78e521b4ad2e5d1f/src/runtime/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/Queue.cs#L39C9-L43C10
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

    /*
    public static (int, int, char[][]) ReadToMatrixTuple(IEnumerable<string> input)
    {
        var m = input.Count();
        var n = input.First().Length;

        var mat = input
        .Select(x => x.ToCharArray())
        .ToArray();

        return (m, n, mat);
    }
    */
}