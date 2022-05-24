using System;
using System.IO;

namespace Task_8_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DirectoryInfo testDir = new DirectoryInfo(@"C:\Users\Sergey\Desktop\testFolder");
            if (testDir.Exists)
            {
                    testDir.MoveTo(@"C:\$Recycle.bin\testFolder");
                 //   testDir.MoveTo(@"C:\Users\Sergey\.Trash\testFolder");
                }
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }
        }
    }
}
