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
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Help");
            Console.WriteLine("3.Quit");
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
        Console.WriteLine("");
        Console.WriteLine("Greetings");

        //First Character
        Console.WriteLine("");
        Console.WriteLine("First Player Create Your Character");
        Console.WriteLine("");
        Character firstCharacterClass = ChooseClass();

        //Second Character
        Console.WriteLine("");
        Console.WriteLine("Second Player Create Your Character");
        Console.WriteLine("");
        Character secondCharacterClass = ChooseClass();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Your character names, classes and stats are:");
        Console.WriteLine("");
        Console.WriteLine($"First player your name is {firstCharacterClass._Name} and your class is {firstCharacterClass.GetType()},");
        Console.WriteLine($"your Hp is {firstCharacterClass.Hp}, your Armor is {firstCharacterClass.Armor}, and your Attack Power is {firstCharacterClass.AttackPower}.");
        Console.WriteLine("");
        Console.WriteLine($"Second player your name is {secondCharacterClass._Name} and your class is {secondCharacterClass.GetType()},");
        Console.WriteLine($"your Hp is {secondCharacterClass.Hp}, your Armor is {secondCharacterClass.Armor} and your Attack Power is {secondCharacterClass.AttackPower}.");
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Press any key to start combat...");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Combat starting!");
        Console.WriteLine("");
        KsyloStoMegaloDialeimma(firstCharacterClass, secondCharacterClass);
    }

    private void Help()
    {
        Console.WriteLine("");
        Console.WriteLine("This is how you play the game .. ");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("");
    }

    private void Quit()
    {
        Console.WriteLine("");
        Console.WriteLine("Why you leaving so soon??");
        Console.ReadKey();
        Environment.Exit(0);
    }

    private Character ChooseClass()
    { 
        int index;
        do
        {
            Console.WriteLine("Chooce your class");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Mage");
            Console.WriteLine("3.Rogue");
            Console.WriteLine("");


            string characterClass = Console.ReadLine();
            bool check = int.TryParse(characterClass, out index);
            if (check)
            {
                index = int.Parse(characterClass);

                Character characterClass1 = ChooseCharacterClass(index);
                Console.WriteLine("");
                Console.WriteLine("Please type your hero name:");
                Console.WriteLine("");
                characterClass1._Name = Console.ReadLine();
                return characterClass1;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("No characters are acceptable... try a number maybe:))");
                Console.WriteLine("");
                index = 0;
                return null;
            }
        }
        while (index == 0);
    }

    private Character ChooseCharacterClass(int index)
    {
        if (index == 1)
        {
            Warrior warriorClass = new Warrior();
            return warriorClass;
        }
        else if (index == 2)
        {
            Mage mageClass = new Mage();
            return mageClass;
        }
        else if (index == 3)
        {
            Rogue rogueClass = new Rogue();
            return rogueClass;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("You didnt choose an available class. Now you are obligated to play as Warrior.");
            Warrior warriorClass = new Warrior();
            return warriorClass;
        }
    }

    private void KsyloStoMegaloDialeimma(Character player1, Character player2)
    {
        int i = 0;
        while (player1.Hp >= 0 || player2.Hp >= 0)
        {
            Console.WriteLine("");
            Console.WriteLine($"--- Round {i} ---------------------------------------------");
            Console.WriteLine("");

            //First player Attacks
            player2.Hp -= player1.Attack();
            Console.WriteLine("");
            Console.WriteLine($"{player1._Name} attacks, for {player1.Attack()} damage!");
            Console.WriteLine("");
            Console.WriteLine($"Player {player1._Name}, HP {player1.Hp}");
            Console.WriteLine($"Player {player2._Name}, HP {player2.Hp}");
            Console.WriteLine("");

            //Second player Attacks
            player1.Hp -= player2.Attack();
            Console.WriteLine("");
            Console.WriteLine($"{player2._Name} attacks, for {player2.Attack()} damage!");
            Console.WriteLine("");
            Console.WriteLine($"Player {player1._Name}, HP {player1.Hp}");
            Console.WriteLine($"Player {player2._Name}, HP {player2.Hp}");
            Console.WriteLine("");

            i++;
            Console.ReadKey();
            Console.WriteLine("");

            if (player1.Hp <= 0)
            { 
                Console.WriteLine($"{player2._Name} Wins!!");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (player2.Hp <= 0)
            {
                Console.WriteLine($"{player1._Name} Wins!!");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}