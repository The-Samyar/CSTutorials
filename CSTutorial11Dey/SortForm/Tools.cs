using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForm
{
    internal class Tools
    {
        public static string ReturnCapitals(string text)
        {
            string res = "";
            foreach (var item in text)
            {
                if (char.IsUpper(item))
                {
                    res += char.ToString(item);
                }
            }
            return res;
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

        public static List<int> CleanInput(string input)
        {
            List<int> cleaned = new List<int>();
            var inputArray = input.Split(',');
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = inputArray[i].Trim();

                if (int.TryParse(inputArray[i], out int temp))
                {
                    cleaned.Add(temp);
                }
            }
            return cleaned;
        }
    }
}
