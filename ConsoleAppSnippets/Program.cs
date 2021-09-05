using System;

namespace ConsoleAppSnippetse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine(); 
            
            while (name == "")
            {
                Console.WriteLine("You did not type anything.");
                Console.WriteLine("What is your name?");
               name = Console.ReadLine();
            }


            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();        
            
            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

        }
    }
}

// Use these lines of code. I commented them out here in order to store them.

//8.--------------FOREACH LOOP------------------
//var UseArray = new int[] { 1, 2, 3 };
//foreach (var item in UseArray)
//{
//    Console.WriteLine(item);
//}


//7. ---------------AN ARRAY--------------

//var FirstArray = new int[5];
//FirstArray[0] = 1;
//FirstArray[1] = 2;
//FirstArray[2] = 3;
//FirstArray[3] = 4;
//FirstArray[4] = 5;

//Console.WriteLine(FirstArray[0]);


//var SecondArray = new int[5] { 2, 4, 6, 8, 10 };
//Console.WriteLine(SecondArray[0]);


//var ThirdArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };  //The array will accept as much values as possible when you remove the 5 from int[5]
//Console.WriteLine(ThirdArray[4]);




//6. -----------------COUNT FROM 1 TO 10 AND BACK TO 1, AND REPEAT 5 TIMES-----------
//for (int y = 1; y <= 5; y++)
//{
//    for (int x = 1; x <= 10; x++)
//    {
//        Console.WriteLine(x);
//    }

//    for (int x = 10; x >= 1; x--)
//    {
//        Console.WriteLine(x);
//    }
//}



//5. -----------------COUNT FROM 1 TO 10 AND BACK TO 1-------------------------------
//var x = 1;
//while (x <= 10)
//{
//    Console.WriteLine(x);
//    x++;
//}


//for (int i = 9; i > 0; i--)
//{
//    Console.WriteLine(i);
//}



//4.----------------WHILE LOOPS-------------------------------------
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



//3.-----------------IF STATEMENT----------------------------------------------------------------
//Console.WriteLine("What is your name?");
//var x = Console.ReadLine();
//if (x == "Olamilekan")
//{
//    Console.WriteLine("You are from Nigeria");
//}


//for (int i = 9; i > 0; i--)
//{
//    Console.WriteLine(i);
//}