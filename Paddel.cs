using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddel
    {
        public int x;
        public int y;
        public int size;

        public Paddel(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;

        }
        public void MovePaddel(int yAmount)
        {
            int newyposition = y + yAmount;
            if (Console.WindowHeight-1 > newyposition + size && newyposition > 0)
            {
                y = newyposition;
            }
        }
        public void DrawPaddel()
        {
            for (int I = 0; I < size; I++)
            {
                Console.SetCursorPosition(x, y+I);
                Console.Write("|");
            }
        }

        
    }
}
