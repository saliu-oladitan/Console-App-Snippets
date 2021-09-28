using System;
using System.Collections.Generic;

namespace ConsoleAppSnippets
{
    
      enum SchoolType  // enum comes with index by default which starts at 0
    {
        Light = 0,
        Shine = 1,
        Top = 2,
    }
    class Program
    {
        static List<Students> students = new List<Students>();   // We moved it here so that we will be able to access it anywhere in the class and it is no more a local list. We will specify the type explicitly (not var anymore) and add static since we need to access it in static functions
        static void Main(string[] args)
        {
            Import();

            var YesNo = true;

            while (YesNo)
            {
                var newStudent = new Students();

                try
                {
                    newStudent.Name = Util.Console.Ask("Name:");
                    newStudent.Grade = Util.Console.AskInt("Age:");
                    newStudent.School = (SchoolType)Util.Console.AskInt("Note: \n Light: 0 \n Shine: 1 \n Top: 2 \n School Id:"); //We will use cast and specify the type we want to cast to. THis is to convert the input value into the enum type.
                    newStudent.Phone = Util.Console.AskInt("Grade:");
                }

                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }

                catch (Exception)
                {
                    Console.WriteLine("Error.");
                }



                //var TryNow = int.TryParse(Util.Console.Ask("Age:"), out newStudent.Grade);
                //while (!TryNow)
                //{
                //    Console.WriteLine("Wrong letter input");
                //    TryNow = int.TryParse(Util.Console.Ask("Age:"), out newStudent.Grade);
                //}

                students.Add(newStudent);
                Students.Count++;
                Console.WriteLine(Students.Count);


                Console.WriteLine("Add another student? y/n");

                if (Console.ReadLine() != "y")
                    YesNo = false;

            }

            ShowGrade("Tom");

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0} \n Grade: {1} \n", student.Name, student.Grade);
            }

            Exports();

        }

        static void Import()
        {
            var newImputedStudent = new Students("Saliu", 34, "birth", 23, 443545);

            Console.WriteLine(newImputedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case SchoolType.Light:
                        Console.WriteLine("Exporting to Light");
                        break;

                    case SchoolType.Shine:
                        Console.WriteLine("Exporting to Shine");
                        break;

                    case SchoolType.Top:
                        Console.WriteLine("Exporting to Top");
                        break;

                }
            }
        }

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name); //Using the lambda expression
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }

    class Member
    {
        public string Name { get; set; }  //Demonstration of an implemented property. You can chnage others to it.
        public string Birthday;
        public int Age;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }

    }
    class Students : Member
    {
        static public int Count = 0;
        public int Grade;
        public SchoolType School;


        public Students()     // This one is called when the object of that class is initialised.
        {
            Console.WriteLine("This is the constructor");
        }

        public Students(string name, int grade, string birthday, int age, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Age = age;
            Phone = phone;
        }


    }

    class Teacher : Member
    {
        private string Subject;
    }

}

// Use these lines of code. I commented them out here in order to store them.
//21. -------out and ref keywords----------------------------
//static void Main(string[] args)
//{
//    var x = 2;

//    Console.WriteLine(x);

//    //Five(out x);
//    Double(ref x);

//    Console.WriteLine(x);

//}

//static void Five(out int a)
//{
//    a = 5;

//    Console.WriteLine(a);
//}

//static void Double(ref int a)
//{
//    a = a * 2;

//    Console.WriteLine(a);
//}


//20. -------Out Parameter----------------------------
//static void Main(string[] args)
//{
//    var x = 2;

//    Console.WriteLine(x);

//    Five(out x);

//    Console.WriteLine(x);

//}

//static void Five(out int x)
//{
//    x = 5;

//    Console.WriteLine(x);
//}
//19. -------Enum----------------------------
//enum SchoolType  // enum comes with index by default which starts at 0
//{
//    Light = 0,
//    Shine = 1,
//    Top = 2,
//}
//class Program
//{
//    static List<Students> students = new List<Students>();   // We moved it here so that we will be able to access it anywhere in the class and it is no more a local list. We will specify the type explicitly (not var anymore) and add static since we need to access it in static functions
//    static void Main(string[] args)
//    {
//        Import();

//        var YesNo = true;

//        while (YesNo)
//        {
//            var newStudent = new Students();

//            try
//            {
//                newStudent.Name = Util.Console.Ask("Name:");
//                newStudent.Grade = Util.Console.AskInt("Age:");
//                newStudent.School = (SchoolType) Util.Console.AskInt("Note: \n Light: 0 \n Shine: 1 \n Top: 2 \n School Id:"); //We will use cast and specify the type we want to cast to. THis is to convert the input value into the enum type.
//                newStudent.Phone = Util.Console.AskInt("Grade:");
//            }

