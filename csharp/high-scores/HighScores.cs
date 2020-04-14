using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> List;

    public HighScores(List<int> list)
    {
        List = list;
    }

    public List<int> Scores() => List;

    public int Latest() => List.Last();

    public int PersonalBest() => List.Max();

    public List<int> PersonalTopThree() => List.OrderByDescending(i => i).Take(3).ToList(); 
}