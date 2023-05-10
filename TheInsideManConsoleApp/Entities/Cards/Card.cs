namespace TheInsideManConsoleApp.Entities.Cards;

public class Card
{
    public string Name { get; set; }

    public int TrucoPower { get; set; }
    public Dictionary<int, string> Sprite { get; set; }

    public Card(string name, int trucoPower, Dictionary<int, string> sprite)
    {
        Name = name;
        TrucoPower = trucoPower;
        Sprite = sprite;
    }
}
