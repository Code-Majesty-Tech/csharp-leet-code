namespace LeetCodeQuestions._1672RichestCustomerWealth;

public class RichestCustomerWealthFirsSolution
{
    public int MaximumWealth(int[][] accounts)
    {
        var has = new Dictionary<int, int>();
        int biggestAccount = 0;
        int innerLength = accounts[0].Length;

        int currentAccount = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < innerLength; j++)
            {
                currentAccount += accounts[i][j];
            }

            if (biggestAccount < currentAccount)
            {
                biggestAccount = currentAccount;
            }

            currentAccount = 0;
        }

        return biggestAccount;
    }
}