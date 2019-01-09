using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_2019
{
    class GameView
    {
        int rowHeight;
        int columnWidth;

        public void SetWidth(int width)
        {
            columnWidth = width;
        }

        public void SetHeight(int height)
        {
            rowHeight = height;
        }

        public void InitGameView()
        {
            GameGrid.AutoGenerateColumns = false;
            GameGrid.RowTemplate.Height = rowHeight;
            GameGrid.Columns.Width = columnWidth;
            for (int i = 1; i <= 8; i++)
            {
                GameGrid.Columns.Add("col" + i, "column " + i);
                GameGrid.Columns[i - 1].Width = 25;
            }
            for (int j = 0; j < 8; j++)
            {
                GameGrid.Rows.Add();
            }


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (gl.GameGrid[i, j] == 1)
                        GameGrid[i, j].Style.BackColor = Color.Black;
                }
        }
    }
}
