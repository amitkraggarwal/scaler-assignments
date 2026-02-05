public class Board
{
private int size;
private Cell[,] grid;


    public Board(int dimension) 
    {
        this.size=dimension;
        grid = new Cell[size, size];    

        InitializeBoard();
    }

private void InitializeBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
               Cell cell = new Cell(i, j);
              // cell.SetStatus(CellStatus.EMPTY);
                grid[i, j] = cell;
            }
        }
    }

public void printBoard()
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Cell cell = grid[i, j];
            if (cell.GetStatus() == CellStatus.EMPTY)
            {
                System.Console.Write("|   ");
            }
            else
            {
                System.Console.Write("| " + cell.GetPlayer().GetSymbol().GetSymbol() + " ");
            }
        }
        System.Console.WriteLine("|");
        System.Console.WriteLine("--------");
    }
}
public int GetSize()
{
    return this.size;
}
public Cell GetBoardCell(int row, int col)
{
    return grid[row, col];
}

    
    
    public List<Cell> GetEmptyCells()
    {
        List<Cell> emptyCells = new List<Cell>();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (grid[i, j].GetStatus() == CellStatus.EMPTY)
                {
                    emptyCells.Add(grid[i, j]);
                }
            }
        }
        return emptyCells;
    }           
                
}