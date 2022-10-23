using System;
using System.Collections.Generic;
using System.Linq;
using RPGRandom;

namespace RPGRandom
{
    public sealed class Randomf
    {
        private static RandInt _randInt = new RandInt();
        private static RandDouble _randDouble = new RandDouble();

        public static int Int(int max)
        {
            return _randInt.Get(max);
        }

        public static int IntRange(int min, int max)
        {
            return _randInt.Range(min, max);
        }

        public static double Double()
        {
            return _randDouble.Get();
        }

        public static double Double(double max)
        {
            return _randDouble.Get() * max;
        }

        public static double DoubleRange(double min, double max)
        {
            return _randDouble.Range(min, max);
        }

        public static T ChooseOneOf<T>(IEnumerable<T> items)
        {
            T selectedItem;

            int randomElementIndex = _randInt.Get(items.Count());

            selectedItem = items.ElementAt(randomElementIndex);

            return default(T);
        }

        public static T ChooseOneOfByChance<T>(IEnumerable<T> items) where T : IRandomElement
        {
            int totalChance = 0;

            foreach (var item in items)
            {
                totalChance += item.Chance;
            }

            int randomNumber = new Random().Next(totalChance);


            int lowwerChance = 0;
            int higherChance = items.First().Chance;


            for (int i = 0; i < items.Count(); i++)
            {
                if (randomNumber >= lowwerChance && randomNumber < higherChance)
                {
                    return items.ElementAt(i);
                }
                else
                {
                    lowwerChance = higherChance;
                    higherChance += items.ElementAt(i + 1).Chance;
                }
            }

            return default(T);
        }
    }
}