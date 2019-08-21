using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EventsLearning
{
    public class StringFinder
    {
        public delegate void FoundString(string name, int line);

        public event FoundString Found;

        public void Start(string path, string text)
        {
            var files = Directory.GetFiles(path, "*.txt");

            foreach(var file in files)
            {
                var lines = File.ReadAllLines(file);
                foreach(var line in lines)
                {
                    if (line.Contains(text))
                    {
                        Found(file, Array.IndexOf(lines, line));
                    }
                }
            }
        }
    }

    public class StringFinderWatcher
    {
        string _text = "сентябр";

        public void Start()
        {
            var path = @"C:\myProjects\testEvents";

            var finder = new StringFinder();

            finder.Found += Finder_Found;

            finder.Start(path, _text);
        }

        private void Finder_Found(string name, int line)
        {
            Console.WriteLine($"Find \"{_text}\" in file {name} line {line}");
        }
    }
}
