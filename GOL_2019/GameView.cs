using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_2019
{
    class GameView
    {
        int columns;
        int rows;

        public void InitGameView(DataGridView gameGrid, int numCol, int numRow)
        {
            columns = numCol;
            rows = numRow;

            gameGrid.Rows.Clear();
            gameGrid.Columns.Clear();

            gameGrid.AutoGenerateColumns = false;
            gameGrid.RowTemplate.Height = gameGrid.Height/ rows; //Can only set the height before the creation of the grid.

            gameGrid.Enabled = false;
            gameGrid.RowHeadersVisible = false;
            gameGrid.ColumnHeadersVisible = false;
            for (int i = 1; i <= columns; i++)
            {
                gameGrid.Columns.Add("col" + i, "column " + i);
                gameGrid.Columns[i - 1].Width = gameGrid.Width/ columns; //Can only seth the width of columns during its creation
            }
            for (int j = 0; j < rows; j++)
            {
                gameGrid.Rows.Add();
            }
            gameGrid.CurrentCell = null;
        }
        public void UpdateGameView(int[,] currentGeneration, DataGridView gameGrid)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (currentGeneration[i, j] == 1)
                        gameGrid[i, j].Style.BackColor = Color.Black;
                    else
                        gameGrid[i, j].Style.BackColor = Color.White;
                }
        }
    }
}
