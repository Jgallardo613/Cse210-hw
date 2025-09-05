using System; // This lines 

class Program
{
    static void Main(string[] args)
    {
        //Line 7: This line prompts the user to enter their first name.
        Console.Write("What is your first name?");

        //Line 10: This line reads the user input and stores it in a string variable named'firstname'.
        string firstName = Console.ReadLine();

        //Line 13: This line prompts the user to enter their last name?);
        Console.Write("What is your last name? ");

        //line 16: This line reads the user input stores its in a string variable named "LastName".
        string LastName = Console.ReadLine();

        //line 19: This line prints the final formatted sentence using the string interpolation.
        Console.WriteLine($"Your name is {LastName}, {firstName}, {LastName}.");
        

    }
}