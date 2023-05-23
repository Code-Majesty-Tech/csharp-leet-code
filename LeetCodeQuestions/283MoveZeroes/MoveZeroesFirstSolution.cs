namespace LeetCodeQuestions._283MoveZeroes;

public class MoveZeroesFirstSolution
{
    public void MoveZeroes(int[] nums)
    {
        var newArray = new int[nums.Length];
        nums.CopyTo(newArray, 0);

        int numberOfZeroes = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var number = newArray[i];

            if (number == 0)
            {
                numberOfZeroes++;
                nums[nums.Length - numberOfZeroes] = 0;
            }
            else
            {
                nums[i - numberOfZeroes] = number;
            }
        }
    }
}