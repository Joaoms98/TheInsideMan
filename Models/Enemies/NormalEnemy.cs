namespace Game.Models.Enemies;

public class NormalEnemy
{
    public string Name { get; set; } = "ET de varginha";
    public int LimiterLeftSprite  { get; set; } = 2;
    public int LimiterRightSprite  { get; set; } = 2;
    
    //the key is the number of index for add in current position
    public Dictionary<int, string> enemySprite {get; set;} = new Dictionary<int, string> {
        { -2, @"\"},{ -1, @"\"},{ 0, "_"},{ 1, "/"},{ 2, "/"},
          {78, "("},   {79, "o"},  {80, "_"}, {81, "o"},  {82, ")"},
        
    };
}
