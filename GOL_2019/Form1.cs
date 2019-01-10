using System;
using System.IO;
using System.Windows.Forms;
using DatabaseCL;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gl;
        GameView gameView;

        public Form1()
        {
            InitializeComponent();
            gameView = new GameView();    
            gameView.InitGameView(GameGrid);
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            gl = new GameLogic();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

            // Load gameLogic.GameGrid into GameGrid (DataGridView control)

        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gl.Iterate();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            try {
                Class1 c = new Class1();
                c.TestDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(projectDirectory);

        }

        private void btn_EndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
