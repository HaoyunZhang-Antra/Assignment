using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Question7
    {
        public void Solution(int[] arr) 
        { 
            Dictionary<int, int> freq = new Dictionary<int, int>(); 
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>(); 
            int leftmost = int.MaxValue; 

            for (int i = 0; i < arr.Length; i++) 
            { 
                if (!freq.ContainsKey(arr[i])) 
                { 
                    freq.Add(arr[i], 1); 
                    firstOccurrence.Add(arr[i], i); 
                } 
                else 
                { 
                    freq[arr[i]]++; 
                } 
            } 

            int mostFreq = freq.Values.Max(); 
            int num = -1; 

            foreach (var key in freq.Keys) 
            { 
                if (freq[key] == mostFreq && firstOccurrence[key] < leftmost) 
                { 
                    leftmost = firstOccurrence[key]; 
                    num = arr[leftmost]; 
                } 
            } 

            Console.WriteLine($"The number {num} is the most frequent (occurs {mostFreq} times)"); 
        }
    }
}
