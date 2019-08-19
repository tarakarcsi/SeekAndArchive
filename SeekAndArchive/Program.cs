using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {

        private static List<FileInfo> FoundFiles;
        private static List<FileSystemWatcher> watchers;
        private static List<DirectoryInfo> archiveDirs;

        static void Main(string[] args)
        {
        }


        public static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                if (file.Name == fileName)
                {
                    foundFiles.Add(file);
                }
            }

            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }
        }

        public static void WatcherChanged(object sender, FileSystemEventArgs e)
        {

        }
    }

    
}
