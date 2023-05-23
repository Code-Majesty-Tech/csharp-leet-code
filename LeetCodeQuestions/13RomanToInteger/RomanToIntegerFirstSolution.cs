namespace LeetCodeQuestions._13RomanToInteger;

public class RomanToIntegerFirstSolution
{
    public int RomanToInt(string s)
    {
        var intNumber = 0;
        var dictionary = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        s = s.Replace("IV", "IIII");
        s = s.Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX");
        s = s.Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC");
        s = s.Replace("CM", "DCCCC");

        var charArr = s.ToCharArray();

        for (int i = 0; i < charArr.Length; i++)
        {
            intNumber += dictionary[charArr[i]];
        }

        return intNumber;
    }
    
    
}