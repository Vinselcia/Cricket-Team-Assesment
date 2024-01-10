using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        OneDayTeam team = new OneDayTeam();
        int choice;

        do
        {
            Console.WriteLine("Enter 1: To Add Player");
            Console.WriteLine("Enter 2: To Remove Player by Id");
            Console.WriteLine("Enter 3: Get Player By Id");
            Console.WriteLine("Enter 4: Get Player by Name");
            Console.WriteLine("Enter 5: Get All Players");
            Console.WriteLine("Enter 6: Exit");
            Console.WriteLine("Enter your choice:");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player ID:");
                        int playerId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();

                        Console.WriteLine("Enter Player Age:");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player(playerId, playerName, playerAge);
                        team.Add(newPlayer);
                        break;

                    case 2:
                        Console.WriteLine("Enter Player ID to Remove:");
                        int idToRemove = Convert.ToInt32(Console.ReadLine());
                        team.Remove(idToRemove);
                        break;

                    case 3:
                        Console.WriteLine("Enter Player ID to Get:");
                        int idToGet = Convert.ToInt32(Console.ReadLine());
                        Player playerById = team.GetPlayerById(idToGet);
                        Console.WriteLine(playerById != null ? playerById.ToString() : "Player not found.");
                        break;

                    case 4:
                        Console.WriteLine("Enter Player Name to Get:");
                        string nameToGet = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(nameToGet);
                        Console.WriteLine(playerByName != null ? playerByName.ToString() : "Player not found.");
                        break;

                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        if (allPlayers.Count > 0)
                        {
                            foreach (Player p in allPlayers)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No players in the team.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (choice != 6);
    }
}
