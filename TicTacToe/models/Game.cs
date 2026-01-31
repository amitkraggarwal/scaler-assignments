using System.Runtime.CompilerServices;

public class Game
{
    private List<Player> players;
    private Board board;
    private List<Move> moves;
    private int currentPlayerIndex;
    private Player winner;
    private GameStatus status;

    //Builder Pattern for Game Initialization
   
    private Game(int dimension, List<Player> players)
    {
        this.board = new Board(dimension);
        this.players = players;
        this.moves = new List<Move>();
        this.currentPlayerIndex = 0;
        this.winner = null; 
        this.status = GameStatus.IN_PROGRESS;
        
    }
    
    public static GameBuilder GetBuilder()
    {
        return new GameBuilder();
    }

    public GameStatus GetStatus()
    {
        return status;
    }

    public void printBoard()
    {
        board.printBoard();
    }

    public class GameBuilder
    {
    private List<Player> players;
    private int dimension;
    
    public Game Build()
        {
        ValidatePlayerCount(players);
        {
            return new Game(dimension, players);
        }
        
        }

private void ValidatePlayerCount(List<Player> players)
    {
        if (players.Count < 2)
        {
            throw new Exception("At least two players are required to start the game.");
        }
    }
    public GameBuilder SetPlayers(List<Player> players)
        {
            this.players = players;
            return this;
        }
    public GameBuilder SetDimension(int dimension)
        {
            this.dimension = dimension;
            return this;
        }


    }
}