using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PraticeString1
    {
        public string Solution1(string str)
        {
            if (str == null)
            {
                string ans = "This string is empty.";
                return ans;
            }

            char[] chars = str.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }

            string res = new string(chars);
            return res;

        }

        public void Solution2(string str)
        {
            if (str == null)
            {
                Console.WriteLine("This string is empty.");
            }

            char[] chars = str.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }

        }
    }
}
