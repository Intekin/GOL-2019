﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DatabaseCL;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Linq;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gl;
        GameView gameView;
        GameData currentGame;
        GameSettings settings = new GameSettings();
        BindingList<GameData> gameDatas;


        public Form1()
        {
            InitializeComponent();
            gameView = new GameView();
            gameView.InitGameView(GameGrid);
            
            // Databinding Listbox
            gameDatas = LoadGame.LoadAll();
            gameDatas = new BindingList<GameData>();
            lbx_SavedGames.DataSource = gameDatas;

            //DataSource comboBox with Enum.
            cb_GameMode.DataSource = Enum.GetValues(typeof(GameSettings.GAMEMODE));
            cb_GameMode.SelectedItem = settings.GameMode;
            
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            // Can't iterate without a GameLogic instance
            btn_NextGeneration.Enabled = true;

            gl = new GameLogic();
            gameView.UpdateGameView(gl.GameGrid, GameGrid);
            GameGrid.CurrentCell = null;

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

        private void btn_Load_Click(object sender, EventArgs e)
        {
            GameData gd = (GameData)lbx_SavedGames.SelectedItem;
            gameView.UpdateGameView(gd.Generations.Last(), GameGrid);
 
            // Can't iterate without a GameLogic instance
            gl = new GameLogic();
            btn_NextGeneration.Enabled = true;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cb_GameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.GameMode = (GameSettings.GAMEMODE)cb_GameMode.SelectedIndex;
            MessageBox.Show(settings.GameMode.ToString());
        }
    }
}
