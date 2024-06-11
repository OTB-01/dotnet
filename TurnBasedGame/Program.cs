using System.Runtime.Intrinsics.Arm;

namespace TurnBasedGame;

class Program
{
    static void Main(string[] args)
    {
        Unit player = new Unit(100, 20, 10, "Player");
        Unit enemy = new Unit(100, 10, 5, "Enemy");

        Console.WriteLine($"Battle between {player.UnitName} and {enemy.UnitName}");
        Console.WriteLine("\n ");
        Console.WriteLine("Press 'a' to attack or 'h' to heal");
        Battle(player, enemy);

    }

    private static void Battle(Unit player, Unit enemy)
    {
        int turn = 0;
        while (!player.isDead && !enemy.isDead)
        {
            Console.WriteLine($"\n-------- Turn {++turn} --------");
            Console.WriteLine($" {player.UnitName} HP: {player.Hp}");
            Console.WriteLine($" {enemy.UnitName} HP: {enemy.Hp}");

            PlayerTurn(player, enemy);
            System.Threading.Thread.Sleep(1000); // 1 second delay
            if (player.isDead || enemy.isDead) { break; }

            EnemyTurn(player, enemy);
            System.Threading.Thread.Sleep(1000); // 1 second delay
            if (player.isDead || enemy.isDead) { break; }


        }
    }

    private static void EnemyTurn(Unit player, Unit enemy)
    {
        Console.WriteLine("\n Enemy turn");

        Random random = new Random(); // determen whither the enemy attacks or heal
        int enemychoice = random.Next(1, 3);

        if (enemychoice == 1)
        {
            enemy.Attack(player);
        }
        else if (enemychoice == 2)
        {
            enemy.Heal();
        }
    }

    private static void PlayerTurn(Unit player, Unit enemy)
    {
        Console.WriteLine("\n Player turn");
        var choice = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        if (choice == 'a')
        {
            player.Attack(enemy);
        }
        else if (choice == 'h')
        {
            player.Heal();
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
