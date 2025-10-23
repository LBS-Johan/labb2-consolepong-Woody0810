using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int x;
        int y;
        int xvelocity;
        int yvelocity;

        public Ball(int x, int y, int xvelocity, int yvelocity)
        {
            this.x = x;
            this.y = y;
            this.xvelocity = xvelocity;
            this.yvelocity = yvelocity;
        }
        public void MoveBall()
        {
            int newypositiony = y + yvelocity;
            int newypositionx = x + xvelocity;
                y += yvelocity;
                x += xvelocity;
        }
        public void DrawBall()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
        }
        public void CheckCollisions(Paddel p1, Paddel p2, int width, int height)
        {
            int newypositiony = y + yvelocity;
            int newypositionx = x + xvelocity;
            if (newypositiony >= height-1 || newypositiony <=0)
            {
                yvelocity = -yvelocity;
            }
            if (x==p1.x && y <= p1.y + p1.size && y >= p1.y || x == p2.x  && y <= p2.y + p2.size && y >= p2.y)
            {
                xvelocity = -xvelocity;
            }
        }
    }

}
