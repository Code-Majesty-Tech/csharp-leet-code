using LeetCodeQuestions._13RomanToInteger;
using LeetCodeQuestions._234PalindromeLinkedList;

namespace LeetCodeQuestionsTest;

public class PalindromeLinkedList234Test
{
    [Theory, MemberData(nameof(ListNodes))]
    public void TestExecution(ListNode head, bool expected)
    {
        var firstSolution = new PalindromeLinkedListFirstSolution();
        var solution1Result = firstSolution.IsPalindrome(head);

        Assert.Equal(expected, solution1Result);
    }

    public static IEnumerable<object[]> ListNodes =>
        new List<object[]>
        {
            new object[] { new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1)))), true },
            new object[] { new ListNode(1, new ListNode(2)), false },
            new object[] { new ListNode(1), true },
            new object[] { new ListNode(1, new ListNode(0, new ListNode(1))), true },
            new object[] { new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(1))))), false },
        };
}