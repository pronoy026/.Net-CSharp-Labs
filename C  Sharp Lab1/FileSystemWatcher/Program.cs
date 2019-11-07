using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherLab
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"e:");

            watcher.Created += WatcherHandler;
            watcher.Deleted += WatcherHandler;
            watcher.Renamed += WatcherHandler;

            //enable raising events
            watcher.EnableRaisingEvents = true;

            Console.ReadLine();
        }

        private static void WatcherHandler(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(sender.GetType());
            Console.WriteLine($"Directory Changed, Change Type : {e.ChangeType}, Path : {e.FullPath}");
        }
    }
}
