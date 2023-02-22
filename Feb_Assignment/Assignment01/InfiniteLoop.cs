using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class InfiniteLoop
    {
        public void Solution()
        {
            int max = 500;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
