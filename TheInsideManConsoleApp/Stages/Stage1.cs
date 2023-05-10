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
        new ET(68),new ET(79),new ET(86),new ET(89)
    };

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
    public void Show()
    {
        Console.Clear();
        PopulateListDisplay();

        bool loop = true;
        while(loop is true)
        {
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
            
            var inputKey = Console.ReadKey(false);
            Console.Clear();
            MotionPlayer(inputKey.Key);

            foreach (var item in enemies)
            {
                setNewEnemyPosition(item);
            }

            if(PlayerSpriteInjuredCheck() == true)
            {
                Console.Clear();
                GameOverAnimation();
                Console.Beep();
                break;
            }
        }
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