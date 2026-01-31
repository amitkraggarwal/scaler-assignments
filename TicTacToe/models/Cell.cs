public class Cell
{
    private int row;
    private int column;
    private CellStatus status;
    private Player player;
    public Cell(int row, int column)
    {
        this.row = row;
        this.column = column;
        this.status = CellStatus.EMPTY;
    }

    public CellStatus GetStatus()
     {  return status;   }

    public Player GetPlayer()
    {
        return player;
    }
    public void SetStatus(CellStatus status)
    {
        this.status = status;
    }
}