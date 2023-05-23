using LeetCodeQuestions._21MergeTwoSortedLists;

namespace LeetCodeQuestionsTest;

public class MergeTwoSortedLists21Test
{
    [Theory, MemberData(nameof(ListNodes))]
    public void TestExecution(ListNode list1, ListNode list2, ListNode expected)
    {
        var firstSolution = new MergeTwoSortedListsFirstSolution();
        var solution1Result = firstSolution.MergeTwoLists(list1, list2);

        Assert.Equal(expected.val, solution1Result.val);
    }

    public static IEnumerable<object[]> ListNodes()
    {
        return new List<object[]>
        {
            new object[]
            {
                new ListNode(),
                new ListNode(),
                new ListNode(),
            },
            new object[]
            {
                new ListNode(),
                new ListNode(),
                new ListNode(),
            }
        };
    }
}