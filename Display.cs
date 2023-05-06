using Game.Animation;
using Game.Models;
using Game.Models.Enemies;

namespace Game;

public class Display
{
    private List<string> display { get; set; } = new List<string>();
    private int positionPlayer { get; set; } = 520;
    private int positionEnemy { get; set; } = 40;
    private Player player = new Player();
    private NormalEnemy enemy = new NormalEnemy();
    private Messages messages = new Messages();

    /// <summary>
    /// Populate list display with white space and player initial position
    /// </summary>
    /// <obs>
    /// lines start in index: 0, 80, 160, 240, 320, 400, 480, 560, 640, 720
    /// </obs>
    public void InsertValues()
    {
        for (int i = 0; i < 720; i++)
        {
            this.display.Add(" ");
        }

        setNewPlayerPosition(0, player.PlayerSprite);
    }

    public void LogoAnimation()
    {
        Console.WriteLine(messages.Logo);
    }

    public void Instructions()
    {
        Console.WriteLine(messages.Instructions);
    }

    public void GameOver()
    {
        Console.WriteLine(messages.GameOver);
    }

    /// <summary>
    /// show display
    /// </summary>
    public ConsoleKeyInfo ShowFirstScenery()
    {
        int counter = 0;
        foreach(var item in this.display)
        {
            if (counter == 80 || counter == 160 || counter == 240 || counter == 320 || counter == 400 || counter == 480 || counter == 560 || counter == 640 || counter == 720 || counter == 800)
            {
                Console.WriteLine("");
            }

            Console.Write(item);
            counter++;
        }
        
        var inputKey = Console.ReadKey(true);
        Console.Clear();

        return inputKey;
    }

    /// <summary>
    // check if player sprite is injured
    /// </summary>
    public bool PlayerSpriteInjuredCheck()
    {
        foreach(var item in player.PlayerSprite)
        {
            if(this.display[positionPlayer+(item.Key)] == " ")
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
        if(key == ConsoleKey.RightArrow && positionPlayer < 560-(player.LimiterRightSprite))
        {
            setNewPlayerPosition(+1, player.PlayerSprite);
        }

        if(key == ConsoleKey.LeftArrow && positionPlayer > 480+(player.LimiterLeftSprite))
        {
            setNewPlayerPosition(-1, player.PlayerSprite);
        }
    }

    private void setNewPlayerPosition(int directionGuidance, Dictionary<int, string> playerSprite)
    {
        // clean player position
        foreach(var item in playerSprite)
        {
            this.display[positionPlayer+(item.Key)] = " ";
        }

        positionPlayer = positionPlayer+(directionGuidance);
        
        // set player position
        foreach(var item in playerSprite)
        {
            this.display[positionPlayer+(item.Key)] = item.Value;
        }
    }


    /// <summary>
    /// Update Enemy position
    /// </summary>
    /// <param name="frameCount"></param>
    public void MotionEnemy(int frameCount)
    {
        setNewEnemyPosition(frameCount, enemy.enemySprite);
    }

    private void setNewEnemyPosition(int frameCount, Dictionary<int, string> enemySprite)
    {
        if (frameCount == 7)
        {
            foreach(var item in enemySprite)
            {
                this.display[positionEnemy+(item.Key)] = " ";
            }

            var randon = new Random();
            positionEnemy = randon.Next(0+(enemy.LimiterLeftSprite),80-(enemy.LimiterLeftSprite));
        }
        
        if(frameCount > 0)
        {
            foreach(var item in enemySprite)
            {
                this.display[positionEnemy+(item.Key)] = " ";
            }
        }

        positionEnemy = positionEnemy + 80;

        // set enemy position
        foreach(var item in enemySprite)
        {
            this.display[positionEnemy+(item.Key)] = item.Value;
        }
    }
}
