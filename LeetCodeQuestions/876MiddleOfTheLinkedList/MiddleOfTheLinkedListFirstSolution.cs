namespace LeetCodeQuestions._876MiddleOfTheLinkedList;

public class MiddleOfTheLinkedListFirstSolution
{
    public ListNode MiddleNode(ListNode head)
    {
        var dict = new Dictionary<int, ListNode>();

        int counter = 1;
        while (true)
        {
            dict.Add(counter, head);

            if (head.next is null)
            {
                break;
            }

            head = head.next;
            counter++;
        }

        var split = dict.Count / 2 + 1;

        // if (dict.Count % 2 == 1)
        // {
        //     split += 1;
        // }

        return dict[split];
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