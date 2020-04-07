using System;

public static class ResistorColor
{
    private static readonly string[] ResColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
       int index = Array.IndexOf(ResColors, color);
              
       return index;
    }

    public static string[] Colors()
    {
        return ResColors;
    }
}