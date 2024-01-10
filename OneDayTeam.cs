using System;
using System.Collections.Generic;

class OneDayTeam : ITeam
{
    public static List<Player> oneDayTeam = new List<Player>();

    public OneDayTeam()
    {
        oneDayTeam = new List<Player>(capacity: 11);
    }

    public void Add(Player player)
    {
        if (oneDayTeam.Count < 11)
        {
            oneDayTeam.Add(player);
            Console.WriteLine($"Player {player.Name} added to the team.");
        }
        else
        {
            Console.WriteLine("The team already has 11 players. Cannot add more.");
        }
    }

    public void Remove(int playerId)
    {
        Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
        if (playerToRemove != null)
        {
            oneDayTeam.Remove(playerToRemove);
            Console.WriteLine($"Player {playerToRemove.Name} removed from the team.");
        }
        else
        {
            Console.WriteLine("Player not found in the team.");
        }
    }

    public Player GetPlayerById(int playerId)
    {
        return oneDayTeam.Find(p => p.PlayerId == playerId);
    }

    public Player GetPlayerByName(string playerName)
    {
        return oneDayTeam.Find(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
    }

    public List<Player> GetAllPlayers()
    {
        return oneDayTeam;
    }
}
