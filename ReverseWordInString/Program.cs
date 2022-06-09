using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(ReverseWordInString(inputString));
            Console.ReadKey();
        }

        private static string ReverseWordInString(string inputString)
        {
            string removedSpace = string.Join(" ", inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> listWord = removedSpace.Split(' ').ToList();

            return String.Join(" ", listWord.ToArray().Reverse());
        }
    }
}
