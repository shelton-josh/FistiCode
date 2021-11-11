using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticode
{
    public class Game
    {

        public void Start()
        {           
            Console.WriteLine("         #######    ###     #####     #######    ###              #####     #######    ######     ####### ");
            Console.WriteLine("         #           #     #     #       #        #              #     #    #     #    #     #    #       ");
            Console.WriteLine("         #           #     #             #        #     #####    #          #     #    #     #    #       ");
            Console.WriteLine("         #####       #      #####        #        #              #          #     #    #     #    #####   ");
            Console.WriteLine("         #           #           #       #        #     #####    #          #     #    #     #    #       ");
            Console.WriteLine("         #           #     #     #       #        #              #     #    #     #    #     #    #       ");
            Console.WriteLine("         #          ###     #####        #       ###              #####     #######    ######     ####### ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                             A Game By Jon And Josh");

            Console.WriteLine("\n\n\n           Weighing in at 64 bytes and standing at a whopping 20 lines of code, our challenger CONSWOLE!!!");
            Console.WriteLine("           Fight through 2 expeienced boxers before you face the undefeated Keyboard Champion of the Computer,                                                                       MIKE TYPSON!!!");
            Console.WriteLine("           Your opponents will try to hit you with one of five attacks, and its up to you to guess the right dodge");
            Console.WriteLine("           your options are hit the arrow keys or spacebar. Be careful though, while the first two fighters                                             might be easy, Mike is a force to be reckoned with. ");
            Console.WriteLine("           You and your opponent will each recieve three lives at the beginning of the bout so make sure to figure                                                             out their moves fast.");
            Console.WriteLine("                         Now, without further ado, press enter to face you first opponent Blocky.\n\n\n");
            Console.WriteLine("Press enter to continue");

        Start:
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.Clear();
            
            if (keyPressed.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("First opponent =Blocky= ");
            }
            else
            {
                Console.WriteLine("Press enter");
            }
            if (keyPressed.Key != ConsoleKey.Enter)
            {
                goto Start;
            }
            Console.ReadKey(true);
        }
    }

}
