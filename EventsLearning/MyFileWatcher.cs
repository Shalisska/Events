using System;
using System.IO;

namespace EventsLearning
{
    public class MyFileWatcher
    {
        public void WatchForFolder()
        {
            var path = @"D:\projects\learning\Events\FolderForWatcher";
            using(var watcher = new FileSystemWatcher(path))
            {
                watcher.EnableRaisingEvents = true;

                watcher.Created += OnCreate;
                watcher.Changed += OnChange;
                watcher.Renamed += OnRename;
                watcher.Deleted += OnDelete;

                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }

        private void OnDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Delete; file name: {e.Name}");
        }

        private void OnRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Rename; new file name: {e.Name}, old name: {e.OldName}");
        }

        private void OnChange(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Change; file name: {e.Name}");
        }

        private void OnCreate(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Create; file name: {e.Name}");
        }
    }
}
