using System;
using System.Text;
namespace Laba3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person pers1 = new Person("John", 35);
            Console.WriteLine("Екземпляр класу з допомогою конструктора з вхідними параметрами");
            pers1.Display();
            Console.WriteLine("-----------------------");
            Person pers2 = new Person();
            Console.WriteLine("Екземпляр класу з допомогою конструктора за замовчуванням");
            pers2.Display();
            Console.WriteLine("-----------------------");
            pers1.SaveToFile("pers.json");
            Person persjson= Person.LoadFromFile("pers.json");
            persjson.Display();
            Console.WriteLine("-----------------------");
        }
    }
}