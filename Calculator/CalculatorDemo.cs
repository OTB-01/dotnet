namespace Calculator;

class CalculatorDemo
{
    static void Main(string[] args)
    {
        int number_1, number_2, result;
        string operation;

        Console.WriteLine("Enter the first number: ");
        number_1 = Convert.ToInt32(Console.ReadLine()); //casting string to int

        Console.WriteLine("Enter the second number: ");
        number_2 = Convert.ToInt32(Console.ReadLine()); //casting string to int


        Console.WriteLine("Enter the desired operation: ");
        Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                result = number_1 + number_2;
                break;
            case "2":
                result = number_1 - number_2;
                break;
            case "3":
                result = number_1 * number_2;
                break;
            case "4":
                result = number_1 / number_2;
                break;
            default:
                result = 0;
                Console.WriteLine("Invalid operation");
                break;
            }
            Console.WriteLine("The result is: " + result);
        }
    }
