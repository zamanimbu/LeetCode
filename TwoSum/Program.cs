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
            int[] number = { 2,7,11,15};
            int target = 9;

            int[] output = GetTwoSum(number, target);
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
            Console.ReadKey();
        }

        private static int[] GetTwoSum(int[] nums, int target)
        {
            var recordTable = new Dictionary<int,int>();
            int difference = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                difference = target - nums[i];
                if (recordTable.ContainsKey(difference))
                    return new int[] { recordTable[difference] + 1, i + 1 };
                else
                {
                    if (!recordTable.ContainsKey(nums[i]))
                    {
                        recordTable.Add(nums[i], i);
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
