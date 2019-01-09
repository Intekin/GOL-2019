using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_2019
{
  public partial class Form1 : Form
  {
    GameLogic gameLogic;

        public Form1()
        {
            InitializeComponent();

            GameLogic gl = new GameLogic(8,10);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 25;
            for (int i = 1; i <= 8; i++)
            {
                dataGridView1.Columns.Add("col" + i, "column " + i);
                dataGridView1.Columns[i - 1].Width = 25;
            }
            for (int j = 0; j < 8; j++)
            {
                dataGridView1.Rows.Add();
            }


            for(int i = 0; i < 8;i++)
                for(int j = 0; j < 8; j++)
                {
                    if (gl.GameGrid[i, j] == 1)
                        dataGridView1[i, j].Style.BackColor = Color.Black;
                }
        }

    private void btn_StartNewGame_Click(object sender, EventArgs e)
    {
      gameLogic = new GameLogic();

      // Load gameLogic.GameGrid into GameGrid (DataGridView control)

    }

    private void btn_NextGeneration_Click(object sender, EventArgs e)
    {
      // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
      gameLogic.Iterate();

    }
}
