namespace AdventOfCode2026;

public class TestDay
{
    public const string _input = @"987654321111111
811111111111119
234234234234278
818181911112111";

    public void Run()
    {
        var grid = new Grid(_input);

        Console.WriteLine($"\nPrint test \n");
        grid.Print();
    }
}