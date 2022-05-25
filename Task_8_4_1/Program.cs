using System;
using System.IO;

namespace Task_8_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fn = @"C:\Users\Sergey\Desktop\BinaryFile.bin";
            var fi = new FileInfo(fn);
            ;
            if (File.Exists(fn))
            {
                using (BinaryReader sf = new BinaryReader(File.Open(fn, FileMode.Open)))
                {
                    Console.WriteLine($"{sf.ReadString()}");

                }
            }
        }
    }
}
