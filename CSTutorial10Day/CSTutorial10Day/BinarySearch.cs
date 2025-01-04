using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial10Day
{
    internal class BinarySearch
    {
        public static bool Run(int target, int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (numbers[mid] == target)
                {
                    return true;
                }
                else
                {
                    if (target > (numbers[mid]))
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return false;
        }
    }
}
