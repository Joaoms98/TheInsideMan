namespace TheInsideManConsoleApp.Entities.ScoreBoards;

public class ScoreStage2
{
    public int PlayerPoints { get; set; }
    public int EnemyPoints { get; set; }
    public int Round { get; set; }

    public Dictionary<int, string> layout { get; set; } = new Dictionary<int, string> {
        { -3, "╔═"},{ -2, "═"},{ -1, "═"},{ 0, "═"},{ 1,"═"},{ 2, "╗"},
        { 97, " "},{ 98, " "},{ 99, "0"},{ 100, "x"}, { 101, "0"},{ 102, " "},{ 103, " "},
        { 197, "╚"},{ 198, "═"},{ 199, "═"},{ 200, "═"}, { 201, "═"},{ 202, "═"},{ 203, "╝"}
    };
}