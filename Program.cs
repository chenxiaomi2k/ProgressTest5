using ProgressTest5;

internal class Program
{
    static Club players = new Club();

    public static int menu()
    {
        Console.WriteLine("1. Create new Player");
        Console.WriteLine("2. List all Players");
        Console.WriteLine("3. Search Player by Name");
        Console.WriteLine("4. Raise Attack Event");
        Console.WriteLine("5. Raise Defense Event");
        Console.WriteLine("6. Exit");
        while (true)
        {
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice >= 1 && choice <= 6)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Enter again!");
            }
        }
    }

    public static void CreatePlayer()
    {
        Console.Write("Enter player's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter player's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter player attack: ");
        int atk = int.Parse(Console.ReadLine());
        Console.Write("Enter player defense: ");
        int def = int.Parse(Console.ReadLine());
        Console.Write("Enter player stamina: ");
        int sta = int.Parse(Console.ReadLine());
        Console.Write("Enter player speed: ");
        int speed = int.Parse(Console.ReadLine());
        Console.Write("Enter player power: ");
        int pow = int.Parse(Console.ReadLine());
        Player p = new Player(name, age, atk, def, sta, speed, pow);
        double point = (atk + def + sta + speed + pow) / 5;
        players.Add(p);
        if (point > 80)
        {
            players.AttackEvent += new ActionDelegate(p.GetInfo);
        }
        else if (point > 60 && point < 80)
        {
            players.DefenseEvent += new ActionDelegate(p.GetInfo);
        }
    }

    public static Player? SearchPlayer(string name)
    {
        foreach (Player player in players)
        {
            if (player.Name.Contains(name))
            {
                return player;
            }
            else
            {
                Console.WriteLine("Cannot find the player");
            }
        }
        return null;
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            int choice = menu();
            switch (choice)
            {
                case 1:
                    CreatePlayer();
                    break;
                case 2:
                    foreach (Player p in players)
                    {
                        p.GetInfo();
                    }
                    break;
                case 3:
                    Console.Write("Enter player name: ");
                    string name = Console.ReadLine();
                    Player player = SearchPlayer(name);
                    player?.GetInfo();
                    break;
                case 4:
                    players.RaiseAtkEvent();
                    break;
                case 5:
                    players.RaiseDefEvent();
                    break;
                case 6:
                    return;
            }
        }
    }
}