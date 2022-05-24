using System;
using System.IO;

namespace Task_8_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo testDir = new DirectoryInfo(@"C:\Users\Desktop\testFolder");
            if (testDir.Exists)
            {
                testDir.MoveTo(@"C:\$Recycle.bin");
            }
        }
    }
}