//            catch (FormatException msg)
//            {
//                Console.WriteLine(msg.Message);
//            }

//            catch (Exception)
//            {
//                Console.WriteLine("Error.");
//            }



//            //var TryNow = int.TryParse(Util.Console.Ask("Age:"), out newStudent.Grade);
//            //while (!TryNow)
//            //{
//            //    Console.WriteLine("Wrong letter input");
//            //    TryNow = int.TryParse(Util.Console.Ask("Age:"), out newStudent.Grade);
//            //}

//            students.Add(newStudent);
//            Students.Count++;
//            Console.WriteLine(Students.Count);


//            Console.WriteLine("Add another student? y/n");

//            if (Console.ReadLine() != "y")
//                YesNo = false;

//        }

//        foreach (var student in students)
//        {
//            Console.WriteLine("Name: {0} \n Grade: {1} \n",student.Name, student.Grade);
//        }

//        Exports();

//    }

//    static void Import()
//    {
//        var newImputedStudent = new Students("Saliu", 34, "birth", 23, 443545);

//        Console.WriteLine(newImputedStudent.Name);
//    }

//    static void Exports()
//    {
//        foreach (var student in students)
//        {
//            switch(student.School)
//            {
//                case SchoolType.Light:
//                  Console.WriteLine("Expoting to Light");
//                break;

//                case SchoolType.Shine:
//                    Console.WriteLine("Exporting to Shine");
//                    break;

//                case SchoolType.Top:
//                    Console.WriteLine("Exporting to Top");
//                    break;

//            }    
//        }
//    }
//}

//class Member
//{
//    public string Name;
//    public string Birthday;
//    public int Age;
//    protected int phone;

//    public int Phone
//    {
//        set { phone = value; }
//    }

//}
//class Students : Member
//{
//    static public int Count = 0;

//    public int Grade;
//    public SchoolType School;


//    public Students()     // This one is called when the object of that class is initialised.
//    {
//        Console.WriteLine("This is the constructor");
//    }

//    public Students(string name, int grade, string birthday, int age, int phone)
//    {
//        Name = name;
//        Grade = grade;
//        Birthday = birthday;
//        Age = age;
//        Phone = phone;
//    }


//}

//class Teacher : Member
//{
//    private string Subject;
//}
//18. -------Error Handling------------------
//A. INSIDE Console.cs
//static public int AskInt(string question)
//{


//    try
//    {
//        System.Console.Write(question);
//        return int.Parse(System.Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        throw new FormatException("Input was not a number");
//    }
//}

//B. INSIDE program.cs
//var newStudent = new Students();

//try
//{
//    newStudent.Name = Util.Console.Ask("Name:");
//    newStudent.Grade = Util.Console.AskInt("Age:");
//    newStudent.School = Util.Console.AskInt("Note: \n Light: 0 \n Shine: 1 \n Top: 2 \n School Id:");
//    newStudent.Phone = Util.Console.AskInt("Grade:");
//}

//catch (FormatException msg)
//{
//    Console.WriteLine(msg.Message);
//}

//catch (Exception)
//{
//    Console.WriteLine("Error.");
//}

//17. -------Inheritance------------------
//class Program
//{
//    static void Main(string[] args)
//    {
//        Import();
//        var students = new List<Students>();
//        var YesNo = true;

//        while (YesNo)
//        {
//            var newStudent = new Students();


//            newStudent.Name = Util.Console.Ask("Name:");
//            newStudent.Grade = int.Parse(Util.Console.Ask("Age:"));
//            newStudent.Phone = int.Parse(Util.Console.Ask("Grade:"));


//            students.Add(newStudent);
//            Students.Count++;
//            Console.WriteLine(Students.Count);


//            Console.WriteLine("Add another student? y/n");

//            if (Console.ReadLine() != "y")
//                YesNo = false;

//        }

//        foreach (var student in students)
//        {
//            Console.WriteLine("Name: {0} \n Grade: {1} \n\n", student.Name, student.Grade);
//        }

//    }

//    static void Import()
//    {
//        var newImputedStudent = new Students("Saliu", 34, "birth", 23, 443545);

//        Console.WriteLine(newImputedStudent.Name);
//    }
//}

//class Member
//{
//    public string Name;
//    public string Birthday;
//    public int Age;
//    protected int phone;

//    public int Phone
//    {
//        set { phone = value; }
//    }

//}
//class Students : Member
//{
//    static public int Count = 0;

//    public int Grade;


//    public Students()     // This one is called when the object of that class is initialised.
//    {
//        Console.WriteLine("This is the constructor");
//    }

//    public Students(string name, int grade, string birthday, int age, int phone)
//    {
//        Name = name;
//        Grade = grade;
//        Birthday = birthday;
//        Age = age;
//        Phone = phone;
//    }


//}

//class Teacher : Member
//{
//    private string Subject;
//}

