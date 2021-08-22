using System;

namespace ConsoleAppSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello People!");
            var x = Console.ReadLine();
            var y = Console.ReadLine();
            var z =Convert.ToInt32 (x) + Convert.ToInt32(y);
            Console.WriteLine("The result is {0}",z);
            
        }
    }
}
