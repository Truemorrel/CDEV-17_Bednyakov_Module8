using System;
using System.IO;

namespace Task_8_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                var rootDir = drive.RootDirectory;
                var files = rootDir.GetFiles();
                var folders = rootDir.GetDirectories();
                Console.WriteLine($"На диске {drive.Name} расположено:{Environment.NewLine}\t{files.Length} файлов{Environment.NewLine}\t{folders.Length} директорий");
            }
        }
    }
}
