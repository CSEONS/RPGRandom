using System.Collections.Generic;
using System;
using RPGRandom;

namespace Testing
{
    internal class Program
    {
        static void Main()
        {
            Item[] items = new Item[]
            {
                new Item(10, "Sword")
            };

            
            Print(items, 1000000);
        }

        private static void Print(Item[] items, int iteration = 100)
        {
            for (int i = 0; i < iteration; i++)
            {
                Item item = Randomf.ChooseOneOfByChance(items);

                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j].Name == item.Name)
                    {
                        item.dropCout++;
                        break;
                    }
                }
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name}: {item.dropCout}");
            };
        }
    }




    class Item : IRandomElement
    {
        public int Chance { get; set; }
        public readonly string Name;
        public int dropCout = 0;

        public Item(int chance, string name)
        {
            this.Chance = chance;
            this.Name = name;
        }
    }
}