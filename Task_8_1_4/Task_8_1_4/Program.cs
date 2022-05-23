using System;

namespace Task_8_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PathSet rootDir = new PathSet();
            PathSet nameDir = new PathSet(rootDir, "HomeDir");
            PathSet nesteDir = new PathSet(nameDir, "NestedDir");
            Console.WriteLine(nesteDir.GetFullPath());
        }
    }
    class PathSet
    {
        private PathSet HomePath;
        private string DirName;
        public PathSet()
        { DirName = @"\"; }
        public PathSet(PathSet LocalDir, string NewDir)
        {
            HomePath = LocalDir;
            DirName = NewDir;
        }
        public string GetFullPath()
        { return string.Concat(string.Concat(HomePath?.GetFullPath(), "\\", DirName) ?? "", DirName); }
    }
    public class Drive
    {
        public Drive(string letter, long totalSpace, long freeSpace)
        {
            DriveName = letter;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string DriveName { get; private set; }
        public long TotalSpace { get; private set; }
        public long FreeSpace { get; private set;}
    }
}
