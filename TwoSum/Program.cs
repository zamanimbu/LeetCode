using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 7, 11, 15 };
            int target = 9;

            int[] output = GetTwoSum(number, target);
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
            Console.ReadKey();
        }

        private static int[] GetTwoSum(int[] number, int target)
        {
            var calclulationDictionary = new Dictionary<int, int[]>();

            for (int i = 0; i < number.Length; i++)
            {
                calclulationDictionary.Add(number[i], new int[] { number[i] + target, i });
            }
            foreach(var item in calclulationDictionary)
            {
                if(Math.Abs())
            }
            return new int[] { -1, -1 };
        }
    }
}
