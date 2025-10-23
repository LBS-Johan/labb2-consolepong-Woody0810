using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddel player1 = new Paddel(115, 5, 5);
        Ball boll = new Ball(1, 1, 1, 1);
        Paddel player2 = new Paddel(1, 5, 5);
        

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;


        }

        

        public bool Run()
        {

            
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            
            boll.DrawBall();
            boll.MoveBall();
            boll.CheckCollisions(player1,player2,width,height);
            player1.DrawPaddel();
            player2.DrawPaddel();



            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                player1.MovePaddel(-1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                player1.MovePaddel(1);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                player2.MovePaddel(-1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                player2.MovePaddel(1);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
