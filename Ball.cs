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
        // skapar alla variablar 
        int x;
        int y;
        int xvelocity;
        int yvelocity;
        int player1score = 0;
        int player2score = 0;
        // skapar konstructorn 
        public Ball(int x, int y, int xvelocity, int yvelocity)
        {
            this.x = x;
            this.y = y;
            this.xvelocity = xvelocity;
            this.yvelocity = yvelocity;
        }
        // skapar en metod för att flytta bollen i spelet 
        public void MoveBall()
        {
            int newypositiony = y + yvelocity;
            int newypositionx = x + xvelocity;
                y += yvelocity;
                x += xvelocity;
        }
        // skapar metoden för att rita ut bollen i spelet 
        public void DrawBall()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
        }
        // skapar en metod för att se om bollen kommer i konstakt med något 
        public void CheckCollisions(Paddel p1, Paddel p2, int width, int height)
        {
            // skapar två variablar för att se vart bolen kommer vara 
            int newypositiony = y + yvelocity;
            int newypositionx = x + xvelocity;
            // kollar om den kontaktar övre eller undre delen av skärmen 
            if (newypositiony >= height-1 || newypositiony <=0)
            {
                // om den gjort de byter den håll 
                yvelocity = -yvelocity;
            }
            // kollar vom den nudar en paddel
            if (x==p1.x && y <= p1.y + p1.size && y >= p1.y || x == p2.x  && y <= p2.y + p2.size && y >= p2.y)
            {
                //gör den de byter den hål 
                xvelocity = -xvelocity;
            }
        }
        // bygger en metod för att nolsälla bollen vid mål 
        public void returnball()
        {
            // om player 2 gör mål så läggs bollen i mitten och ökar player 2 score med en 
            if (x > 115)
            {
                x = 60;
                player2score += 1;
                
                
            }
            // om player 1 gör mål så läggs bollen i mitten och ökar player 1 score med en 

            if (x < 1)
            {
                x = 60;
                player1score += 1;
                
                
            }


        }
        // skapar en metod för att rita ut poängen 
        public void drawscore()
        {
            // ritar ut player 2 score i spelet 
            Console.SetCursorPosition(50, 5);
            Console.Write(player2score);
            // ritar ut player 1 score 
            Console.SetCursorPosition(70, 5);
            Console.Write(player1score);

            // kollar om en av spelarna når fem poäng om den gör de nollställs spelet 
            if (player1score == 5 || player2score == 5)
            {
                player1score = 0;
                player2score = 0;
            }
        }
    }

}
