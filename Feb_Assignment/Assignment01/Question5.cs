using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Question5
    {
        public void Greetings()
        {
            DateTime moment = DateTime.Now; 
            int hour = moment.Hour; 
            if (hour < 12)
            { 
                Console.WriteLine("Good Morning!"); 
            }
            else if (hour >= 12 && hour < 17) 
            { 
                Console.WriteLine("Good Afternoon!"); 
            } 
            else if (hour >= 17 && hour < 21) 
            { 
                Console.WriteLine("Good Evening!"); 
            } 
            else 
            { 
                Console.WriteLine("Good Night!"); 
            }
        }
    }
}
