using System;

internal class RandInt : IRandomClass<int>
{
    private Random _random = new Random();

    public int Get()
    {
        return _random.Next();
    }

    public int Get(int max)
    {
        return _random.Next(max);
    }

    public int Range(int min, int max)
    {
        return _random.Next(min, max);
    }

    public void SetSeed(int seed)
    {
        _random = new Random(seed);
    }
}
