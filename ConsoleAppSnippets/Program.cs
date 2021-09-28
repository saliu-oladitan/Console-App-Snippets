using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class ExtensionMethods   // Using Extension Methods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public string Ask(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public int AskInt(string question)
        {
           

            try
            { 
                System.Console.Write(question);
                //return int.Parse(System.Console.ReadLine());  //Replace this in order to use the extension methods
                return System.Console.ReadLine().toInt();  // Making use of extension methods
            }
            catch (Exception)
            {
                throw new FormatException("Input was not a number");
            }
        }
    }
}
