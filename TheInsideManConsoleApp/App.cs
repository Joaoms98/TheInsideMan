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
        stageI.Text1Animation();
        stageI.Start();
        stageII.Text2Animation();
        stageII.Start();
        stageII.Text2Animation();
    }
}
