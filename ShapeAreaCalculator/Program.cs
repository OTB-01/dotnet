/* calculates the area of either a rectangle or a circle
*/

namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("choose 1 for rectangle, choose 2 for circle");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("enter the rectangle length");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the rectangle width");
                int width = Convert.ToInt32(Console.ReadLine());

                int area = length * width;
                Console.WriteLine($"the rectangle area is {area}");
                break;
            
            case 2:
                Console.WriteLine("Enter the circle radius");
                double radius = Convert.ToDouble(Console.ReadLine());

                double circleArea = 3.14 * radius * radius;
                Console.WriteLine($"the circle area is {circleArea}");
                break;

            default:
                Console.WriteLine("invalid choice");
                break;
        }
    }
}
