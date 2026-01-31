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
    
}