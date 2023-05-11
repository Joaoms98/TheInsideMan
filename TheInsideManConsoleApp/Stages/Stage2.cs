using TheInsideManConsoleApp.Animations;
using TheInsideManConsoleApp.Entities.Cards;
using TheInsideManConsoleApp.Entities.ScoreBoards;

namespace TheInsideManConsoleApp.Stages;

public class Stage2 : Messages
{
    DeckOfTruco Deck = new DeckOfTruco();
    ScoreStage2 Scoreboard = new ScoreStage2(){};
    List<string> Display { get; set; } = new List<string>();
    List<Card> PlayerHand { get; set; } = new List<Card>();
    List<Card> EnemyHand { get; set; } = new List<Card>();
    int PointerPosition {get; set;} = 1374;

    /// <summary>
    /// Start game Stage2
    /// </summary>
    public void Start()
    {
        populateListDisplay();
        distributeCards();
        
        bool loop = true;
        while(loop is true)
        {   
            renderDisplay();

            var inputKey = Console.ReadKey();

            indicatorArrowAction(inputKey.Key);

            Console.Clear();

            if (VerifyWinnerOcurrence() == true)
            {
                break;
            }
        }
    }

    /// <summary>
    /// Populate list Display with white space and pointer indicator
    /// </summary>
    private void populateListDisplay()
    {
        for (int i = 0; i < 2000; i++)
        {
            Display.Add(" ");
        }

        Display[PointerPosition] = "⇩";
        Console.Clear();
    }

    /// <summary>
    /// shuffle the deck and deal the cards
    /// </summary>
    private void distributeCards()
    {
        Random rand = new Random();
        var DeckShuffled = Deck.Cards.OrderBy(d => rand.Next()).ToList();

        for (int i = 0; i < 3; i++)
        {
            PlayerHand.Add(DeckShuffled[i]);
            EnemyHand.Add(DeckShuffled[i+3]);
        }
    }

    /// <summary>
    /// Populate Display with player cards
    /// </summary>
    private void PlayerHandDisplaySet(List<Card> cards)
    {
        for (int i = 0; i < cards.Count(); i++)
        {
            foreach(var item in cards[i].Sprite)
            {
                Display[(1474+(10*i))+(item.Key)] = item.Value;
            }
        }
    }

    /// <summary>
    /// Populate Display with enemy cards
    /// </summary>
    private void EnemyHandDisplaySet(List<Card> cards)
    {
        for (int i = 0; i < cards.Count(); i++)
        {
            foreach(var item in Deck.Back.Sprite)
            {
                Display[(4+(10*i))+(item.Key)] = item.Value;
            }
        }
    }

    /// <summary>
    /// Populate Display with scoreboard
    /// </summary>
    private void ScoreboardDisplaySet(ScoreStage2 score)
    {
        foreach(var item in score.layout)
        {
            Display[195 +(item.Key)] = item.Value;
        }

        Display[294] = score.EnemyPoints.ToString();
        Display[296] = score.PlayerPoints.ToString();
    }

    /// <summary>
    /// Populate Display with table cards
    /// </summary>
    private void tableHandDisplaySet(Card playerRoundCard, Card enemyRoundCard)
    {
        foreach(var item in enemyRoundCard.Sprite)
        {
            Display[540+(item.Key)] = item.Value;
        }

        foreach(var item in playerRoundCard.Sprite)
        {
            Display[570+(item.Key)] = item.Value;
        }
    }

    /// <summary>
    /// show display
    /// </summary>
    private void renderDisplay()
    {
        PlayerHandDisplaySet(PlayerHand);
        EnemyHandDisplaySet(EnemyHand);
        ScoreboardDisplaySet(Scoreboard);

        int lineBreakCounter = 0;
        foreach(var item in this.Display)
        {
            if (lineBreakCounter % 100==0)
            {
                Console.WriteLine("");
            }

            Console.Write(item);
            lineBreakCounter++;
        }
    }

