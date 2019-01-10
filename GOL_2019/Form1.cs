using System;
using System.Collections.Generic;
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
        List<GameData> gameDatas;

        public Form1()
        {
            InitializeComponent();
            gameView = new GameView();
            gameView.InitGameView(GameGrid);
            GameGrid.ClearSelection();
            gameDatas = new List<GameData>();
            
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


            // Can't iterate without a GameLogic instance
            btn_NextGeneration.Enabled = true;

            GameData gd = new GameData();
            gd.Name = name;

            gameDatas.Add(gd);

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

            lbx_SavedGames.Items.Clear();
            foreach(GameData data in gameDatas)
            lbx_SavedGames.Items.Add(data.Name);
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
                DbManager.TestDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_SaveGame_Click(object sender, EventArgs e)
        {
            try
            {
                SaveGame.SaveAll(gameDatas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

    
        public void btn_Delete_Click(object sender, EventArgs e)
        {
          // Kommenterade bara ut för att kunna kompilera och pusha.
          /*
            GOL b = new GOL();
            var Id = b.GOL_Id;

            DbManager a = new DbManager();
            var Load = a.LoadFromDb();

            List<GOL> DELETE = Load;
            lbx_SavedGames.DataSource = DELETE;
            DELETE.Remove((GOL)lbx_SavedGames.SelectedValue);
          */
        }

        public void lbx_SavedGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
