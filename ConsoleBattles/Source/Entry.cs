using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.ShowMenu();
    }

    public void ShowMenu()
    {
        int i;
        do
        {
            Console.WriteLine("Start");
            Console.WriteLine("Help");
            Console.WriteLine("Quit");
            Console.WriteLine("");

            string num = Console.ReadLine();
            bool check = int.TryParse(num , out i);
            if (check)
            {
                i = int.Parse(num);
                switch (i)
                {
                    case 1:
                        Start();
                        break;
                    case 2:
                        Help();
                        i = 0;
                        break;
                    case 3:
                        Quit();
                        break;
                    default:
                        if (i < 0)
                        {
                            Start();
                        }
                        else if (i >= 4)
                        {
                            Quit();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("No characters are acceptable... try a number maybe:))");
                Console.WriteLine("");
                i = 0;
            }
        }
        while (i == 0);
    }

    private void Start()
    {
        Console.WriteLine("Fighting");
    }

    private void Help()
    {
        Console.WriteLine("");
        Console.WriteLine("This is how you play my game .. ");
        Console.WriteLine("");
        Console.ReadKey();
    }

    private void Quit()
    {
        Console.WriteLine("");
        Console.WriteLine("Why you are mad ?");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

