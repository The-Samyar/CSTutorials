using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial
{
    internal class ReturnCapitals
    {
        public static string Run(string text)
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
    }
}
