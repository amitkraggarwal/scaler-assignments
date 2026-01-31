public class GameController
{
    public Game StartGame(int dimension, List<Player> players)
    {
        // Implementation for starting a new game
        return new Game.GameBuilder()
            .SetDimension(dimension)
            .SetPlayers(players)
            .Build();
    }

    public void printBoard(Game game)
    {
        game.printBoard();
    }
}