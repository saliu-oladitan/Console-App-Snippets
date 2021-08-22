using System;

namespace ConsoleAppSnippetse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the password.");
            var x = Console.ReadLine();
            while (x != "Olamilekan")
            {
                Console.WriteLine("You are not from Nigeria");
                Console.WriteLine("What is your name?");
                x = Console.ReadLine();
            }
            
        }
    }
}


//-----------------INPUT AND OUTPUT------------------------------------
// You can use these lines of code. I commented them out here
//Console.WriteLine("Hello! Multiply two numbers with this App");
//Console.Write("Enter the first number = ");
//var x = Console.ReadLine();
//Console.Write("Enter the second number = ");
//var y = Console.ReadLine();
//var z = Convert.ToInt32(x) * Convert.ToInt32(y);
//Console.WriteLine("The result of multiplying {0} by {1} is {2}", x, y, z);


//-----------------IF STATEMENT------------------------------------
//Console.WriteLine("What is your name?");
//var x = Console.ReadLine();
//if (x == "Olamilekan")
//{
//    Console.WriteLine("You are from Nigeria");
//}
