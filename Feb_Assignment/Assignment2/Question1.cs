using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Question1
    {
        public void Solution(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
                Console.WriteLine($"The {i}th of old array element is {array[i]}");
                Console.WriteLine($"The {i}th of new arrayr element is {newArray[i]}\n");
            }
        }
    }
}
