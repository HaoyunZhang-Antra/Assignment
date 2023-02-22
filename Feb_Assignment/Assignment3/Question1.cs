using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Question1
    {
        
        public int[] GenerateNumbers(int n)
        {
            int[] numbers = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = r.Next();
            }
            return numbers;
        }

        public void Reverse(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public void PrintNumbers(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
        }

        public void Run()
        {
            Console.WriteLine("Please input a number as size: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] numbers = GenerateNumbers(x);
            PrintNumbers(numbers);
            Console.WriteLine();
            Reverse(numbers);
            PrintNumbers(numbers);
        }
    }
}
