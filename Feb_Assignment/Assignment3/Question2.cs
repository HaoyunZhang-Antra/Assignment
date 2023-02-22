using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Question2
    {
        public int Fibonacci(int i) 
        { 
            if (i <= 2) 
            { 
                return 1; 
            } 
            int a = 1, b = 1, c = 0; 
            for (int j = 3; j <= i; j++) 
            { 
                c = a + b; 
                a = b; 
                b = c; 
            } 
            return c; 
        }

        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                int res = Fibonacci(i);
                Console.WriteLine(res);
            }
            
        }
    }
}
