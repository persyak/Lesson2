using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[ ] {1,2,3,4,5,6,7};

            // Console.WriteLine(nums[1]);
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            
            int d = nums.Length;
            int h = d/2;
            int tempint;
            for (int i=0; i<h; i++)
            {
                tempint = nums[i];
                nums[i] = nums[d - i - 1];
                nums[d - i - 1] = tempint;
            }
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
