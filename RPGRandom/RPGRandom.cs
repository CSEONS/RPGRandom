using System;
using System.Linq;
using System.Collections.Generic;

namespace RPGRandom
{
    public sealed class Randomf
    {
        public static int Int(int max)
        {
            return new Random().Next(max);
        }

        public static int Int(int max, long seed)
        {
            return new Random((int)seed).Next(max);
        }

        public static int Int(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public static int Int(int min, int max, long seed)
        {
            return new Random((int)seed).Next(min, max);
        }

        public static double Double()
        {
            return new Random().NextDouble();
        }

        public static double Double(long seed)
        {
            return new Random((int)seed).NextDouble();
        }

        public static double Double(double max)
        {
            return (new Random().NextDouble()) * max;
        }

        public static double Double(double max, long seed)
        {
            return ((new Random((int)seed)).NextDouble()) * max;
        }

        public static T ChooseOneOf<T>(T[] items)
        {
            T selectedItem;
            var randomElementIndex = new Random();

            selectedItem = items[randomElementIndex.Next(items.Length)];

            return selectedItem;
        }

        public static T ChooseOneOf<T>(List<T> items)
        {
            T[] listConvertedToArray = items.ToArray();

            return ChooseOneOf(listConvertedToArray);
        }

        public static T ChooseOneOfByChance<T>(T[] items) where T : IRandomElement
        {
            int totalChance = 0;

            foreach (var item in items)
            {
                totalChance += item.Chance;
            }

            int randomNumber = new Random().Next(totalChance);


            int lowwerChance = 0;
            int higherChance = items[0].Chance;


            for (int i = 0; i < items.Length; i++)
            {
                if (randomNumber >= lowwerChance && randomNumber < higherChance)
                {
                    return items[i];
                }
                else
                {
                    lowwerChance = higherChance;
                    higherChance += items[i + 1].Chance; 
                }
            }

            return default(T);
        }

        public static T ChooseOneOfByChance<T>(List<T> items) where T : IRandomElement
        {
            T[] listConvertedToArray = items.ToArray();
            return ChooseOneOfByChance(listConvertedToArray);
        }
    }
}