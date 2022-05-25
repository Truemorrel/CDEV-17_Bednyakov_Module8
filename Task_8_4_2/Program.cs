using System;
using System.IO;

namespace Task_8_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fn = @"C:\Users\Sergey\Desktop\BinaryFile.bin";
            if (File.Exists(fn))
            {
                using (BinaryReader sf = new BinaryReader(File.Open(fn, FileMode.Open)))
                {
                    Console.WriteLine($"{sf.ReadString()}");

                }
                using (BinaryWriter sf = new BinaryWriter(File.Open(fn, FileMode.Append)))
                {
                    string day = string.Concat((((DateTime.Today).Day < 10) ? "0" : ""), (DateTime.Today).Day);
                    string month = string.Concat((((DateTime.Today).Month < 10) ? "0" : ""), (DateTime.Today).Month);
                    string hour = string.Concat((((DateTime.Now).Hour < 10) ? "0" : ""), (DateTime.Now).Hour);
                    string minute = string.Concat((((DateTime.Now).Minute < 10) ? "0" : ""), (DateTime.Now).Minute);
                    sf.Write($"{Environment.NewLine}Файл изменен {day}.{month} {hour}:{minute} на компьютере Windows 11");
                }
            }
        }
    }
}
