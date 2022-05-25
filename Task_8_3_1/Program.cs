using System;
using System.IO;

namespace Task_8_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sfile = @"d:\Repos\CDEV-17_Bednyakov_Module8\Task_8_3_1\Program.cs";
            if(File.Exists(sfile))
            {
                using (StreamReader sr = File.OpenText(sfile))
                {
                    //Console.WriteLine(sr.ReadToEnd());
                    string textLine = sr.ReadLine();
                    while(textLine != null)
                    {
                        Console.WriteLine(textLine);
                        textLine = sr.ReadLine();
                    }
                }
            }
        }
    }
}
