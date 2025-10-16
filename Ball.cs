using System;
using System.Collections.Generic;
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

        }
        public void DrawBall()
        {
        }
        public void CheckCollisions(Paddel p1, Paddel p2, int width, int height)
        {

        }
    }

}