//16. --------Using constructor---------------
//class Program
//{
//    static void Main(string[] args)
//    {
//        Import();
//        var students = new List<Students>();
//        var YesNo = true;

//        while (YesNo)
//        {
//            var newStudent = new Students();


//            newStudent.Name = Util.Console.Ask("Name:");
//            newStudent.Grade = int.Parse(Util.Console.Ask("Age:"));
//            newStudent.Phone = int.Parse(Util.Console.Ask("Grade:"));


//            students.Add(newStudent);
//            Students.Count++;
//            Console.WriteLine(Students.Count);


//            Console.WriteLine("Add another student? y/n");

//            if (Console.ReadLine() != "y")
//                YesNo = false;

//        }

//        foreach (var student in students)
//        {
//            Console.WriteLine("Name: {0} \n Grade: {1} \n\n", student.Name, student.Grade);
//        }

//    }

//    static void Import()
//    {
//        var newImputedStudent = new Students("Saliu", 34, "birth", 23, 443545);

//        Console.WriteLine(newImputedStudent.Name);
//    }
//}

//class Students
//{
//    static public int Count = 0;
//    public string Name;
//    public int Grade;
//    public string Birthday;
//    public int Age;
//    private int phone;

//    public Students()     // This one is called when the object of that class is initialised.
//    {
//        Console.WriteLine("This is the constructor");
//    }

//    public Students(string name, int grade, string birthday, int age, int phone)
//    {
//        Name = name;
//        Grade = grade;
//        Birthday = birthday;
//        Age = age;
//        Phone = phone;
//    }




//    public int Phone
//    {
//        set { phone = value; /*Console.WriteLine(phone);*/ }
//    }

//    //public void setPhone(int number)
//    //{
//    //    phone = number;
//    //}
//}

//15. ----- (Working with namespaces) Create another class with the name Util and use it in the initial class program..........

//------This is The new class code--------------
//namespace Util
//{
//    class Console
//    {
//        static public string Ask(string question)
//        {
//            System.Console.Write(question);
//            return System.Console.ReadLine();
//        }
//    }
//}

//-----This is the intial class program code-----
//namespace ConsoleAppSnippets
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var students = new List<Students>();
//            var YesNo = true;

//            while (YesNo)
//            {
//                var newStudent = new Students();


//                newStudent.Name = Util.Console.Ask("Name:");
//                newStudent.Grade = int.Parse(Util.Console.Ask("Age:"));
//                newStudent.Phone = int.Parse(Util.Console.Ask("Grade:"));


//                students.Add(newStudent);
//                Students.Count++;
//                Console.WriteLine(Students.Count);


//                Console.WriteLine("Add another student? y/n");

//                if (Console.ReadLine() != "y")
//                    YesNo = false;

//            }

//            foreach (var student in students)
//            {
//                Console.WriteLine("Name: {0} \n Grade: {1} \n\n", student.Name, student.Grade);
//            }

//        }
//    }

//    class Students
//    {
//        static public int Count = 0;
//        public string Name;
//        public int Grade;
//        public string Birthday;
//        public int Age;
//        private int phone;

//        public int Phone
//        {
//            set { phone = value; }
//        }

//    }
//}


//14. --------Working with static members-----------


//14. --------Dealing with properties-----------
//class Program
//{
//    static void Main(string[] args)
//    {
//        var students = new List<Students>();
//        var YesNo = true;
//        int newCount = 0;
//        while (YesNo)
//        {
//            var newStudent = new Students();
//            Console.Write("Name:");
//            newStudent.Name = Console.ReadLine();

//            Console.Write("Grade:");
//            newStudent.Grade = int.Parse(Console.ReadLine());

//            Console.Write("Phone:");
//            newStudent.PhoneProp = int.Parse(Console.ReadLine());
//            //newStudent.setPhone(int.Parse(Console.ReadLine()));

//            newCount++;
//            newStudent.Counting = newCount;

//            students.Add(newStudent);
//            Console.WriteLine("Count = {0}", newCount);


//            Console.WriteLine("Add another student? y/n");

//            if (Console.ReadLine() != "y")
//                YesNo = false;

//        }

//        foreach (var student in students)
//        {
//            Console.WriteLine("Count: {0} \n Name: {1} \n Grade: {2} \n\n", student.Counting, student.Name, student.Grade);
//        }

//    }
//}

//class Students
//{
//    public int Counting = 0;
//    public string Name;
//    public int Grade;
//    public string Birthday;
//    public int Age;
//    private int phone;

//    public int PhoneProp
//    {
//        set { phone = value; /*Console.WriteLine(phone);*/ }
//    }

//    //public void setPhone(int number)
//    //{
//    //    phone = number;
//    //}
//}



