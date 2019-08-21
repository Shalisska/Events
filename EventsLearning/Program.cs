using System;
using System.Collections.Generic;

namespace EventsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr1 = new List<int> { 3, 5, 10, 2, 19, -50 };
            //var arr2 = new List<int> { 3, 6, 9, 12, 15, 18 };

            //Console.WriteLine(arr1.MyAny(i => i == 19));

            //Console.WriteLine(arr2.MyAll(i => i % 3 == 0 && i < 0));

            //var fileWatcher = new MyFileWatcher();
            //fileWatcher.WatchForFolder();

            var stringFinder = new StringFinderWatcher();
            stringFinder.Start();

            Console.ReadKey();
        }
    }
}
