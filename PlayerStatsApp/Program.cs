using System;
using PlayerStatsApp.Controllers;
using PlayerStatsApp.Models;

PlayerController playerManager = new PlayerController(); // creating an instance of the PlayerController to manage player operations
int nextPlayerID = 1; // initializing a variable to assign unique IDs to new players, so each player can be identified distinctly


bool running = true; // creating a boolean to control the menu loop

while (running)
{
    Console.ForegroundColor = ConsoleColor.Magenta; // setting the console text color to cyan for aethetics

    Console.WriteLine("─── ⋅ Player Statistics Manager ⋅ ───");
    Console.WriteLine("1. Add New Player");
    Console.WriteLine("2. View Players");
    Console.WriteLine("3. Update Player Stats");
    Console.WriteLine("4. Search Player by ID");
    Console.WriteLine("5. Generate Report");
    Console.WriteLine("6. Leave Application");
    Console.Write("Select an option (1-6): ");
    Console.ResetColor();

    string choice = Console.ReadLine(); // number gets stored into the choice variable

    switch (choice) // using the switch statment for the menu, avoiding the complexity of multiple if-else statements
    {
        case "1":
            Console.Clear(); // clearing the console for better readability
            Console.WriteLine("─── ⋅ Add a new player! ⋅ ───");
            Console.Write("Enter player Username: ");
            string username = Console.ReadLine(); // reading the username input from the user

            Console.Write("Enter hours played: ");
            double hoursPlayed = Convert.ToDouble(Console.ReadLine()); // reading and converting hours played input to double

            Console.Write("Enter high score: ");
            int highScore = Convert.ToInt32(Console.ReadLine()); // reading and converting high score input to int

            Player newPlayer = new Player(nextPlayerID, username, hoursPlayed, highScore); // creating a new player object with the provided details, using model layer to represent the player

            playerManager.AddPlayer(newPlayer); // adding the new player to the player manager, using controller layer to handle the addition

            nextPlayerID++; // incrementing the player ID for the next new player
            Console.WriteLine("[■■■■■■■■■] 100%! Player added successfully!");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("─── ⋅ View all  players! ⋅ ───");

            var players = playerManager.GetAllPlayers(); // retrieving all players from the player Manager

            if (players.Count == 0)
            {
                Console.WriteLine("No players could be found, please add a player first.");
            }
            else
            {
                foreach (var player in players) // iterating through each player and displaying their details
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"ID: {player.Id} | Username: {player.Username}");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine ($"Hours Played: {player.HoursPlayed} | High Score: {player.HighScore}");
                }
            }
            break;
        case "3":
            Console.WriteLine("Updating player stats...");
            break;
        case "4":
            Console.WriteLine("─── ⋅ Search for a Player by ID ⋅ ───");

            Console.Write("Enter Player ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine()); // reading and converting the player ID input to int

            var foundPlayer = playerManager.GetPlayerById(searchId); // searching for the player by ID using the player manager
            if (foundPlayer != null)
            {
                Console.WriteLine("Player found:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"ID: {foundPlayer.Id} | Username: {foundPlayer.Username}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine ($"Hours Played: {foundPlayer.HoursPlayed} | High Score: {foundPlayer.HighScore}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player not found! Please re-try.");
                Console.ResetColor();
            }

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