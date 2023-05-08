namespace Game;

public class App
{
    public void Run()
    {
        var display = new Display();
        
        display.LogoAnimation();
        display.InstructionsAnimation();
        display.StageI();
    }
}
