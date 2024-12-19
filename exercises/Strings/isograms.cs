using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = word.Where(char.IsLetter).Select(char.ToLower);
        
        return letters.Count() == letters.Distinct().Count();
    }
}
