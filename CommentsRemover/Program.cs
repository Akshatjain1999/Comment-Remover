using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsRemover
{
    class Program
    {
        private static void Main(string[] args)
        {
            var commentRemover = new CommentRemoverEntity();
            var flag = true;
            while (flag)
            {
                Display.Menu();
                try
                {
                    var choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            var inputString = DataEntity.InputFromConsole();
                            var processedString = commentRemover.TextProcessing(inputString);
                            Display.ShowCodeWithoutComment(processedString);
                            break;
                        case 2:
                            Console.WriteLine("Enter the path to file");
                            var path = Console.ReadLine();
                            inputString = DataEntity.InputFromFile(path);
                            processedString = commentRemover.TextProcessing(inputString);
                            Display.ShowCodeWithoutComment(processedString);
                            break;
                        case 3:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("You entered an invalid choice");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }
        
    }
}
