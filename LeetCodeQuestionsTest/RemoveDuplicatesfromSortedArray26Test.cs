using LeetCodeQuestions._26RemoveDuplicatesfromSortedArray;

namespace LeetCodeQuestionsTest;

public class RemoveDuplicatesfromSortedArray26Test
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    [InlineData(new[] { 1,2 }, 2)]
    public void TestExecution(int[] nums, int expected)
    {
        var firstSolution = new RemoveDuplicatesfromSortedArrayFirstSolution();
        var solution1Result = firstSolution.RemoveDuplicates(nums);

        Assert.Equal(expected, solution1Result);
    }
}