//13. --------Implementing OOP. Creating and using objects-----------
//    static void Main(string[] args)
//    {
//        var students = new List<Students>();
//        var YesNo = true;

//        while (YesNo)
//        {
//            var newStudent = new Students();
//            Console.Write("Name:");
//            newStudent.Name = Console.ReadLine();

//            Console.Write("Grade:");
//            newStudent.Grade = int.Parse(Console.ReadLine());

//            students.Add(newStudent);

//            Console.WriteLine("Add another student? y/n");

//            if (Console.ReadLine() != "y")
//                YesNo = false;               

//        }

//        foreach (var student in students)
//        {
//            Console.WriteLine("Name: {0} \n Grade: {1} \n\n", student.Name, student.Grade);
//        }

//    }
//}

//class Students
//{
//    public string Name;
//    public int Grade;
//    public string Birthday;
//    public int Age;
//    public int Phone;
//}



//12. ------Implementing Collections------------
//var StudentNames = new List<string>();
//var StudentScores = new List<int>();

//var YesNo = true;

//while (YesNo)
//{
//    Console.WriteLine("Type the student's name:");
//    StudentNames.Add(Console.ReadLine());

//    Console.WriteLine("Type the student's score:");
//    StudentScores.Add(int.Parse(Console.ReadLine()));

//    Console.WriteLine("Do you want to input another student's details y or n?");
//    var CheckYesNo = Console.ReadLine();

//    if (CheckYesNo != "y")
//    {
//        YesNo = false;
//    }

//}
//for(var i =0; i<StudentNames.Count; i++)
//{
//    Console.WriteLine(i+1 + "." + "{0} scores {1}",StudentNames[i],StudentScores[i]);
//}


//11.-----------SWITCH STATEMENT---------------
//  Console.WriteLine("Enter years of experience.");
//var Experience = Console.ReadLine();

//switch (int.Parse(Experience))
//{
//    case 0:
//        Console.WriteLine("Inexperinced");
//        break;

//    case 1:
//        Console.WriteLine("Junior");
//        break;

//    case 2:
//        Console.WriteLine("Intermediate");
//        break;

//    case 3:
//        Console.WriteLine("Advanced");
//        break;

//    default:
//        Console.WriteLine("Senior");
//        break;
//}


//10.------A FUNCTION THAT TAKES IN AND RETURNS A VALUE------------
//static void Main(string[] args)
//{
//    Console.WriteLine("What is your name?");
//    var name = ReturnValue();

//    Console.WriteLine("What is your age?");
//    var age = ReturnValue();

//    Console.WriteLine("What month were you born in?");
//    var month = ReturnValue();

//    Console.WriteLine("Your name is: {0} \n", name);
//    Console.WriteLine("Your age is: {0} \n", age);
//    Console.WriteLine("Your birth month is: {0}", month);

//}

//static string ReturnValue()
//{
//    var Question = Console.ReadLine();

//    while (Question == "")
//    {
//        Console.WriteLine("You inputed empty value.\nPlease, input another value.");
//        Question = Console.ReadLine();
//    }
//    return (Question);
//}

//9.--------------A FUNCTION THAT RETURNS A VALUE------------------
//Console.WriteLine("What is your name?");
//var name = Console.ReadLine();
//while (name == "")
//{
//    name = CheckEmpty();
//}


//Console.WriteLine("What is your age?");
//var age = Console.ReadLine();
//while (age == "")
//{
//    age = CheckEmpty();
//}

//Console.WriteLine("What month were you born in?");
//var month = Console.ReadLine();
//while (month == "")
//{
//    month = CheckEmpty();
//}

//Console.WriteLine("Your name is: {0}", name);
//Console.WriteLine("Your age is: {0}", age);
//Console.WriteLine("Your birth month is: {0}", month);


//        }

//            static string CheckEmpty()
//{
//    Console.WriteLine("You did not type anything.");
//    Console.WriteLine("Please answer the ques.");
//    string ValueToReturn = Console.ReadLine();
//    return (ValueToReturn);
//    //or return Console.ReadLine();
//}





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



//2.-----------------CHECK THE SIZE OF A DATA TYPE (RESULT IS GIVEN IN BYTES => 1 Byte = 8 bits)----------

//Console.WriteLine("The size of int is {0}", sizeof(int));



//1.-----------------INPUT AND OUTPUT------------------------------------

//Console.WriteLine("Hello! Multiply two numbers with this App");
//Console.Write("Enter the first number = ");
//var x = Console.ReadLine();
//Console.Write("Enter the second number = ");
//var y = Console.ReadLine();
//var z = Convert.ToInt32(x) * Convert.ToInt32(y);
//Console.WriteLine("The result of multiplying {0} by {1} is {2}", x, y, z);


//0. ----------Console App format----------------------------------------
//namespace ConsoleAppSnippets
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }

//    }


//}
