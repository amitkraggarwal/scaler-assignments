public class RowWinningStrategy : WinningStrategy
{
    private Dictionary<int, Dictionary<Symbol, int>> rowSymbolCountMap = new Dictionary<int, Dictionary<Symbol, int>>();
    public bool CheckWinner(Board board, Move currentMove)
    {
       int row = currentMove.GetCell().GetRow();
       int column = currentMove.GetCell().GetCol();

       Symbol symbol = currentMove.GetPlayer().GetSymbol();
     //  Symbol s = currentMove.GetPlayer().GetSymbol(); 

       if (!rowSymbolCountMap.ContainsKey(row))
       {
           rowSymbolCountMap.Add(row, new Dictionary<Symbol, int>());
           //rowCountMap[row] = new Dictionary<Symbol, int>();
       }
       Dictionary<Symbol, int> symbolCountMap = rowSymbolCountMap[row];
       if (!symbolCountMap.ContainsKey(symbol))
       {
              symbolCountMap.Add(symbol, 0);          
       }
      // var symbolCount = rowSymbolCountMap[row];
       symbolCountMap[symbol]++;
       rowSymbolCountMap[row] = symbolCountMap;
       if (rowSymbolCountMap[row][symbol] == board.GetSize())
       {
           return true;
       }
       return false;
    }
}