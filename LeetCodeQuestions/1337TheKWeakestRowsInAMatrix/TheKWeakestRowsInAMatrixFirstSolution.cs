namespace LeetCodeQuestions._1337TheKWeakestRowsInAMatrix;

public class TheKWeakestRowsInAMatrixFirstSolution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        int[] sum = new int[mat.Length];
        int[] final = new int[k];
        for (int i = 0; i < mat.Length; i++)
        {
            int localsum = 0;

            for (int j = 0; j < (mat[i]).Length; j++)
            {
                localsum += (mat[i][j]);
            }

            sum[i] = localsum;
        }

        for (int i = 0; i < final.Length; i++)
        {
            int min = sum[0];
            int index = 0;
            for (int j = 0; j < sum.Length; j++)
            {
                if (min > sum[j])
                {
                    min = sum[j];
                    index = j;
                }
            }

            final[i] = index;
            sum[index] = int.MaxValue;
        }

        return final;
    }
}