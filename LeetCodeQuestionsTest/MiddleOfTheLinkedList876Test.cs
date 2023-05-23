using LeetCodeQuestions._876MiddleOfTheLinkedList;

namespace LeetCodeQuestionsTest;

public class MiddleOfTheLinkedList876Test
{
    [Theory, MemberData(nameof(ListNodes))]
    public void TestExecution(ListNode head, ListNode expected)
    {
        var firstSolution = new MiddleOfTheLinkedListFirstSolution();
        var solution1Result = firstSolution.MiddleNode(head);

        Assert.Equal(expected.val, solution1Result.val);
    }

    public static IEnumerable<object[]> ListNodes()
    {
        var firstExpected = new ListNode(3, new ListNode(4, new ListNode(5)));
        var firstNode = new ListNode(1, new ListNode(2, firstExpected));
        var secondExpected = new ListNode(4, new ListNode(5, new ListNode(6)));
        var secondNode = new ListNode(1, new ListNode(2, new ListNode(3, secondExpected)));
        return new List<object[]>
        {
            new object[] { firstNode, firstExpected },
            new object[] { secondNode, secondExpected }
        };
    }
}