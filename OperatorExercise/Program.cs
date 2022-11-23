namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle (double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }

        static void Main(string[] args)
        {
            // --------Exercise 1-----------------------------
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // ---------Ecercise 2------------------------------

            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle of {userInput} is {AreaOfCircle(radius)}");



        }
    }
}
