namespace Game.Models;

public class Player
{
    public string Name { get; set; } = "Rafa Zé Chulapa";
    public int LimiterLeftSprite  { get; set; } = 1;
    public int LimiterRightSprite  { get; set; } = 2;
    
    //the key is the number of index for add in current position
    public Dictionary<int, string> PlayerSprite {get; set;} = new Dictionary<int, string> {
        { 0, "o"},
        { 79, "/"},
        { 81, @"\"},
        { 80, "|"},
        { 159, "/"},
        { 161, @"\"}
    };
}
