using System;
using System.Collections.Generic;
using System.Linq;

namespace GOL_2019
{   
    public enum CELL_STATE {Empty, Dead, Alive}

    public class Cell
    {
        public CELL_STATE State;

        public Cell() { State = CELL_STATE.Empty; }
        public Cell(CELL_STATE state)
        {
          State = state;
        }
    }

    class GameLogic
    {              
        private int _gridSizeX, _gridSizeY;       
        private int _initialCells;

        private int _populatedCells;
        public Cell[,] Grid { get; private set; }            

        public List<Cell[,]> Generations;  // Each GameGrid (or "generation") is pushed here each iteration to save the entirety of the games progress.
        private Random random;

        public GameLogic(int gridSizeX, int gridSizeY, int initialCells)
        {
            _gridSizeX = gridSizeX;
            _gridSizeY = gridSizeY;
            Generations = new List<Cell[,]>();
            _initialCells = initialCells;
            _populatedCells = 0;
            Grid = new Cell[_gridSizeX, _gridSizeY];
            for (int y = 0; y < _gridSizeY; y++)
                for (int x = 0; x < _gridSizeX; x++)
                    Grid[x, y] = new Cell();

                    // Initial population
                    random = new Random();
            while(_populatedCells < _initialCells)
            {
                int x = random.Next(0, _gridSizeX);
                int y = random.Next(0, _gridSizeY);
                if (Grid[x, y].State == CELL_STATE.Empty)
                {
                    Grid[x, y].State = CELL_STATE.Alive;
                    _populatedCells++;
                }
            } 

            Generations.Add(Grid);
        }


        // Check for amount of neighbours
        private int CellHasNeighbours(Cell[,] grid, int x, int y)
        {
            int neighboursCount = 0;
            CELL_STATE state = CELL_STATE.Alive;

            // Top neighbours; we don't check these for cells on the top row.
            if (y != 0)
            {
                if (x != 0 && grid[x - 1, y - 1].State == state) neighboursCount++;              // Top-left
                if (grid[x, y - 1].State == state) neighboursCount++;                            // Top-center
                if (x != grid.GetLength(0) - 1 && grid[x + 1, y - 1].State == state) neighboursCount++;   // Top-right
            }

            // Left-right neighbours; we don't check for the cells on the very first or last index in a row.
            if (x != 0 && x != grid.GetLength(0) - 1)
            {
                if (grid[x - 1, y].State == state) neighboursCount++; // Left
                if (grid[x + 1, y].State == state) neighboursCount++; // Right
            }

            // Bottom neighbours; not checking for cells on the last row.
            if (y != grid.GetLength(1) - 1)
            {
                if (x != 0 && grid[x - 1, y + 1].State == state) neighboursCount++;              // Bottom-left
                if (grid[x, y + 1].State == state) neighboursCount++;                            // Bottom-center
                if (x != grid.GetLength(0) - 1 && grid[x + 1, y + 1].State == state) neighboursCount++;   // Bottom-right
            }

            return neighboursCount;
        }


        // Save current generation, calculate the next.
        public void Iterate()
        {

            int cellNeighbours;
            Cell[,] newGeneration = (Cell[,])Grid.Clone();
            Cell[,] cellsToAlter = (Cell[,])Grid.Clone();

            for (int y = 0; y < _gridSizeY; y++)
                for (int x = 0; x < _gridSizeX; x++)
                {
                    // Check the (up to) 8 immediately surrounding cells
                    cellNeighbours = CellHasNeighbours(newGeneration, x, y);

                    // Less than 2; die of loneliness, greater than 3; die of overpopulation.
                    if ((cellNeighbours < 2 || cellNeighbours > 3) && cellsToAlter[x, y].State == CELL_STATE.Alive)
                    {
                        cellsToAlter[x,y].State = CELL_STATE.Dead;
                    }

                    // Empty cell with 3; now a not-so-empty cell.
                    if ((newGeneration[x, y].State == CELL_STATE.Empty || newGeneration[x, y].State == CELL_STATE.Dead) && cellNeighbours == 3)
                    {
                        cellsToAlter[x,y].State = CELL_STATE.Alive;
                    }
                }
     
                newGeneration = cellsToAlter;
                
            Grid = newGeneration;
            Generations.Add(newGeneration);  // Save current generation before the next iteration
                                             // Används medans UI-delen inte är färdig. Project Settings -> Output type = Console
                                             //PrintToConsole(false);
        }
    }
}
