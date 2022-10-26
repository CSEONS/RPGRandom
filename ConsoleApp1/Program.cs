using RPGRandom;

class Program
{
    static void Main(string[] args)
    {
        RPGRandomTestClass[] persons = new RPGRandomTestClass[]
        {
                new RPGRandomTestClass(){Name="Jhon", Chance=1},
                new RPGRandomTestClass(){Name="Tim", Chance=1},
                new RPGRandomTestClass(){Name="Bpb", Chance=1},
                new RPGRandomTestClass(){Name="Lucy", Chance=2}
        };

        var logMessage = RPGRandomLog.TestChance(persons, 1000000);
        Console.WriteLine(logMessage);

        Console.WriteLine(logMessage);

        Console.ReadKey();
    }
}



