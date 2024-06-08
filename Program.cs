namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var num in EvenNumbers.Generate(5))
            {
                Console.WriteLine($"Even: {num}");
            }
            foreach (var num in OddNumbers.Generate(5))
            {
                Console.WriteLine($"Odd: {num}");
            }
            foreach (var num in PrimeNumbers.Generate(5))
            {
                Console.WriteLine($"Prime: {num}");
            }
            foreach (var num in FibonacciNumbers.Generate(5))
            {
                Console.WriteLine($"Fibonacci: {num}");
            }
            var triangle = new Triangle { Base = 3, Height = 4 };
            Console.WriteLine($"Triangle Area: {triangle.GetArea()}");

            var rectangle = new Rectangle { Width = 5, Height = 6 };
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            var square = new Square { Side = 4 };
            Console.WriteLine($"Square Area: {square.GetArea()}");
            var game = new Game();
            game.Start();
        }
    }
}
    public class EvenNumbers
    {
        public static IEnumerable<int> Generate(int count)
        {
            for (int i = 0; i < count * 2; i += 2)
            {
                yield return i;
            }
        }
    }

public class OddNumbers
    {
        public static IEnumerable<int> Generate(int count)
        {
            for (int i = 1; i < count * 2; i += 2)
            {
                yield return i;
            }
        }
    }
public class PrimeNumbers
    {
        public static IEnumerable<int> Generate(int count)
        {
            int number = 2;
            int found = 0;

            while (found < count)
            {
                if (IsPrime(number))
                {
                    yield return number;
                    found++;
                }
                number++;
            }
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
public class FibonacciNumbers
    {
        public static IEnumerable<int> Generate(int count)
        {
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i < count; i++)
            {
                yield return a;
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
public class Square
    {
        public double Side { get; set; }

        public double GetArea()
        {
            return Side * Side;
        }
    }
public class Game
{
    public void Start()
    {
        Random random = new Random();
        int min = 1;
        int max = 100;
        int target = random.Next(min, max + 1);

        Console.WriteLine($"Guess a number between {min} and {max}:");
        while (true)
        {
            int guess;
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess < target)
                {
                    Console.WriteLine("Too low. Try again:");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Too high. Try again:");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}