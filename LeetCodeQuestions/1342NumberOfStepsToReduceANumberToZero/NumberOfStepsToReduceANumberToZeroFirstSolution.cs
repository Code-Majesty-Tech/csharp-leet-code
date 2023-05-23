namespace LeetCodeQuestions._1342NumberOfStepsToReduceANumberToZero;

public class NumberOfStepsToReduceANumberToZeroFirstSolution
{
    public int NumberOfSteps(int num)
    {
        if (num == 0)
        {
            return 0;
        }

        int numberOfSteps = 1;
        while (true)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
            }
            else
            {
                num = num - 1;
            }

            if (num == 0)
            {
                break;
            }

            numberOfSteps++;
        }

        return numberOfSteps;
    }
}