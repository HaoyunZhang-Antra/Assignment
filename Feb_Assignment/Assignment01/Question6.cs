using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Question6
    {
        public void Solution(int target) 
        { 
            for (int i = 1; i <= 4; i++) 
            { 
                int res = 0; 
                while (res <= target) 
                { 
                    Console.Write($"{res} ");
                    res = res + i; 
                } 
                Console.WriteLine(); 
            }
        }
    }
}
