using System;

namespace MyFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            Console.WriteLine("Name");
            name = Console.ReadLine();
            Console.WriteLine("color");
            color = Console.ReadLine();
            KnowMe(name, color);

            
                
        }



        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello {name}, Your favourite color is {color}");

        }
    }
}
