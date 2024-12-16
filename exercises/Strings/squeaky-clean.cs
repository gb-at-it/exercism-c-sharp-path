using System;
using System.Text;

// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace?view=net-9.0
public static class Identifier
{
    private static readonly char _greekAlphaWithTonos = '\u03AC';
    private static readonly char _greekOmegaWithTonos = '\u03CE';
    private static bool IsGreekLowercase(char c) => (_greekAlphaWithTonos <= c && c <= _greekOmegaWithTonos);

    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        var isAfterDash = false;

        foreach (char c in identifier)
        {
            if (!char.IsLetter(c))
            {
                if (char.IsWhiteSpace(c))
                    sb.Append('_');
                else if (char.IsControl(c))
                    sb.Append("CTRL");
                else if (c == '-')
                    isAfterDash = true;
            }
            else if (IsGreekLowercase(c))
                continue;
            else if (isAfterDash)
            {
                sb.Append(char.ToUpper(c));
                isAfterDash = false;
            }
            else
                sb.Append(c);
        }

        return sb.ToString();
    }

    public static string Clean0(string identifier)
    {
        var sb = new StringBuilder(identifier.Length);
        foreach (char c in identifier)
        {
            if (Char.IsWhiteSpace(c))
                sb.Append('_');
            else
                sb.Append(c);
        }
        return sb.ToString();
    }

    public static string Clean1(string identifier)
    {
        var sb = new StringBuilder(identifier, identifier.Length);
        sb.Replace(' ', '_');
        return sb.ToString();
    }

    public static string Clean2(string identifier)
        => new(identifier.Select(c => c == ' ' ? '_' : c).ToArray());
}
