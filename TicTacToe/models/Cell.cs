public class Cell
{
    private int row;
    private int column;
    private CellStatus status;
    private Player player;
//    private Player player;
    public Cell(int row, int column)
    {
        this.row = row;
        this.column = column;
        this.status = CellStatus.EMPTY;
    }

    public CellStatus GetStatus()
     {  return status;   }

    
    public void SetStatus(CellStatus status)
    {
        this.status = status;
    }
    public int GetRow()
    {
        return this.row;
    }
    public int GetCol()
    {
        return this.column;
    }  
    public void SetPlayer(Player player)
    {
        this.player = player;
    }
    public Player GetPlayer()
    {
        return this.player;
    }
    
}