using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Two_Sum
    {
        public int[] Two_sum_algorithm(int[] nums, int target)
        {
            int[] indexes = new int[2];
            for (int i = 0; i<nums.Length; i++)
            {
                for (int j = i+1; j<nums.Length; j++)
                {
                    int temp_sum = nums[i] + nums[j];
                    if(temp_sum == target)
                    {
                        indexes[0] = i;
                        indexes[1] = j;
                        return indexes;
                    }
                }
            }
            Console.WriteLine("No two values in the array sum to that target.");
            return indexes;
        }

        public void print_array(int[] arr)
        {
            Console.Write("[");
            foreach(var item in arr)
            {
                Console.Write(item);
                if(item != arr[arr.Length - 1])
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(']');
        }

        public void Implement_two_sum(Two_Sum imported)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            imported.print_array(nums);
            Console.WriteLine("Enter a target value.");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Target value is: " + target);
            int[] index_locations = imported.Two_sum_algorithm(nums, target);
            if (index_locations.Any() != true)
            {
                Console.Write("The indexes to sum to target value are: ");
                imported.print_array(index_locations);
            }
        }
    }
}
