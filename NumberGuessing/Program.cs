/*this program will generate a random number and ask the user to guess it
 * the user have limited chances to guess the number
*/

namespace NumberGuessing;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1, 101); // generates a random number between 1 and 100
        int guess;
        int chances = 5;

        Console.WriteLine("\nWelcome to the number guessing game!");
        Console.WriteLine("I am thinking of a number between 1 and 100.");
        Console.WriteLine("You have 5 chances to guess the number.");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nChances left {chances}");
            Console.WriteLine("Enter your guess: ");

            guess = Convert.ToInt32(Console.ReadLine());
            
            if (guess == number)
            {
                Console.WriteLine("Congratulations! You guessed the number.");
                break;
            }

            else if (guess > number)
            {
                Console.WriteLine("Too high. Try again.");
                chances = chances - 1;
            }

            else if (guess < number)
            {
                Console.WriteLine("Too low. Try again.");
                chances = chances - 1;
            }
        }

    }
}
