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
