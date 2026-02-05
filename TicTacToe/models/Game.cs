using System.Runtime.CompilerServices;

public class Game
{
    private List<Player> players;
    private Board board;
    private List<Move> moves;
    private int currentPlayerIndex;
    private  Player winner;
    private GameStatus status;
    private List<WinningStrategy> winningStrategies;

    //Builder Pattern for Game Initialization
   
    private Game(int dimension, List<Player> players, List<WinningStrategy> winningStrategies)
    {
        this.board = new Board(dimension);
        this.players = players;
        this.moves = new List<Move>();
        this.currentPlayerIndex = 0;
        this.status = GameStatus.IN_PROGRESS;
        this.winningStrategies = winningStrategies;
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

    public void makeMove()
    {
        // Placeholder for actual move-making logic
        // This method would contain logic to make a move in the game
        Player currentPlayer = players[currentPlayerIndex];
        Console.WriteLine("Current Player: " + currentPlayer.GetName());

        Move move = currentPlayer.makeMove(board);    

        if (!ValidateMove(move))
        {
            Console.WriteLine("Invalid move. Try again.");
            return;
            //throw new InvalidMoveException ("Invalid Move by player: " + currentPlayer.GetName());
            
        }
        int row = move.GetCell().GetRow();
        int col = move.GetCell().GetCol();
        Cell cell = board.GetBoardCell(row, col);
        //Cell cell = move.GetCell();
        cell.SetPlayer(currentPlayer);        
        cell.SetStatus(CellStatus.FILLED);
        moves.Add(move);
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;

        if(CheckWinner(move))
        {
            this.winner = currentPlayer;
            this.status = GameStatus.WIN;
        }
        else if (moves.Count == board.GetSize() * board.GetSize())
        {
            this.status = GameStatus.DRAW;  
        }
    }

    public Player getWinner()
    {
        return this.winner;
    }   
    private bool CheckWinner(Move move)
    {
        // Placeholder for winner checking logic
        // This method would contain logic to check if the current move wins the game
        foreach(WinningStrategy ws in winningStrategies)
        {
            if(ws.CheckWinner(board, move))
            {
                return true;
            }
        }
        return false;
    }
    private bool ValidateMove(Move move)
    {
        Cell cell = move.GetCell();
        // Placeholder for move validation logic
        int row = cell.GetRow();
        int col = cell.GetCol();
        if (row < 0 || row >= board.GetSize() || col < 0 || col >= board.GetSize()
        || board.GetBoardCell(row, col).GetStatus() != CellStatus.EMPTY)
        {
            return false;
        }
        return true;
    }

    public class GameBuilder
    {
    private List<Player> players;
    private int dimension;
    private List<WinningStrategy> winningStrategies;
    
    public Game Build()
        {
        ValidatePlayerCount(players);
        {
            return new Game(dimension, players, winningStrategies);
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
    public GameBuilder SetWinningStrategy(List<WinningStrategy> winningStrategies)
        {
            // Placeholder for setting winning strategy
            this.winningStrategies = winningStrategies;
            return this;
        }

    }
}