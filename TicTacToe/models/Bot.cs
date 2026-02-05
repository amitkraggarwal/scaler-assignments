public class Bot : Player
{
    private BotDifficultyLevel difficultyLevel;
    private BotPlayingStrategy playingStrategy;

   public Bot(string name, Symbol symbol, BotDifficultyLevel difficultyLevel) 
                                                            : base(name, symbol)
   {
        this.difficultyLevel = difficultyLevel;
        this.SetPlayerType(PlayerType.BOT);
        this.playingStrategy = BotPlayingStrategyFactory.GetStrategy(this.difficultyLevel);

   }

     public override Move makeMove(Board board)
     {
      Move m =  playingStrategy.DecideMove(board);
        m.SetPlayer(this);
            return m;
     }
}