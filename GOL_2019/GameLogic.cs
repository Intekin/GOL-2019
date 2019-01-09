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
    private int cellHasNeighbours(int cellX, int cellY)
    {
      int neighboursCount = 0;


      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;  // Top-left
      if (GameGrid[cellY - 1, cellX] < 1) neighboursCount++;       // Top-center
      if (GameGrid[cellY - 1, cellX + 1] < 1) neighboursCount++;  // Top-right
      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;  // Right
      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;
      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;
      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;
      if (GameGrid[cellY - 1, cellX - 1] < 1) neighboursCount++;


      return neighboursCount;
    }

    public void Iterate()
    {
      for(int y = 0; y < GridSize; y++)
      {
        for(int x = 0; x < GridSize; x++)
        {
          // We need to check the 8 immediately surrounding cells



        }
      }
      Generations.Add(GameGrid);
    }

  }
}
