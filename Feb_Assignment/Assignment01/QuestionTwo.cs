using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class QuestionTwo
    {
        public void ConvertDate(uint century)
        {
            uint year = century * 100;
            uint days = year * 365 + 24 * century;
            uint hours = days * 24; 
            uint minutes = hours * 60;
            uint seconds = minutes * 60;
            ulong milliseconds = Convert.ToUInt64(seconds) * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} second " +
                $" = {milliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }

    }
}
