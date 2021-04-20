using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CommentsRemover
{
    public class CommentRemoverEntity
    {
        /// <summary>
        /// TextProcessing method takes a string parameter
        /// and use regex to remove comments and return the processed text.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string [] lines</returns>

        public string[] TextProcessing(string input)
        {
            //pattern for comments
            var patternComments = new Regex(@"(?<c>'""')|(?<q>""([^\\""\n]*(\\.)*)*"")|(?<v>@""([^""]*("""")*)*"")|(?<m>(?s)/\*.*?\*/)|(?<d>(?m)///.*$)|(?<s>(?m)//.*$)");
            // passing 2 parameters in Replace() method 
            // so if regular expression pattern is matched, it will replace and return new instance 
            var removeComments = patternComments.Replace(input, ReplaceComments);

            //\s matches any whitespace character (equivalent to [\r\n\t\f\v ])
            var patternWhiteSpace = new Regex(@"(?m)^(\s)*$");

            // replacing empty lines with empty string
            var removingWhiteSpace = patternWhiteSpace.Replace(removeComments, "");

            // splitting multi-line string into lines to run loop
            var lines = removingWhiteSpace.Split(new char[] { '\r', '\n' });

            return lines;
        }
        public static string ReplaceComments(Match m)
        {
            if (m.Groups["m"].Success || m.Groups["s"].Success)
            {
                return string.Empty;
            }
            return m.Value;
        }
    }
}