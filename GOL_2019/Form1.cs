using System;
using System.Collections.Generic;
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
            GameGrid.ClearSelection();
        }

        private void GameGrid_SelectionChanged(object sender, EventArgs e)
        {
          GameGrid.ClearSelection();
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            gl = new GameLogic();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

            // Can't iterate without a GameLogic instance
            btn_NextGeneration.Enabled = true;
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
    
        public void btn_Delete_Click(object sender, EventArgs e)
        {
            GOL b = new GOL();
            var Id = b.GOL_Id;

            Class1 a = new Class1();
            var Load = a.LoadFromDb();

            List<GOL> DELETE = Load;
            lbx_SavedGames.DataSource = DELETE;
            DELETE.Remove((GOL)lbx_SavedGames.SelectedValue);
        }

        public void lbx_SavedGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
