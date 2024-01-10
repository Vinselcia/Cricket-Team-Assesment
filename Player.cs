class Player
{
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Player(int playerId, string name, int age)
    {
        PlayerId = playerId;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Player ID: {PlayerId}, Name: {Name}, Age: {Age}";
    }
}
