using System;
using System.Collections.Generic;

public class SpaceAge
{
    public readonly int Seconds;
    private const int EarthPeriod = 31557600;

    Dictionary<string, double> orbitalPeriodOfPlanet = new Dictionary<string, double>()
    {
       { "Earth", 31557600},
       { "Mercury", EarthPeriod * 0.2408467 },
       { "Venus", EarthPeriod * 0.61519726 },
       { "Mars", EarthPeriod * 1.8808158 },
       { "Jupiter", EarthPeriod * 11.862615 },
       { "Saturn", EarthPeriod * 29.447498 },
       { "Uranus", EarthPeriod * 84.016846 },
       { "Neptune", EarthPeriod * 164.79132 },
    };

    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth() => Math.Round(Seconds / orbitalPeriodOfPlanet["Earth"], 2);

    public double OnMercury() => Math.Round(Seconds / orbitalPeriodOfPlanet["Mercury"], 2);

    public double OnVenus() => Math.Round(Seconds / orbitalPeriodOfPlanet["Venus"], 2);

    public double OnMars() => Math.Round(Seconds / orbitalPeriodOfPlanet["Mars"], 2);

    public double OnJupiter() => Math.Round(Seconds / orbitalPeriodOfPlanet["Jupiter"], 2);

    public double OnSaturn() => Math.Round(Seconds / orbitalPeriodOfPlanet["Saturn"], 2);

    public double OnUranus() => Math.Round(Seconds / orbitalPeriodOfPlanet["Uranus"], 2);

    public double OnNeptune() => Math.Round(Seconds / orbitalPeriodOfPlanet["Neptune"], 2);
}