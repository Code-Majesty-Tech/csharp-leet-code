namespace LeetCodeQuestions._383RansomNote;

public class RansomNoteFirstSolution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteCharArray = ransomNote.ToCharArray();
        var magazineCharArray = magazine.ToCharArray();
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < ransomNote.Length; i++)
        {
            var targetCharacter = ransomNoteCharArray[i];

            int? index = null;
            for (int j = 0; j < magazineCharArray.Length; j++)
            {
                if (!dict.ContainsKey(j))
                {
                    var selectedMagazineChar = magazineCharArray[j];
                    if (targetCharacter == selectedMagazineChar)
                    {
                        index = j;
                        break;
                    }
                }
            }

            if (index == null)
            {
                return false;
            }

            dict.Add((int)index, 0);
        }

        return true;
    }
}