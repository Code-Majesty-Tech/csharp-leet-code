using LeetCodeQuestions._383RansomNote;

namespace LeetCodeQuestionsTest;

public class RansomNote383Test
{
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void TestExecution(string ransomNote, string magazine, bool expected)
    {
        var firstSolution = new RansomNoteFirstSolution();
        var solution1Result = firstSolution.CanConstruct(ransomNote, magazine);

        Assert.Equal(expected, solution1Result);
    }
}