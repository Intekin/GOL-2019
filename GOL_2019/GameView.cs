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
        int rowHeight = 35;
        int columnWidth = 35;
        int numOfColumns = 8;
        int numOfRows = 8; 

        public void SetWidth(int width)
        {
            columnWidth = width;
        }

        public void SetHeight(int height)
        {
            rowHeight = height;
        }

        public void InitGameView(DataGridView GameGrid)
        {
            GameGrid.AutoGenerateColumns = false;
            GameGrid.RowTemplate.Height = rowHeight; //Can only set the height before the creation of the grid.


            GameGrid.Enabled = false;
            GameGrid.RowHeadersVisible = false;
            GameGrid.ColumnHeadersVisible = false;
            for (int i = 1; i <= numOfColumns; i++)
            {
                GameGrid.Columns.Add("col" + i, "column " + i);
                GameGrid.Columns[i - 1].Width = columnWidth; //Can only seth the width of columns during its creation
            }
            for (int j = 0; j < numOfRows; j++)
            {
                GameGrid.Rows.Add();
            }
            GameGrid.CurrentCell = null;
        }
        public void UpdateGameView(int[,] currentGeneration, DataGridView GameGrid)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (currentGeneration[i, j] == 1)
                        GameGrid[i, j].Style.BackColor = Color.Black;
                    else
                        GameGrid[i, j].Style.BackColor = Color.White;

                }
        }
    }
}
