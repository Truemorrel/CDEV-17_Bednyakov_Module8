using System;
using System.IO;

namespace Task_8_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sfile = @"d:\Repos\CDEV-17_Bednyakov_Module8\Task_8_3_2\Program.cs";
            if (File.Exists(sfile))
            {
                using (StreamReader sr = File.OpenText(sfile))
                {
                    //Console.WriteLine(sr.ReadToEnd());
                    string textLine = sr.ReadLine();
                    while (textLine != null)
                    {
                        Console.WriteLine(textLine);
                        textLine = sr.ReadLine();
                    }
                }
                FileInfo fi = new FileInfo(sfile);
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine("//{0}", DateTime.Now);
                };

            }
        }
    }
}
//25.05.2022 17:31:37
