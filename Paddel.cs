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
        // sätter in ints så jag kan lägga in världen 
        public int x;
        public int y;
        public int size;
        //bygger min konstruktor
        public Paddel(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;

        }
        // här skappar jag enb metod som gör att man kan flytta på paddeln 
        public void MovePaddel(int yAmount)
        {
            //skappar en ny int för att se vart bollen kommer vara 
            int newyposition = y + yAmount;
            // kollar om bollen kommer vara på samma plats som paddeln är 
            if (Console.WindowHeight-1 > newyposition + size && newyposition > 0)
            {
                y = newyposition;
            }
        }
        public void DrawPaddel()
   { // skapar en metod för att rita ut paddlarna i spelet
            for (int I = 0; I < size; I++)
            {
                // bästemer vart den ska vara 
                Console.SetCursorPosition(x, y+I);
                Console.Write("|");
            }
        }

        
    }
}
