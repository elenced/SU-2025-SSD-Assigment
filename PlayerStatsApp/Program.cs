using System;

bool running = true; // creating a boolean to control the menu loop

while (running)
{
    Console.WriteLine("──────‧₊˚ Player Statistics Manager ‧₊──────");
    Console.WriteLine("1. Add New Player");
    Console.WriteLine("2. View Players");
    Console.WriteLine("3. Update Player Stats");
    Console.WriteLine("4. Search Player by ID");
    Console.WriteLine("5. Generate Report");
    Console.WriteLine("6. Leave Application");
    Console.Write("Select an option (1-6): ");

    string choice = Console.ReadLine(); // number gets stored into the choice variable

    switch (choice) // using the switch statment for the menu, avoiding the complexity of multiple if-else statements
    {
        case "1":
            Console.WriteLine("Adding a new player...");
            break;
        case "2":
            Console.WriteLine("Viewing players...");
            break;
        case "3":
            Console.WriteLine("Updating player stats...");
            break;
        case "4":
            Console.WriteLine("Searching player by ID...");
            break;
        case "5":

            Console.WriteLine("Generating report...");
            break;
        case "6":
            // Exit the application
            running = false;
            Console.WriteLine("Exiting the application!");
            break;
        default:
            Console.WriteLine("Invalid input, try again.");
            break;
    }
    Console.WriteLine(); 
}