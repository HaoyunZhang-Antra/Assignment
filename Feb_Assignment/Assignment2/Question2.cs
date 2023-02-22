using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Question2
    {
        List<string> list = new List<string>();
        public void Solution()
        {
            
            Console.WriteLine("Enter command (+ item, - item or -- to clear): ");
            string operation = Console.ReadLine();
            while (operation != null)
            {
                if (operation == "+")
                {
                    Console.Write("Please enter the element you want to add: "); 
                    list.Add(Console.ReadLine()); 
                    Console.WriteLine("The current list is: "); 
                    foreach (var item in list) 
                    { 
                        Console.Write(item + ", "); 
                    }
                    Console.WriteLine();
                    break;
                }
                else if (operation == "-")
                {
                    Console.Write("Please enter the element you want to delete: ");
                    list.Remove(Console.ReadLine());
                    Console.WriteLine($"The current list is: ");
                    foreach (var item in list)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.WriteLine();
                    break;
                }
                else if (operation == "--") 
                {
                    list.Clear(); 
                    Console.WriteLine("You have removed all the elements");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please run again.");
                    break;
                }
            }

            Console.WriteLine("Do you want to continue operation? (yes/no)"); 
            string AskAgain = Console.ReadLine();
            if (AskAgain == "yes")
            {
                Solution();
            }
            else if (AskAgain == "no")
            {
                Console.WriteLine("Program end.");
            }
            else
            {
                Console.WriteLine("Invalid operation. Please run again.");
            }
        }
    }
}
