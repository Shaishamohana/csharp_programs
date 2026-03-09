using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n (height): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        Console.WriteLine("\n--- Pattern 1: Right-Angled Triangle ---");
        RightTriangle(n);

        Console.WriteLine("\n--- Pattern 2: Inverted Triangle ---");
        InvertedTriangle(n);

        Console.WriteLine("\n--- Pattern 3: Centered Pyramid ---");
        Pyramid(n);
    }

    // Pattern 1: Right-Angled Triangle
    static void RightTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    // Pattern 2: Inverted Triangle
    static void InvertedTriangle(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    // Pattern 3: Centered Pyramid
    static void Pyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s <= n - i; s++)
                Console.Write(" ");
            for (int k = 1; k <= (2 * i - 1); k++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
