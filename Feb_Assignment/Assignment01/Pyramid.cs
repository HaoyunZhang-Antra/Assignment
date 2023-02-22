using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Pyramid
    {
        public void Solution(int size)
        {
            int k = 0;
            for (int i = 1 ; i <= size; i++)
            {
                
                for (int j = k; j <= size - 1; j++)
                {
                    Console.Write(" ");
                }
                k++;

                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
