namespace Game;

public class App
{
    public void Run()
    {
        var display = new Display();
        
        do
        {
            display.LogoAnimation();
        }while(Console.ReadKey().Key != ConsoleKey.Enter);

        do
        {
            display.Instructions();
        }while(Console.ReadKey().Key != ConsoleKey.Enter);

        display.InsertValues();

        bool loop = true;
        int frameCount = 0;
        
        while(loop is true)
        {
            var inputKey = display.ShowFirstScenery();
            display.MotionPlayer(inputKey.Key);
            display.MotionEnemy(frameCount);

            if(display.PlayerSpriteInjuredCheck() == true)
            {
                Console.Clear();
                display.GameOver();
                Console.Beep();
                break;
            }

            if(frameCount == 7)
            {
                frameCount = 0;
            }
            
            frameCount ++;
        }
    }
}
