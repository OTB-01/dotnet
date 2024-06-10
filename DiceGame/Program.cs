namespace DiceGame;

class Program
{
    static void Main(string[] args)
    {
        int AI_Score= 0, player_Score= 0, diceRoll = 0;
        Random random = new Random();
        Console.WriteLine("Press any key to roll the dice !!!.");

        for(int rounds = 0 ; rounds < 5 ; rounds++){
            Console.WriteLine($"\n--------- Round {rounds+1} ---------");
            Console.WriteLine($"Score: player {player_Score} -  AI {AI_Score}");
            // Player part
            Console.WriteLine("\nyour turn:");
            Console.ReadKey(); // holds the program execution until any key is pressed

            Console.WriteLine("Rolling dice...");
            System.Threading.Thread.Sleep(1000); // program waits for 1 second

            diceRoll = random.Next(1, 7); // generates a random number between 1 and 6
            Console.WriteLine($"you rolled: {diceRoll}");
            player_Score = player_Score+ diceRoll;
            
            // AI part
            Console.WriteLine("\nAI's turn:");

            Console.WriteLine("Rolling dice...");
            System.Threading.Thread.Sleep(1000); // program waits for 1 second

            diceRoll = random.Next(1, 7); // generates a random number between 1 and 6
            Console.WriteLine($"AI rolled: {diceRoll}");
            AI_Score = AI_Score + diceRoll;

            Console.WriteLine($"\nyour score: {player_Score}");
            Console.WriteLine($"AI score: {AI_Score}");
        }

        if(player_Score > AI_Score)
        {
            Console.WriteLine("\nYOU WON !!!");
        }
        else if(player_Score < AI_Score)
        {
            Console.WriteLine("\nYOU LOST !!!");
        }
        else
        {
            Console.WriteLine("\nDRAW !!!");
        }
    }
}
