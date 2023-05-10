using TheInsideManConsoleApp.Stages;

namespace TheInsideManConsoleApp;

public class App
{
    public void Run()
    {
        var stageI = new Stage1();
        var stageII = new Stage2();

        stageI.LogoAnimation();
        stageI.InstructionsAnimation();
        stageI.Show();
        stageII.Start();
    }
}
