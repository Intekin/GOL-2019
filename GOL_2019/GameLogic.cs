using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class GameLogic
    {
        public int[,] GameGrid { get; private set; }           // Current state of the game or "generation".
        private int GridSize;             // Height & width of the square game grid. Ex; 8 = 8*8 grid with 64 cells.
        private int InitialCells;
        public int PopulatedCells { get; private set; }

        public List<int[,]> Generations;  // Each GameGrid (or "generation") is pushed here each iteration to save the entirety of the games progress.
        private Random random;

        public GameLogic(int gridSize = 8, int initialCells = 16)
        {
            GridSize = gridSize;
            Generations = new List<int[,]>();
            InitialCells = initialCells;
            PopulatedCells = 0;
            GameGrid = new int[GridSize, GridSize];

            // Initial population
            random = new Random();
            do
            {
                int x = random.Next(0, GridSize);
                int y = random.Next(0, GridSize);
                if (GameGrid[y, x] < 1)
                {
                    GameGrid[y, x] = 1;
                    PopulatedCells++;
                }
            } while (PopulatedCells < InitialCells);

            Generations.Add(GameGrid);
            // Används medans UI-delen inte är färdig. Project Settings -> Output type = Console
            //PrintToConsole();
        }


        // Check for amount of neighbours
        private int CellHasNeighbours(int[,] grid, int x, int y)
        {
            int neighboursCount = 0;

            // Top neighbours; we don't check these for cells on the top row.
            if (y != 0)
            {
                if (x != 0 && grid[x - 1, y - 1] > 0) neighboursCount++;              // Top-left
                if (grid[x, y - 1] > 0) neighboursCount++;                            // Top-center
                if (x != grid.GetLength(0) - 1 && grid[x + 1, y - 1] > 0) neighboursCount++;   // Top-right
            }

            // Left-right neighbours; we don't check for the cells on the very first or last index in a row.
            if (x != 0 && x != grid.GetLength(0) - 1)
            {
                if (grid[x - 1, y] > 0) neighboursCount++; // Left
                if (grid[x + 1, y] > 0) neighboursCount++; // Right
            }

            // Bottom neighbours; not checking for cells on the last row.
            if (y != grid.GetLength(1) - 1)
            {
                if (x != 0 && grid[x - 1, y + 1] > 0) neighboursCount++;              // Bottom-left
                if (grid[x, y + 1] > 0) neighboursCount++;                            // Bottom-center
                if (x != grid.GetLength(0) - 1 && grid[x + 1, y + 1] > 0) neighboursCount++;   // Bottom-right
            }

            return neighboursCount;
        }


        // Save current generation, calculate the next.
        public void Iterate()
        {

            int cellNeighbours;
            int[,] newGeneration = (int[,])GameGrid.Clone();

            for (int y = 0; y < GridSize; y++)
                for (int x = 0; x < GridSize; x++)
                {
                    // Check the (up to) 8 immediately surrounding cells
                    cellNeighbours = CellHasNeighbours(newGeneration, x, y);

                    // Less than 2; die of loneliness, greater than 3; die of overpopulation.
                    if (cellNeighbours < 2 || cellNeighbours > 3)
                    {
                        newGeneration[x, y] = 0;
                        PopulatedCells--;
                    }

                    // Empty cell with 3; now a not-so-empty cell.
                    if (newGeneration[x, y] == 0 && cellNeighbours == 3)
                    {
                        newGeneration[x, y] = 1;
                        PopulatedCells++;
                    }
                }

            GameGrid = newGeneration;
            Generations.Add(newGeneration);  // Save current generation before the next iteration
                                             // Används medans UI-delen inte är färdig. Project Settings -> Output type = Console
                                             //PrintToConsole(false);
        }


        // Alternate form of displaying output. Project Settings -> Output type = Console will open a console window alongside the WinForm
        public void PrintToConsole(bool clearConsole = true)
        {
            // Unless we pass false, we clear the console before printing the current generation.
            if (clearConsole) Console.Clear();

            Console.WriteLine($"----- Printing {GridSize}*{GridSize} grid ({Math.Pow(GridSize, 2)} cells). Generation: {Generations.Count()}, Cells: {PopulatedCells} -----");
            string row = "";
            for (int y = 0; y < GridSize; y++)
            {
                Console.WriteLine("--------------------------------------------------------");
                for (int x = 0; x < GridSize; x++)
                {
                    row += $" | {GameGrid[x, y]} |";
                    if (x != GridSize) row += " ";
                }
                Console.WriteLine(row);
                row = "";
            }
        }
    }
}
