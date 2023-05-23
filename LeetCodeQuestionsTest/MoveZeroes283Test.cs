using LeetCodeQuestions._283MoveZeroes;

namespace LeetCodeQuestionsTest;

public class MoveZeroes283Test
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    public void TestExecution(int[] nums, int[] expected)
    {
        var firstSolution = new MoveZeroesFirstSolution();
        firstSolution.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }
}