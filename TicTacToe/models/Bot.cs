public class Bot : Player
{
    private BotDifficultyLevel difficultyLevel;

   public Bot(string name, Symbol symbol, BotDifficultyLevel difficultyLevel) 
                                                            : base(name, symbol)
   {
        this.difficultyLevel = difficultyLevel;
        this.SetPlayerType(PlayerType.BOT);
   }
}