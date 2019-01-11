using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DatabaseCL;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Linq;
using System.Timers;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gl;
        GameView gameView;
        GameData currentGame;
        BindingList<GameData> gameDatas;

        public Form1()
        {
            InitializeComponent();
            gameView = new GameView();
            gameView.InitGameView(GameGrid);
            GameGrid.ClearSelection();



            // Databinding
            gameDatas = new BindingList<GameData>();
            lbx_SavedGames.DataSource = gameDatas;

            gameDatas = LoadGame.LoadAll();
            lbx_SavedGames.DataSource = gameDatas;
        }

        private void GameGrid_SelectionChanged(object sender, EventArgs e)
        {
            GameGrid.ClearSelection();
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            // Can't iterate without a GameLogic instance
            btn_NextGeneration.Enabled = true;

            gl = new GameLogic();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

            currentGame = new GameData();
            currentGame.Generations = gl.Generations;
        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gl.Iterate();
 
            gameView.UpdateGameView(gl.GameGrid, GameGrid);

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            try
            {
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
                // Validate name to avoid SQL errors whilst saving
                string name = tb_NameOfGame.Text;
                bool nameValidated = false;
                if (Regex.IsMatch(name, @"^[a-zA-Z0-9]+$") && name.Length >= 2) nameValidated = true;

                if (nameValidated)
                {
                    currentGame.Name = name;
                    if (gameDatas.Any(x => x.Name == currentGame.Name))
                    {
                        MessageBox.Show("You need to give your save a unique name: " + currentGame.Name);
                        return;
                    }

                    // This needs to change
                    gameDatas.Add(currentGame);
                    SaveGame.SaveAll(gameDatas);
                }
                else
                {
                    MessageBox.Show("The name must be 2 characters and can only consist of letters and numbers.");
                }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Load_Click(object sender, EventArgs eventArgs)
        {
            // Disable loading until the current loaded save is done animating.
            btn_Load.Enabled = false;
            GameData gd = (GameData)lbx_SavedGames.SelectedItem;

            // 
            int generationIndex = 0;
            System.Timers.Timer timer = new System.Timers.Timer();

            timer.Elapsed += new ElapsedEventHandler(delegate (object o, ElapsedEventArgs e)
            {
              if (generationIndex < gd.Generations.Count)
              {
                  Console.WriteLine($"Gen: {generationIndex} / {gd.Generations.Count - 1}");
                  gameView.UpdateGameView(gd.Generations[generationIndex], GameGrid);
                  generationIndex++;
              } else
              {
                timer.Stop();
                btn_Load.Enabled = true;
              }
            });

            timer.Interval = 1000;
            timer.Enabled = true;

            // Can't iterate without a GameLogic instance
            //gl = new GameLogic();
            //btn_NextGeneration.Enabled = true;
        }


        public void btn_Delete_Click(object sender, EventArgs e)
        {
            
        }

        public void lbx_SavedGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
