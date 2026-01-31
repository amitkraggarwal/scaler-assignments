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
/*

    

    public bool PlaceMark(int row, int col, char mark)
    {
        if (row < 0 || row >= Size || col < 0 || col >= Size || grid[row, col] != ' ')
        {
            return false;
        }

        grid[row, col] = mark;
        return true;
    }

    public char GetMark(int row, int col)
    {
        if (row < 0 || row >= Size || col < 0 || col >= Size)
        {
            throw new ArgumentOutOfRangeException();
        }

        return grid[row, col];
    }

    public bool IsFull()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (grid[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }
    */
}