using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Question3
    {
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            if (startNum <= 0 || endNum <= 0 || startNum > endNum)
            {
                return null;
            }
            List<int> res = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (CheckPrime(i))
                {
                    res.Add(i);
                }
                else
                { continue; }
            }
            return res.ToArray();
        }

        private bool CheckPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
