using System.Collections;

namespace LeetCodeQuestions._234PalindromeLinkedList;

public class PalindromeLinkedListFirstSolution
{
    public bool IsPalindrome(ListNode head)
    {
        if (head.next is null)
        {
            return true;
        }

        var all = new List<int>();

        while (true)
        {
            all.Add(head.val);

            if (head.next is null)
            {
                break;
            }

            head = head.next;
        }

        int splitNumber = all.Count / 2;
        int skipNumber = 0;

        if (all.Count % 2 == 1)
        {
            skipNumber = 1;
        }

        splitNumber = all.Count / 2;

        var firstHalf = all.Take(splitNumber).ToArray();
        var secondHalf = all.Skip(splitNumber + skipNumber).Reverse().ToArray();

        for (var i = 0; i < firstHalf.Length; i++)
        {
            if (firstHalf[i] != secondHalf[i])
            {
                return false;
            }
        }

        return true;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}