public class ColumnWinningStrategy : WinningStrategy
{
    private Dictionary<int, Dictionary<Symbol, int>> colSymbolCountMap = new Dictionary<int, Dictionary<Symbol, int>>();
    public bool CheckWinner(Board board, Move currentMove)
    {
       int row = currentMove.GetCell().GetRow();
       int column = currentMove.GetCell().GetCol();

       Symbol symbol = currentMove.GetPlayer().GetSymbol(); 

       if (!colSymbolCountMap.ContainsKey(column))
       {
           colSymbolCountMap.Add(column, new Dictionary<Symbol, int>());
           //rowCountMap[row] = new Dictionary<Symbol, int>();
       }
       Dictionary<Symbol, int> symbolCountMap = colSymbolCountMap[column];
       if (!symbolCountMap.ContainsKey(symbol))
       {
              symbolCountMap.Add(symbol, 0);          
       }
       symbolCountMap[symbol]++;
       if (colSymbolCountMap[column][symbol] == board.GetSize())
       {
           return true;
       }
       return false;
    }
}