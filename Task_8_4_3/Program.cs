using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Task_8_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personFile = @"C:\Users\Sergey\Desktop\contactSerialize.dat";
            var person = new Contact("Piter", +123456789, "piter@person.com");
            Console.WriteLine("Создан контакт: {0}", person.Name);
            BinaryFormatter formater = new BinaryFormatter();
            using FileStream fs = new FileStream(personFile, FileMode.OpenOrCreate);
            {
                formater.Serialize(fs, person);
                fs.Flush();
                fs.Close();
            }
        }
    }
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
