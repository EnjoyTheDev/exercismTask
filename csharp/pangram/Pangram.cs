using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool[] targetMark = new bool[26];

        var indexTargetMark = 0;

        input = input.ToLower();

        for (int i = 0; i < input.Length; i++)
        {
            if ('a' <= input[i] && input[i] <= 'z')
            {
                indexTargetMark = input[i] - 'a';
            }
            targetMark[indexTargetMark] = true;
        }

        for (int i = 0; i <= 25; i++)
        {
            if (targetMark[i] == false)
            {
                return false;
            }
        }

        return true;

        //return input.ToLower().Where(input => char.IsLetter(input)).GroupBy(input => input).Count() == 26; // using Linq
    }
}