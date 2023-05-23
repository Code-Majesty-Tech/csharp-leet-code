using LeetCodeQuestions;
using LeetCodeQuestions._13RomanToInteger;

namespace LeetCodeQuestionsTest;

public class RomanToInteger13Test
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    [InlineData("III", 3)]
    [InlineData("XX", 20)]
    [InlineData("CCC", 300)]
    [InlineData("MM", 2000)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("DCXXI", 621)]
    [InlineData("MMCDXXV", 2425)]
    [InlineData("MDCXCV", 1695)]
    public void TestExecution(string roman, int expected)
    {
        var firstSolution = new RomanToIntegerFirstSolution();
        var solution1Result = firstSolution.RomanToInt(roman);

        var secondSolution = new RomanToIntegerSecondSolution();
        var solution2Result = secondSolution.RomanToInt(roman);

        Assert.Equal(expected, solution1Result);
        Assert.Equal(expected, solution2Result);
    }
}