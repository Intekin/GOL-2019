using System;
using System.IO;
using System.Windows.Forms;
using DatabaseCL;
using System.Text.RegularExpressions;

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
            GameGrid.ClearSelection();
        }

        private void GameGrid_SelectionChanged(object sender, EventArgs e)
        {
          GameGrid.ClearSelection();
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            // Validate name to avoid SQL errors whilst saving   
            string name = tb_NameOfGame.Text;
            bool nameValidated = false;

            if (Regex.IsMatch(name, @"^[a-zA-Z0-9]+$") && name.Length > 1)
            {
              nameValidated = true; 
            }

            if (nameValidated)
            {
              gl = new GameLogic(name, 8, 16);
              gameView.UpdateGameView(gl.GameGrid, GameGrid);

              // Can't iterate without a GameLogic instance
              btn_NextGeneration.Enabled = true;
            }
            else
            {
              MessageBox.Show("The name must be 2 characters and can only consist of letters and numbers.");
            }
        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gl.Iterate();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            try {
                Class1 c = new Class1();
                c.TestDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_EndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
