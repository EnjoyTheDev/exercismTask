using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> results = new List<char>();

        char[] characters = word.ToLower().ToCharArray();

        foreach (char character in characters)
        {
            if (char.IsWhiteSpace(character) || character.Equals('-'))
            {
                continue;
            }

            if (results.Contains(character))
            {
                return false;
            }
            else
            {
                results.Add(character);
            }
        }
        return true;
    }
}