using TheInsideManConsoleApp.Animations;
using TheInsideManConsoleApp.Entities;
using TheInsideManConsoleApp.Entities.Enemies;

namespace TheInsideManConsoleApp.Stages;

public class Stage1 : Messages
{
    private List<string> display { get; set; } = new List<string>();
    private Player player = new Player();
    private List<ET> enemies = new List<ET>(){
        new ET(12), new ET(28),new ET(37),new ET(54),
        new ET(68),new ET(79),new ET(86),new ET(89),
        new ET(90),new ET(93),new ET(94),new ET(27),
    };

    int WinTimeCount = 0;

    /// <summary>
    /// Populate list display with white space and player initial position
    /// </summary>
    /// <obs>
    /// first line start in index 0 and stop in 100
    /// </obs>
    public void PopulateListDisplay()
    {
        for (int i = 0; i < 2000; i++)
        {
            this.display.Add(" ");
        }

        setNewPlayerPosition(0, player.PlayerSprite);
    }

    /// <summary>
    /// show display
    /// </summary>
    public void Start()
    {
        PopulateListDisplay();

        bool loop = true;
        while(loop is true)
        {   
            var inputKey = Console.ReadKey(false);
            renderDisplay(inputKey.Key);

            if( WinTimeAndGameOverCheck() == true)
            {
                break;
            }
        }
    }

    /// <summary>
    /// Populate list Display with white space
    /// </summary>
    /// <obs>
    /// first line start in index 0 and stop in 100
    /// </obs>
    private void renderDisplay(ConsoleKey key)
    {
        Console.Clear();
        MotionPlayer(key);

        foreach (var item in enemies)
        {
            setNewEnemyPosition(item);
        }

        int lineBreakCounter = 0;
        foreach(var item in this.display)
        {
            if (lineBreakCounter % 100==0)
            {
                Console.WriteLine("");
            }

            Console.Write(item);
            lineBreakCounter++;
        }

        WinTimeCount = WinTimeCount +1;
    }

    /// <summary>
    // check if player sprite is injured
    /// </summary>
    public bool WinTimeAndGameOverCheck()
    {
        if( WinTimeCount == 161)
        {
            Console.WriteLine("Vencedor");
            return true;
        }

        if(PlayerSpriteInjuredCheck() == true)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    // check if player sprite is injured
    /// </summary>
    public bool PlayerSpriteInjuredCheck()
    {
        foreach(var item in player.PlayerSprite)
        {
            if(this.display[player.Position+(item.Key)] == " ")
            {
                Console.Clear();
                GameOverAnimation();
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Update player position
    /// </summary>
    /// <param name="key"></param>
    public void MotionPlayer(ConsoleKey key)
    {
        if(key == ConsoleKey.RightArrow && player.Position < 1800-(player.LimiterRightSprite))
        {
            setNewPlayerPosition(+1, player.PlayerSprite);
        }

        if(key == ConsoleKey.LeftArrow && player.Position > 1700+(player.LimiterLeftSprite))
        {
            setNewPlayerPosition(-1, player.PlayerSprite);
        }
    }

    private void setNewPlayerPosition(int directionGuidance, Dictionary<int, string> playerSprite)
    {
        // clean player position
        foreach(var item in playerSprite)
        {
            this.display[player.Position+(item.Key)] = " ";
        }

        player.Position = player.Position+(directionGuidance);
        
        // set player position
        foreach(var item in playerSprite)
        {
            this.display[player.Position+(item.Key)] = item.Value;
        }
    }

    /// <summary>
    /// Update Enemy position
    /// </summary>
    /// <param name="enemySprite"></param>
    private void setNewEnemyPosition(ET enemy)
    {
        var random = new Random();

        if (enemy.Position >= 1780)
        {
            foreach(var item in enemy.enemySprite)
            {
                this.display[enemy.Position+(item.Key)] = " ";
            }

            enemy.Position = random.Next(0+(enemy.LimiterLeftSprite),100-(enemy.LimiterLeftSprite));
        }
        
        if(enemy.Position > 100)
        {
            foreach(var item in enemy.enemySprite)
            {
                this.display[enemy.Position+(item.Key)] = " ";
            }
        }

        enemy.Position = enemy.Position + random.Next(99,102);

        // set enemy position
        foreach(var item in enemy.enemySprite)
        {
            this.display[enemy.Position+(item.Key)] = item.Value;
        }
    }
}