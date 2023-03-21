using System;
using System.IO;
using System.Text.Json;
namespace Laba3_2
{
    public class Person
    {
        private string Name;
        private int Age;

        public Person(string value1, int value2)
        {
            Name = value1;
            Age = value2;
        }

        public Person()
        {
            Name = null;
            Age = 0;
        }

        ~Person()
        {
            Console.WriteLine("Об'єкт Person видалено");
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        public void SaveToFile(string filePath)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public static Person LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Person>(json);
        }
    }
}
    
    
