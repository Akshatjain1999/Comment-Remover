using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace CommentsRemover
{
    public class DataEntity
    {
        public static string InputFromConsole()
        {
            Console.Write("Enter the number of lines you want: ");
            var n = int.Parse(Console.ReadLine() ?? string.Empty);
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }
            
            return sb.ToString();
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