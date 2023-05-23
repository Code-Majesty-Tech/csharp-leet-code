using LeetCodeQuestions._1672RichestCustomerWealth;

namespace LeetCodeQuestionsTest;

public class RichestCustomerWealthFirsSolutionTest
{
    [Theory, MemberData(nameof(Rows))]
    public void TestExecution(int[][] accounts, int expected)
    {
        var firstSolution = new RichestCustomerWealthFirsSolution();
        var solution1Result = firstSolution.MaximumWealth(accounts);

        Assert.Equal(expected, solution1Result);
    }

    public static IEnumerable<object[]> Rows =>
        new List<object[]>
        {
            new object[]
            {
                new[]
                {
                    new[] { 1, 2, 3 },
                    new int[] { 3, 2, 1 }
                },
                6
            },
            new object[]
            {
                new[]
                {
                    new[] { 1, 5 },
                    new int[] { 7, 3 },
                    new int[] { 3, 5 }
                },
                10
            }
        };
}