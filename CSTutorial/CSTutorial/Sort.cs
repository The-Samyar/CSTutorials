using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial
{
    internal class Sort
    {
        public static void Run()
        {
            var nums = new List<int>();
            string input;
            Console.WriteLine("Type in some integers. Press enter when you are done");
            do
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int item))
                {
                    nums.Add(item);
                }
                else if (input != "")
                {
                    Console.WriteLine("Enter integer only");
                }
            }
            while (input != "");

            if (nums.Count == 0)
            {
                Console.WriteLine("Nums array is empty");
                return;
            }

            Console.WriteLine("Unsorted array:");

            // Before
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }

            nums = BubbleSort(nums);

            // After
            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }
            return;
        }

        public static List<int> BubbleSort(List<int> nums)
        {
            for (int i = nums.Count; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (nums[j] < nums[j - 1])
                    {
                        (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                    }
                }
            }
            return nums;
        }
    }
}
