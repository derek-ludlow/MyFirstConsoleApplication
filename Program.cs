using System;

class Program
{
    static void Main()
    {
        // Variables to store name and location
        string name = "Derek Ludlow";
        string location = "Rexburg, Idaho";

        // Output name and location using string interpolation
        Console.WriteLine($"My name is {name}, I live in {location}.");

        // Output current date
        DateTime currentDate = DateTime.Today;
        Console.WriteLine($"Today's date is {currentDate:d}.");

        // Calculate days until Christmas 
        DateTime christmas = new DateTime(currentDate.Year, 12, 25);
        int daysUntilChristmas = (int)(christmas - currentDate).TotalDays;
        Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

        // Example program from C# Programming Yellow Book
        Console.WriteLine("Enter the width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height: ");
        double height = double.Parse(Console.ReadLine());

        double woodLength = 2 * (width + height) * 3.25;
        double glassArea = 2 * (width * height);

        Console.WriteLine($"The length of the wood is {woodLength} feet.");
        Console.WriteLine($"The area of the glass is {glassArea} square meters.");

        // Pause the program so it doesn't automatically terminate
        Console.ReadKey();


    }
}