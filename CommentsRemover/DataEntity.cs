using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace CommentsRemover
{
    /// <summary>
    /// DataEntity class has two functions:
    /// 1) Take input from console
    /// 2) Tale input from system file.
    /// </summary>
    public class DataEntity
    {
        public static string InputFromConsole()
        {
            Console.Write("Enter the number of lines you want: ");
            var numLines = int.Parse(Console.ReadLine() ?? string.Empty);
            var inputString= new StringBuilder();
            for (var i = 0; i < numLines; i++)
            {
                inputString.AppendLine(Console.ReadLine());
            }
            
            return inputString.ToString();
        }

        public static string InputFromFile(string path)
        {
            var inputString = new StringBuilder();
            try
            {
                var fileReader = new StreamReader(path);
                var line = "";
                while ((line = fileReader.ReadLine()) != null)
                {
                    inputString.AppendLine(line);
                }
                fileReader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
            return inputString.ToString();
        }

    }
}