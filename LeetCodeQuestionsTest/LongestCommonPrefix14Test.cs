using LeetCodeQuestions._14LongestCommonPrefix;

namespace LeetCodeQuestionsTest;

public class LongestCommonPrefix14Test
{
    [Theory]
    [InlineData(new string[] { "flower","flow","flight" }, "fl")]
    [InlineData(new string[] { "","" }, "")]
    [InlineData(new string[] { "cir","car" }, "c")]
    public void TestExecution(string[] ransomNote, string expected)
    {
        var firstSolution = new LongestCommonPrefixFirstSolution();
        var solution1Result = firstSolution.LongestCommonPrefix(ransomNote);

        Assert.Equal(expected, solution1Result);
    }
}