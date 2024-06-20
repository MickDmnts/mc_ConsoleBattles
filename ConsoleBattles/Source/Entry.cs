using MainMenu;
using System;

namespace MainMenu
{
    public class Menu
    {
        public void Help()
        {
            string help = "Welcome to you hell. This is a simple combat simulator Created by me your worst enemy Andreas! See if you can beat my slaves";
            string howTo = "The way to play to my game is rather easy you simple press a button and let the fight roll till one of you dies!";
            Console.WriteLine(help + "\n" + howTo);
        }

        public void Start()
        {
            Console.WriteLine("Under Maintnance! Try again Later!");
            Console.ReadKey();
        }

        public void QuitGame()
        {
            Console.WriteLine("Damn couldnt play the game you suck! ");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void MainCalls()
        {

            string randomString = Console.ReadLine();
            int choices = 0;
            bool pass = int.TryParse(randomString, out choices);
            bool options = false;

            do
            {
                if (choices == 1)
                {
                    options = true;
                    Start();

                }
                else if (choices == 2)
                {
                    options = false;
                    Help();
                    //Console.ReadKey();
                    Console.WriteLine("\nPress 1 to start the game, Press 2 to get Help, Press 3 to Quit the game!");
                    MainCalls();
                }
                else if (choices == 3)
                {
                    options = true;
                    QuitGame();
                }
                else
                {
                    Console.WriteLine("Press an actual option please");
                    Console.WriteLine("\nPress 1 to start the game, Press 2 to get Help, Press 3 to Quit the game!");
                    MainCalls();
                }
            } while (options || pass || choices < 1 || choices > 4);

        }
    }
}

namespace Player
{
    public class Player
    {

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        Console.WriteLine("Press 1 to start the game, Press 2 to get Help, Press 3 to Quit the game!");
        menu.MainCalls();

    }

}
