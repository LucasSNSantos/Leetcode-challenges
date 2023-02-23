

using LeetCodeSolutions.Solutions;

public class Program
{

    public static void Main(string[] args)
    {
        SolutionCommonPrefix solution = new SolutionCommonPrefix();

        string answer = solution.LongestCommonPrefix(new string[]{"ab","a"});
        Console.WriteLine(answer);

    }
}