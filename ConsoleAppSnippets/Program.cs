﻿using System;

namespace ConsoleAppSnippetse
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            while (x < 11)
            {
                Console.WriteLine(x);
                x++;
            }

            
            for(int i=10; i>0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}


//1.-----------------INPUT AND OUTPUT------------------------------------
// You can use these lines of code. I commented them out here
//Console.WriteLine("Hello! Multiply two numbers with this App");
//Console.Write("Enter the first number = ");
//var x = Console.ReadLine();
//Console.Write("Enter the second number = ");
//var y = Console.ReadLine();
//var z = Convert.ToInt32(x) * Convert.ToInt32(y);
//Console.WriteLine("The result of multiplying {0} by {1} is {2}", x, y, z);


//2.-----------------CHECK THE SIZE OF A DATA TYPE (RESULT IS GIVEN IN BYTES => 1 Byte = 8 bits)----------

//Console.WriteLine("The size of int is {0}", sizeof(int));



//3.-----------------IF STATEMENT----------------------------------------------------------------
//Console.WriteLine("What is your name?");
//var x = Console.ReadLine();
//if (x == "Olamilekan")
//{
//    Console.WriteLine("You are from Nigeria");
//}



//4.
//----------------WHILE LOOPS-------------------------------------
//var x = "";
//while (x != "123")
//{

//    Console.WriteLine("Please enter the password.");
//    Console.WriteLine("");
//    x = Console.ReadLine();
//    if (x != "123")
//    {
//        Console.WriteLine("Error, You are Not Authorized");
//    }
//}

//Console.WriteLine("Welcome, You are authorized");