namespace LeetCodeQuestions._26RemoveDuplicatesfromSortedArray;

public class RemoveDuplicatesfromSortedArrayFirstSolution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var number = nums[i];

            if (k == 0 || (nums[i - 1] != number))
            {
                nums[k] = number;
                k++;
            }
        }


        return k;
    }
}