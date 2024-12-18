using System;
using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = string.Concat(statement.Where(c => !char.IsWhiteSpace(c)));

        if (string.IsNullOrEmpty(statement))
            return "Fine. Be that way!";

        var (isQuestion, isCapitalized) = (statement.EndsWith('?'), statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper));

        return (isQuestion, isCapitalized) switch
        {
            (true, true) => "Calm down, I know what I'm doing!",
            (true, _) => "Sure.",
            (_, true) => "Whoa, chill out!",
            _ => "Whatever."
        };
    }
}