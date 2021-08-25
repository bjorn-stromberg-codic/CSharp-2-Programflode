using System;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
