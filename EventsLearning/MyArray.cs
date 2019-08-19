using System;
using System.Collections.Generic;

namespace EventsLearning
{
    public static class MyArray
    {
        public static bool MyAny(this List<int> items, Func<int, bool> func)
        {
            foreach(var item in items)
                if (func(item))
                    return true;

            return false;
        }

        public static bool MyAll(this List<int> items, Func<int, bool> func)
        {
            foreach (var item in items)
                if (!func(item))
                    return false;

            return true;
        }
    }
}
