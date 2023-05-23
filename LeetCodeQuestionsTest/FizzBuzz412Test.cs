using LeetCodeQuestions._412FizzBuzz;

namespace LeetCodeQuestionsTest;

public class FizzBuzz412Test
{
    [Theory, MemberData(nameof(Results))]
    public void TestExecution(int n, List<string> results)
    {
        var firstSolution = new FizzBuzzFirstSolution();
        var solution1Result = firstSolution.FizzBuzz(n);

        Assert.Equal(results, solution1Result);
    }

    public static IEnumerable<object[]> Results =>
        new List<object[]>
        {
            new object[] { 3, new List<string>() { "1", "2", "Fizz" } },
            new object[] { 5, new List<string>() { "1","2","Fizz","4","Buzz" } },
            new object[] { 15, new List<string>() { "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz" } },
        };
}