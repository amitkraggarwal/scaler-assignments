public class Player
{
    private string Name ;
    private Symbol Symbol;
    private PlayerType playerType;

    public Player(string name, Symbol symbol)
    {
        this.Name = name;
        this.Symbol = symbol;
    }
    public PlayerType SetPlayerType(PlayerType playerType)
    {
        this.playerType = playerType;
        return this.playerType;
    }
    public Symbol GetSymbol()
    {
        return this.Symbol;
    }
    public string GetName()
    {
        return this.Name;
    }   
    public virtual Move makeMove(Board board)
    {
        // Placeholder for actual move-making logic
        // This method would contain logic for the player to make a move on the board
        Console.WriteLine("Enter row for making a move.");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter column for making a move.");
        int col = Convert.ToInt32(Console.ReadLine());  
        return new Move(this, new Cell(row, col));

    }
}