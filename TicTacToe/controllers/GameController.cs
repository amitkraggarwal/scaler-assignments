public class GameController
{
    public Game StartGame(int dimension, List<Player> players, List<WinningStrategy> winningStrategies = null)
    {
        // Implementation for starting a new game
        return new Game.GameBuilder()
            .SetDimension(dimension)
            .SetPlayers(players)
            .SetWinningStrategy(winningStrategies)
            .Build();
    }

    public void printBoard(Game game)
    {
        game.printBoard();
    }
    public void makeMove(Game game)
    {
        // Implementation for making a move in the game
        // This is a placeholder for actual move-making logic
        game.makeMove();
    }
}