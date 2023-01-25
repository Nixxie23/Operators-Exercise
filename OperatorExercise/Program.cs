namespace OperatorExercise
{
    public class Program
    { public static double AreaOfCircle(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
        static void Main(string[] args)
        {// EXERCISE ONE
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int modulus = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");
            }
            else
            {
                Console.WriteLine("You have the wrong integers inserted into your equation.");

            }


            //EXERCISE TWO
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle is {circleArea}");
        }
    }
}
