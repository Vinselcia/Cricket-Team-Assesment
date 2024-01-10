using System.Collections.Generic;

interface ITeam
{
    void Add(Player player);
    void Remove(int playerId);
    Player GetPlayerById(int playerId);
    Player GetPlayerByName(string playerName);
    List<Player> GetAllPlayers();
}
