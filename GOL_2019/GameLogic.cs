using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
  class GameLogic
  {
    public int[,] GameGrid;           // Current state of the game or "generation".
    private int GridSize;             // Height & width of the square game grid. Ex; 8 = 8*8 grid with 64 cells.
    public List<int[,]> Generations;  // Each GameGrid (or "generation") is pushed here each iteration to save the entirety of the games progress.
    public int InitialCells;
    public int PopulatedCells;
    private Random random;

    public GameLogic(int gridSize = 8, int initialCells = 10)
    {
      GridSize = gridSize;
      Generations = new List<int[,]>();
      InitialCells = initialCells;
      PopulatedCells = 0;
      GameGrid = new int[GridSize, GridSize];

      // Initial population
      random = new Random();
      do {
        int x = random.Next(0, GridSize);
        int y = random.Next(0, GridSize);
        if (GameGrid[y, x] < 1)
        {
          GameGrid[y, x] = 1;
          PopulatedCells++;
        }
      } while (PopulatedCells < InitialCells);

    }

    // Check for amount of neighbours
    private int CellHasNeighbours(int cellX, int cellY)
    {
      int neighboursCount = 0;

      // Not actually tested, need the code for displaying cells in the DataGridView
      // Should (note: should) be index-out-of-range proof.

      // If we're on the first row (y = 0) we can't have any cells above us.
      if (cellY < 1)
      {
        if (GameGrid[cellY - 1, cellX - 1] > 0) neighboursCount++;  // Top-left
        if (GameGrid[cellY - 1, cellX] > 0) neighboursCount++;      // Top-center
        if (GameGrid[cellY - 1, cellX + 1] > 0) neighboursCount++;  // Top-right
      }

      // If x is equal to the gridsize, we're on the right edge and can't have any cells to the right.
      if (cellX != GridSize)
      {
        if (GameGrid[cellY, cellX + 1] > 0) neighboursCount++;      // Right
      }

      // If y is equal to the gridsize, we're at the bottom and can't have any cells below us.
      if (cellY != GridSize)
      {
        if (GameGrid[cellY + 1, cellX + 1] > 0) neighboursCount++;  // Bottom-right
        if (GameGrid[cellY + 1, cellX] > 0) neighboursCount++;      // Bottom-center
        if (GameGrid[cellY + 1, cellX - 1] > 0) neighboursCount++;  // Bottom-left
      }

      // If x is less than one, we're along the left edge and cannot have any cells to the left.
      if (cellX < 1)
      {
        if (GameGrid[cellY, cellX - 1] > 0) neighboursCount++;      // Left
      }

      return neighboursCount;
    }


    public void Iterate()
    {
      int cellNeighbours;
      Generations.Add(GameGrid);  // Save current generation before overwriting GameGrid with the new.

      for (int y = 0; y < GridSize; y++)
      {
        for(int x = 0; x < GridSize; x++)
        {
          // We need to check the 8 immediately surrounding cells
          cellNeighbours = CellHasNeighbours(x, y);

          // Empty cell with 3; now a not-so-empty cell.
          if (GameGrid[x, y] > 0 && cellNeighbours == 3)
          {
            GameGrid[x, y] = 1;
            PopulatedCells++;
          }
          
          // Less than 2; die of loneliness, greater than 3; die of overpopulation.
          if (cellNeighbours < 2 || cellNeighbours > 3)
          {
            GameGrid[x, y] = 0;
            PopulatedCells--;
          }
        }
      }
    }

  }
}
