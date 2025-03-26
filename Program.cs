using System;
class Program
{
    private static object username;

    public static void Main() 
    {
        //Ask for the user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        // Store user input
        // Greet the user
        Console.WriteLine($"Hello, {username}! Welcome to C#.");
        // Keep console open until user presses a key
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }  
}