using System.Diagnostics;

namespace AdventOfCode2026;

public class Program
{
    static void Main()
    {
        var timer = new Stopwatch();
        timer.Start();

        var day = new TestDay();

        day.Run();
        timer.Stop();

        Console.WriteLine("Time taken: " + timer.Elapsed.ToString(@"m\:ss\.fff"));
    }
}
