using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCL;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gl;

        public Form1()
        {
            InitializeComponent();

            gl = new GameLogic(8, 10);

            GameGrid.AutoGenerateColumns = false;
            GameGrid.RowTemplate.Height = 25;
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

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            gl = new GameLogic();

            // Load gameLogic.GameGrid into GameGrid (DataGridView control)

        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gl.Iterate();

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.TestDb();
        }
    }
}
