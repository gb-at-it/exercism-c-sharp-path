using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var helperPhrase = string.Concat(phrase.ToUpper().Replace('-', ' ').Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)));
        return string.Concat(helperPhrase.Split().Select(s => s.FirstOrDefault()).Where(char.IsLetter));          
    }

    public static string Abbreviate2(string phrase)
    {
        var helperPhrase = Regex.Replace(phrase.ToUpper().Replace('-', ' '), @"[^A-Z\s]", string.Empty);
        return string.Concat(helperPhrase.Split().Select(s => s.FirstOrDefault()).Where(char.IsLetter));
    }
}
