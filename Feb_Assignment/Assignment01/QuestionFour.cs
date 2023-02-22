using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class QuestionFour
    {
        public void Solution() 
        { 
            Console.Write("Please enter the year you were born: "); 
            int year = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Please enter the month you were born: "); 
            int month = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Please enter the day you were born: "); 
            int day = Convert.ToInt32(Console.ReadLine()); 
            DateTime DateOfBirth = new DateTime(year, month, day); 
            double days = (DateTime.Today - DateOfBirth).TotalDays; 
            Console.WriteLine($"You have been lived for {days} days!"); 
            int daysToNextAnniversary = Convert.ToInt32(10000 - (days % 10000)); 
            Console.WriteLine($"There are {daysToNextAnniversary} days left to your next Anniversary"); 
        }
    }
}
