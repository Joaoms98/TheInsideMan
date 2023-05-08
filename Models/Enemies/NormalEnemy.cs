namespace Game.Models.Enemies;

public class NormalEnemy
{
    public int Position { get; set; } = 50;

    public NormalEnemy(int position)
    {
        this.Position = position;
    }

    public int LimiterLeftSprite  { get; set; } = 2;
    public int LimiterRightSprite  { get; set; } = 2;
    
    //the key is the number of index for add in current position
    public Dictionary<int, string> enemySprite {get; set;} = new Dictionary<int, string> {
        { -2, @"\"},{ -1, @"\"},{ 0, "_"},{ 1, "/"},{ 2, "/"},
          {98, "("},   {99, "o"},  {100, "_"}, {101, "o"},  {102, ")"},
        
    };
}