    private void indicatorArrowAction(ConsoleKey actionKey)
    {
        if(actionKey == ConsoleKey.RightArrow && PlayerHand.Count() == 3 && PointerPosition < 1394
            || actionKey == ConsoleKey.RightArrow && PlayerHand.Count() == 2 && PointerPosition + 10 < 1394)
        {
            Display[PointerPosition] = " ";
            PointerPosition = PointerPosition +10;
            Display[PointerPosition] = "⇩";
        }

        if(actionKey == ConsoleKey.LeftArrow && PointerPosition > 1374)
        {
            Display[PointerPosition] = " ";
            PointerPosition = PointerPosition -10;
            Display[PointerPosition] = "⇩";
        }
        
        if(actionKey == ConsoleKey.Enter && PlayerHand.Count() > 0)
        {
            PlayerCardDown();
        }

        if(actionKey == ConsoleKey.J && PlayerHand.Count() == 0)
        {
            nextRound();
            Display[PointerPosition] = " ";
            PointerPosition = 1374;
            Display[PointerPosition] = "⇩";
        }
    }

    private void PlayerCardDown()
    {
        cleanDisplay();

        var enemyRoundCard = EnemyHand.LastOrDefault();
        EnemyHand.Remove(enemyRoundCard);
        Card playerRoundCard = pointerCardIndicator();

        CalculateWinRound(playerRoundCard,enemyRoundCard);
        tableHandDisplaySet(playerRoundCard, enemyRoundCard);
        
        Display[PointerPosition] = "Pressione J para continuar";

        if(PlayerHand.Count() > 0)
        {
            Display[PointerPosition] = " ";
            PointerPosition = 1374;
            Display[PointerPosition] = "⇩";
        }

        Scoreboard.Round = Scoreboard.Round+1;
    }

    private void CalculateWinRound(Card playerRoundCard, Card enemyRoundCard)
    {
        if(playerRoundCard.TrucoPower > enemyRoundCard.TrucoPower)
        {
            Display[453] = "Ganhou";
            
            Scoreboard.PlayerPoints = Scoreboard.PlayerPoints + 1;

            if(Scoreboard.Round == 1)
            {
                Scoreboard.PlayerPoints = Scoreboard.PlayerPoints + 1;
            }

        }
        else if(playerRoundCard.TrucoPower == enemyRoundCard.TrucoPower){
            Display[453] = "Empatou";
        }else{
            Display[453] = "Perdeu";
            Scoreboard.EnemyPoints = Scoreboard.EnemyPoints + 1;

            if(Scoreboard.Round == 1)
            {
                Scoreboard.EnemyPoints = Scoreboard.EnemyPoints + 1;
            }
        }
    }

    private Card pointerCardIndicator()
    {
        switch(PointerPosition)
        {
            case 1374:
                Card cardPosition1 = PlayerHand[0];
                PlayerHand.Remove(PlayerHand[0]);
                return cardPosition1;
            case 1384:
                Card cardPosition2 = PlayerHand[1];
                PlayerHand.Remove(PlayerHand[1]);
                return cardPosition2;
            case 1394:
                Card cardPosition3 = PlayerHand[2];
                PlayerHand.Remove(PlayerHand[2]);
                return cardPosition3;
            default:
                throw new Exception("Onde está seu ponteiro?");
        }
    }

    private bool VerifyWinnerOcurrence()
    {
        if(Scoreboard.PlayerPoints > 12 || Scoreboard.EnemyPoints > 12)
        {
            if(Scoreboard.PlayerPoints > 12)
            {
                return true;
            }else{
                this.GameOverAnimation();
                return true;
            }
        }

        return false;
    }

    private void cleanDisplay()
    {
        for (int i = 0; i < 2000; i++)
        {
            this.Display[i] = " ";
        }   
    }

    private void nextRound()
    {
        Scoreboard.Round = 0;
        cleanDisplay();
        distributeCards();
    }
}
