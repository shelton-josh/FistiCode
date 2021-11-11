using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticode_Second_Try
{
    public class Game3
    {
        public void Start()
        {
            int lives = 3;
            int enemyLives = 3;            
            Console.Clear();
            Console.WriteLine("Your second opponent is C# Cena");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("C# Cena begins up to attack!");
            Console.WriteLine("Input dodge");
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            // First Attack
            if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You hit C# Cena in the chin!");
                enemyLives--;
            }
            else if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("You can't see C# Cena and he uppercuts you out of nowhere!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.WriteLine("You can't see C# Cena and he jabs you out of nowhere!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Console.WriteLine("You can't see C# Cena and he haymakers you out of nowhere!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("You can't see C# Cena and he super man punches you out of nowhere!");
                lives--;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were indecisive and C# Cena jabbed you");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("C# Cena prepares for a second attack");
            Console.WriteLine("input dodge");
            ConsoleKeyInfo keyPressed2 = Console.ReadKey();
            // Second Attack
            if (keyPressed2.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You hit C# Cena on the chin");
                enemyLives--;
            }
            else if (keyPressed2.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were indecisive and C# Cena jabs you");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("C# Cena prepares for a third attack");
            Console.WriteLine("input dodge");
            ConsoleKeyInfo keyPressed3 = Console.ReadKey();
            // third attack
            if (keyPressed3.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You hit C# Cena on the chin");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.WriteLine("\n Press  enter to continue");
                    Console.ReadKey();
                    return;
                }
            }
            else if (keyPressed3.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were indecisive and C# Cena jabs you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("C# Cena prepares for a fourth attack, choose wisely!!!");
            Console.WriteLine("input dodge");
            ConsoleKeyInfo keyPressed4 = Console.ReadKey();
            // fourth attack
            if (keyPressed4.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You hit C# Cena on the chin");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.WriteLine("\n Press  enter to continue");
                    Console.ReadKey();
                    return;
                }
            }
            else if (keyPressed4.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then double uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were indecisive and C# Cena hit you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("C# Cena prepares for a fifth attack, choose wisely!!!");
            Console.WriteLine("input dodge");
            ConsoleKeyInfo keyPressed5 = Console.ReadKey();
            // fifth attack
            if (keyPressed5.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You hit C# Cena on the chin");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.WriteLine("\n Press  enter to continue");
                    Console.ReadKey();
                    return;
                }
            }
            else if (keyPressed5.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("C# Cena ducks down then uppercuts you!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were indecisive and C# Cena uppercuts you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.WriteLine("\n Press enter to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
        }
    }
}

