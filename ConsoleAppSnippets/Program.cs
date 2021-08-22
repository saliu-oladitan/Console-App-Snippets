using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Multiply two numbers with this App");
            Console.Write("Enter the first number = ");
            var x = Console.ReadLine();
            Console.Write("Enter the second number = ");
            var y = Console.ReadLine();
            var z =Convert.ToInt32 (x) * Convert.ToInt32(y);
            Console.WriteLine("The result of multiplying {0} by {1} is {2}",x,y,z);
            
        }
    }

