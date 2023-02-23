using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPratice
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int ThrownTimes { get; set; }

        public Ball(int size, Color c)
        {
            Size = size;
            Color = c;
            ThrownTimes = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Thrown()
        {
            if (Size != 0) { 
                ThrownTimes++; 
            }
        }

        public int GetTimes()
        {
            return ThrownTimes;
        }
    }
}
