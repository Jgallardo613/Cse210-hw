using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Collect numbers from the user.
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Part 2: Calculate the sum and average.
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }

        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // Part 3: Find the largest number.
        int max = -1;
        if (numbers.Count > 0)
        {
            max = numbers[0];
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
        }
        

        // Final output.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}