using System;
using System.Text;
using System.Collections.Generic;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var (alphabetDictionaryCharToInt, alphabetDictionaryIntToChar) = CreateAlphabetDictionaries();

        var sb = new StringBuilder();

        foreach (char c in text)
        {
            if (!char.IsLetter(c)) 
            {  
                sb.Append(c);
                continue; 
            }

            bool isUpper = char.IsUpper(c);
            if (isUpper)
            {
                var shiftedChar = (alphabetDictionaryCharToInt[c] + shiftKey) % 26;
                sb.Append(alphabetDictionaryIntToChar[shiftedChar]);
            }
            else 
            {
                var shiftedChar = (alphabetDictionaryCharToInt[char.ToUpper(c)] + shiftKey) % 26;
                sb.Append(char.ToLower(alphabetDictionaryIntToChar[shiftedChar]));
            }
        }

        return sb.ToString();
    }

    private static (Dictionary<char, int>, Dictionary<int, char>) CreateAlphabetDictionaries()
    {
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var alphabetDictionaryCharToInt = new Dictionary<char, int>();
        var alphabetDictionaryIntToChar= new Dictionary<int, char>();

        foreach (char c in alphabet)
        {
            alphabetDictionaryCharToInt.Add(c, alphabet.IndexOf(c));
            alphabetDictionaryIntToChar.Add(alphabet.IndexOf(c), c);
        }

        return (alphabetDictionaryCharToInt, alphabetDictionaryIntToChar);
    }
}