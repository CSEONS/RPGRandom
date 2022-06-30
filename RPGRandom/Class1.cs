using System;
using System.Collections.Generic;

namespace RPGRandom
{
    class Random
    {
        public static int ChooseOneOf<T>(T[] items)
        {
            return 0;
        }

        public static int ChooseOneOf<T>(List<T> items)
        {
            T[] listConvertedToListArray = items.ToArray();
            return ChooseOneOf<T>(listConvertedToListArray);
        }
    }
}
