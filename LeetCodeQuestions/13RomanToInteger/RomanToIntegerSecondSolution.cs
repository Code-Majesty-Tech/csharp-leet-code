namespace LeetCodeQuestions._13RomanToInteger;

public class RomanToIntegerSecondSolution
{
    public int RomanToInt(string s)
    {
        var intNumber = 0;
        var charArray = s.ToCharArray();

        if (charArray.Length == 1)
        {
            return GetValue(charArray[0]);
        }

        for (int i = 1; i < charArray.Length + 1; i++)
        {
            char? @char = i < charArray.Length ? charArray[i] : null;
            char previousChar = charArray[i - 1];

            intNumber += Handle(@char, previousChar, ref i);
        }

        return intNumber;
    }

    private int Handle(char? @char, char previousChar, ref int counter)
    {
        if (previousChar == 'I')
        {
            if (@char != 'V' && @char != 'X')
            {
                return GetValue(previousChar);
            }

            if (@char is 'V' or 'X')
            {
                counter++;
                return GetValue($"{previousChar}{@char}");
            }
        }
        else if (previousChar == 'X')
        {
            if (@char != 'L' && @char != 'C')
            {
                return GetValue(previousChar);
            }

            if (@char is 'L' or 'C')
            {
                counter++;
                return GetValue($"{previousChar}{@char}");
            }
        }
        else if (previousChar == 'C')
        {
            if (@char != 'D' && @char != 'M')
            {
                return GetValue(previousChar);
            }

            if (@char is 'D' or 'M')
            {
                counter++;
                return GetValue($"{previousChar}{@char}");
            }
        }
        else if (previousChar == 'M')
        {
            return GetValue(previousChar);
        }
        else if (previousChar == 'L')
        {
            return GetValue(previousChar);
        }
        else if (previousChar == 'D')
        {
            return GetValue(previousChar);
        }
        else if (previousChar == 'V')
        {
            return GetValue(previousChar);
        }

        return 0;
    }

    private bool IsTogether(string s)
    {
        return s switch
        {
            "IV" => true,
            "IX" => true,
            "XL" => true,
            "XC" => true,
            "CD" => true,
            "CM" => true,
            _ => false
        };
    }

    private int GetValue(char roman)
    {
        return roman switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }

    private int GetValue(string roman)
    {
        return roman switch
        {
            "IV" => 4,
            "IX" => 9,
            "XL" => 40,
            "XC" => 90,
            "CD" => 400,
            "CM" => 900,
            _ => 0
        };
    }
}