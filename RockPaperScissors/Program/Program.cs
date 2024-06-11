// this program will simulate a rock, paper, scissors game between you and the computer
// the computer will choose randomly between rock, paper, and scissors
// you will be asked to enter your choice
// the winner will be displayed

class Program
{
    static void Main(string[] args)
    {
        int playerScore = 0;
        int computerScore = 0;
        Random random = new Random();

        while (playerScore < 3 && computerScore < 3)
        {
            Console.WriteLine
                (
                "\n1- rock,"
                + "\n2- paper,"
                + "\n3- for scissors"
                + "\nenter your choice: (1-3)");

            int pChoice = int.Parse(Console.ReadLine());
            string playerChoice = GetChoice(pChoice);


            int cChoice = random.Next(1, 4);
            string computerChoice = GetChoice(cChoice);

            Rules(ref playerScore, ref computerScore, playerChoice, computerChoice);
            Console.WriteLine($" the computer chose {computerChoice}");
            Console.WriteLine($" you chose {playerChoice}");
        }

    }

    private static void Rules(ref int playerScore, ref int computerScore, string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            Console.WriteLine("it's a tie");
        }
        else if (playerChoice == "rock" && computerChoice == "scissors")
        {
            Console.WriteLine("you win");
            playerScore++;
        }
        else if (playerChoice == "paper" && computerChoice == "rock")
        {
            Console.WriteLine("you win");
            playerScore++;
        }
        else if (playerChoice == "scissors" && computerChoice == "paper")
        {
            Console.WriteLine("you win");
            playerScore++;
        }
        else
        {
            Console.WriteLine("you lose");
            computerScore++;
        }
    }

    public static String GetChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                return "rock";
            case 2:
                return "paper";
            case 3:
                return "scissors";
            default:
                return "invalid";
        }
    }
}