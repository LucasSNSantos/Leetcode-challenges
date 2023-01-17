

using LeetCodeSolutions.Solutions;

public class Program
{

    public static void Main(string[] args)
    {
        SolutionRomanNumbers solution = new SolutionRomanNumbers();
        int number = solution.RomanToInt("MCMXCIV"); 
        Console.WriteLine(number);
    }
}