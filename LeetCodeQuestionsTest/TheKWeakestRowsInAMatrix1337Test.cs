using LeetCodeQuestions._1337TheKWeakestRowsInAMatrix;

namespace LeetCodeQuestionsTest;

public class TheKWeakestRowsInAMatrix1337Test
{
    [Theory, MemberData(nameof(Rows))]
    public void TestExecution(int[][] mat, int k, int[] expected)
    {
        var firstSolution = new TheKWeakestRowsInAMatrixFirstSolution();
        var solution1Result = firstSolution.KWeakestRows(mat, k);

        Assert.Equal(expected, solution1Result);
    }

    public static IEnumerable<object[]> Rows =>
        new List<object[]>
        {
            new object[]
            {
                new[]
                {
                    new[] { 1, 1, 0, 0, 0 },
                    new int[] { 1, 1, 1, 1, 0 },
                    new int[] { 1, 0, 0, 0, 0 },
                    new int[] { 1, 1, 0, 0, 0 },
                    new int[] { 1, 1, 1, 1, 1 }
                },
                3, new int[] { 2, 0, 3 }
            }
        };
}