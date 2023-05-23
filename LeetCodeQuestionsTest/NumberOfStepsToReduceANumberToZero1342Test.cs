using LeetCodeQuestions._1342NumberOfStepsToReduceANumberToZero;

namespace LeetCodeQuestionsTest;

public class NumberOfStepsToReduceANumberToZero1342Test
{
    [Theory]
    [InlineData(14, 6)]
    [InlineData(8, 4)]
    public void TestExecution(int num, int expected)
    {
        var firstSolution = new NumberOfStepsToReduceANumberToZeroFirstSolution();
        var solution1Result = firstSolution.NumberOfSteps(num);

        Assert.Equal(expected, solution1Result);
    }
}