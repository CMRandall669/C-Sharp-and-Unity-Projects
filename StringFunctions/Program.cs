using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Connor";
            string quote = "The man said, \"Hello\", Connor. \n hello on a new line. \n \t hello on a tab. " ;
            string fileName = @"C:\Users\Connor";

            bool trueOrFalse = name.Contains("s");

            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
        }
    }
}
