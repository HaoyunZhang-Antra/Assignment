using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Question5
    {
        public int[] Solution(int[] arr) 
        { 
            int num = arr[0]; 
            int maxCount = 1; 
            int count = 1; 
            for (int i = 1; i < arr.Length; i++) 
            { 
                if (arr[i] == arr[i - 1]) 
                { 
                    count++;
                    if (count > maxCount) 
                    { 
                        maxCount = count; 
                        num = arr[i]; 
                    } 
                } 
                else 
                { 
                    count = 1; 
                } 
            } 
            int[] res = new int[maxCount]; 
            Array.Fill(res, num); 
            return res; 
        }
    }
}
