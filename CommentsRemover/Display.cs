using System;

namespace CommentsRemover
{
    public class Display
    {
        public static void Menu()
        {
            Console.WriteLine("1) Take input from console");
            Console.WriteLine("2) Take input from file");
            Console.WriteLine("3)Exit");
        }

        public static void ShowCodeWithoutComment(string[] inputString)
        {
            foreach (var input in inputString)
            {
                Console.WriteLine(input);
            }
        }
        
    }
}