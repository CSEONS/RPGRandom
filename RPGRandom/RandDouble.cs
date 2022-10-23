using System;
using System.Collections.Generic;
using System.Text;

namespace RPGRandom
{
    internal class RandDouble : IRandomClass<double>
    {
        private Random _random = new Random();

        /// <summary>
        /// Returns a random number between 0 and 1.
        /// </summary>
        /// <returns></returns>
        public double Get()
        {
            return _random.NextDouble();
        }

        public double Get(double max)
        {
            return Math.Round(_random.NextDouble() * max);
        }

        public double Range(double min, double max)
        {
            return Math.Round(_random.NextDouble() * (max - min) + min);
        }

        public void SetSeed(int seed)
        {
            _random = new Random(seed);
        }
    }
}
