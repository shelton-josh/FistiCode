using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fisticode
{
    public class Game5
    {
        public void Start()
        {
            Console.Clear();
            foreach (char letter in "You did it! You have defeated Mike Typeson and have become the ultimate KeyBoard Warrior Champion!!!                ") { Thread.Sleep(50); Console.Write(letter); }

            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine(" #####  ####### #     #  #####  ######     #    ####### #######    ### ### ### ");
            Console.WriteLine("#     # #     # ##    # #     # #     #   # #      #         #     ### ### ### ");
            Console.WriteLine("#       #     # # #   # #       #     #  #   #     #        #      ### ### ### ");
            Console.WriteLine("#       #     # #  #  # #  #### ######  #     #    #       #        #   #   #  ");
            Console.WriteLine("#       #     # #   # # #     # #   #   #######    #      #                    ");
            Console.WriteLine("#     # #     # #    ## #     # #    #  #     #    #     #         ### ### ### ");
            Console.WriteLine(" #####  ####### #     #  #####  #     # #     #    #    #######    ### ### ### ");
            Console.WriteLine("\n\n");
          
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Please press Enter to exit and enjoy your life as the champ!");
            Console.ReadKey();

        }
    }
}
