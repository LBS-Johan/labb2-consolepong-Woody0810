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
        // skapar bollen och båda paddlarna 
        Paddel player1 = new Paddel(115, 5, 5);
        Ball boll = new Ball(1, 1, 1, 1);
        Paddel player2 = new Paddel(1, 5, 5);
        

        public void StartGame()
        {
            // Setup konsol-fönstret
            
            Console.CursorVisible = false;


        }

        

        public bool Run()
        {

            
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();
            //skapar variablar för att bygga widthen och höjden på skärmen 
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            // spelar upp alla metoder så de händer i spelet 
            boll.DrawBall();
            boll.MoveBall();
            // lägger in player1 player2 width och height i checkcollisions metoden så de kan användas 
            boll.CheckCollisions(player1,player2,width,height);
            player1.DrawPaddel();
            player2.DrawPaddel();
            boll.returnball();
            boll.drawscore();

            // använder världärna från player1 och player2 i drawpaddel metoden 
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
