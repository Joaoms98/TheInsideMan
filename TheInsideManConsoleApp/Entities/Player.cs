namespace TheInsideManConsoleApp.Entities;

public class Player
{
    public string Name { get; set; }
    public int Position { get; set; } = 1750;
    public int LimiterLeftSprite  { get; set; } = 1;
    public int LimiterRightSprite  { get; set; } = 2;
    
    //the key is the number of index for add in current position
    public Dictionary<int, string> PlayerSprite {get; set;} = new Dictionary<int, string> {
                    { 0, "o"},
        { 99, "/"},{ 100, "|"}, { 101, @"\"},
        { 199, "/"},            { 201, @"\"}
    };
}