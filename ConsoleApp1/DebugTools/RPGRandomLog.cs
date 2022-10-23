using RPGRandom;


internal static class RPGRandomLog
{
    public static string TestChance<T>(IEnumerable<T> items, int iterationCount) where T : RPGRandomTestClass
    {
        string logMessage = string.Empty;

        for (int i = 0; i < iterationCount; i++)
        {
            Randomf.ChooseOneOfByChance(items).Iteration++;
        }

        logMessage += "Name | Chance | Iteration\n";

        foreach (var item in items)
        {
            logMessage += $"{item.Name} | {item.Chance} || {item.Iteration}\n";
        }

        return logMessage;
    }
}

public class RPGRandomTestClass : IRandomElement
{
    public string? Name { get; set; }
    public int Chance { get; set; }
    public int Iteration { get; set; }

    public override string ToString()
    {
        string total;

        total = $"{Name} : {Chance} : {Iteration}";

        return total;
    }
}

