using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            chars = Array.FindAll<char>(chars, (c => (char.IsLetterOrDigit(c))));
            string removedString = new string(chars).ToLower();
            if (removedString.SequenceEqual(removedString.Reverse()))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            string palindrome = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(palindrome));           
            Console.ReadLine();
        }
    }
}
