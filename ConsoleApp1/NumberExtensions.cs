namespace ConsoleApp1;
public class NumberExtensions
{
    public static double GetAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        return numbers.Average();
    }
}