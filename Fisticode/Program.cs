using Fisticode_Second_Try;
using Fisticode_try4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticode
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Game myGame = new Game();
            myGame.Start();
            Console.Clear();
            Game2 thisGame = new Game2();
            thisGame.Start();
            Console.Clear();
            Game3 thatGame = new Game3();
            thatGame.Start();
            Game4 theirGame = new Game4();
            theirGame.Start();
            Game5 victory = new Game5();
            victory.Start();
            Console.Clear();
        }
    }
}
