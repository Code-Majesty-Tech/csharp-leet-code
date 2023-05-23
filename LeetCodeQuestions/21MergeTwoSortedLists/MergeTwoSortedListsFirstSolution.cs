namespace LeetCodeQuestions._21MergeTwoSortedLists;

public class MergeTwoSortedListsFirstSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode nodeForReturn = null;
        ListNode newNode = null;

        bool isFirst = true;
        while (true)
        {
            if (list2 != null && list1 != null)
            {
                if (list1.val < list2.val)
                {
                    if (newNode == null)
                    {
                        newNode = new ListNode(list1.val);
                    }
                    else
                    {
                        newNode.next = new ListNode(list1.val);
                    }

                    list1 = list1.next;
                }
                else
                {
                    if (newNode == null)
                    {
                        newNode = new ListNode(list2.val);
                    }
                    else
                    {
                        newNode.next = new ListNode(list2.val);
                    }

                    list2 = list2.next;
                }
            }
            else if (list1 == null && list2 == null)
            {
                break;
            }
            else if (list1 == null)
            {
                if (newNode == null)
                {
                    newNode = new ListNode(list2.val);
                }
                else
                {
                    newNode.next = new ListNode(list2.val);
                }

                list2 = list2.next;
            }
            else if (list2 == null)
            {
                if (newNode == null)
                {
                    newNode = new ListNode(list1.val);
                }
                else
                {
                    newNode.next = new ListNode(list1.val);
                }

                list1 = list1.next;
            }

            if (isFirst)
            {
                isFirst = false;
                nodeForReturn = newNode;
            }
            else
            {
                newNode = newNode.next;
            }

            if (list1 == null && list2 == null)
            {
                break;
            }
        }

        return nodeForReturn;
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