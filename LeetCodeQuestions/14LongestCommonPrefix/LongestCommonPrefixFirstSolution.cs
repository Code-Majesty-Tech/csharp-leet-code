namespace LeetCodeQuestions._14LongestCommonPrefix;

public class LongestCommonPrefixFirstSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        var prefix = "";

        int mainCounter = 0;
        int minLengthStringPosition = 201;
        int position = 0;
        while (true)
        {
            if (strs[position].Length == mainCounter)
            {
                return prefix;
            }

            var rootPrefix = strs[position][mainCounter];
            for (int i = 0; i < strs.Length; i++)
            {
                if (mainCounter == 0)
                {
                    if (minLengthStringPosition > strs[i].Length - 1)
                    {
                        minLengthStringPosition = strs[i].Length;
                        position = i;
                    }
                }

                if (strs[i].Length == mainCounter || rootPrefix != strs[i][mainCounter])
                {
                    return prefix;
                }
            }

            prefix += rootPrefix;
            mainCounter++;
        }

        return prefix;
    }
}