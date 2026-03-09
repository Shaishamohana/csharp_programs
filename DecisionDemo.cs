using System;

class DecisionDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a day number (1-7):");
        int day = Convert.ToInt32(Console.ReadLine());

        // First check validity using if-else
        if (day < 1 || day > 7)
        {
            Console.WriteLine("Invalid day number! Please enter between 1 and 7.");
        }
        else
        {
            // If valid, use switch to print the day
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
