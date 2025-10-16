using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddel
    {
        int x;
        int y;
        int size;

        public Paddel(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }
        public void MovePaddel(int yAmount)
        {

        }
        public void DrawPaddel()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        
    }
}
