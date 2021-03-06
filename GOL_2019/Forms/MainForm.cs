﻿using System;
using System.Windows.Forms;
using DatabaseCL;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gameLogic;
        GameView gameView;
        GameData currentGame;
        Timer loadingTimer;

        public Form1()
        {
            InitializeComponent();
            InitBaseSettings();
        }

        private void InitBaseSettings()
        {
            loadingTimer = new Timer();
            gameView = new GameView();

            nud_X.Value = GameSettings.Width;
            nud_Y.Value = GameSettings.Height;

            nud_CellsAlive.Value = GameSettings.InitialCellsAlive;

            gameView.InitGameView(PB_MainView, GameSettings.Width, GameSettings.Height);

            //Datasource
            //cb_GameMode.DataSource = Enum.GetValues(typeof(GameSettings.GameMode));
            cb_GameMode.SelectedItem = GameSettings.GameMode;
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            btn_NextGeneration.Enabled = true;

            GameSettings.Width = (int)nud_X.Value;
            GameSettings.Height = (int)nud_Y.Value;
            GameSettings.InitialCellsAlive = (int)nud_CellsAlive.Value;

            gameLogic = new GameLogic(GameSettings.Width, GameSettings.Height, GameSettings.InitialCellsAlive);
            gameView.InitGameView(PB_MainView, GameSettings.Width, GameSettings.Height);
            gameView.UpdateGameView(gameLogic.Generations.Last(), PB_MainView);

            currentGame = new GameData();
            currentGame.Generations = gameLogic.Generations;
        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gameLogic.Iterate();

            gameView.UpdateGameView(gameLogic.Generations.Last(), PB_MainView);
        }

        private void btn_SaveGame_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate name to avoid SQL errors while saving
                string name = tb_NameOfGame.Text;
                bool nameValidated = false;
                if (Regex.IsMatch(name, @"^[a-zA-Z0-9]+$") && name.Length >= 2) nameValidated = true;

                if (!nameValidated)
                {
                    MessageBox.Show("The name must be 2 characters and can only consist of letters and numbers.");
                    return;
                }

                if (currentGame == null)
                {
                    MessageBox.Show("No game to save. Try starting or loading one!");
                    return;
                }

                currentGame.Name = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong when trying to save the game.");
                Debug.WriteLine(ex.ToString());
            }
        }

        //private void btn_Load_Click(object sender, EventArgs eventArgs)
        //{
        //    // Disable loading until the current loaded save is done animating.
        //    btn_Load.Enabled = false;
        //    btn_StartNewGame.Enabled = false;
        //    btn_Delete.Enabled = false;
        //    btn_SaveGame.Enabled = false;
        //    btn_StopLoading.Visible = true;

        //    GameGrid.CurrentCell = null;
        //    GameData gd = (GameData)lbx_SavedGames.SelectedItem;
        //    currentGame = gd;      

        //    int generationIndex = 0; 
        //    loadingTimer.Tick += new EventHandler(delegate (object o, EventArgs e)
        //    {
        //      if (generationIndex < currentGame.Generations.Count)
        //      {
        //          gameView.UpdateGameView(currentGame.Generations[generationIndex], GameGrid);
        //          generationIndex++;
        //      } else
        //      {
        //          loadingTimer.Stop();
        //          btn_StopLoading.Visible = false;
        //          btn_Load.Enabled = true;
        //          btn_SaveGame.Enabled = true;
        //          btn_StartNewGame.Enabled = true;
        //          btn_Delete.Enabled = true;
        //      }
        //    });

        //    loadingTimer.Interval = 800;
        //    loadingTimer.Enabled = true;
        //}

        //private void btn_StopLoading_Click(object sender, EventArgs e)
        //{
        //    loadingTimer.Stop();
        //    btn_StopLoading.Visible = false;
        //    btn_Load.Enabled = true;
        //    btn_SaveGame.Enabled = true;
        //    btn_StartNewGame.Enabled = true;
        //    btn_Delete.Enabled = true;
        //}

        //private void btn_Delete_Click(object sender, EventArgs e)
        //{
        //    GameData gd = (GameData)lbx_SavedGames.SelectedItem;
        //    if (gd != null)
        //    {
        //        gameDatas.Remove(gd);
        //        DbManager.Delete(gd.ID);
        //    }
        //}

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Options_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.Show();
        }

        private void TSMI_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }


        //private void cb_GameMode_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    settings.GameMode = (GameSettings.GAMEMODE)cb_GameMode.SelectedIndex;

        //    if(settings.GameMode == GameSettings.GAMEMODE.Standard)
        //    {
        //        btn_Delete.Enabled = true;
        //        btn_Load.Enabled = true;
        //        btn_SaveGame.Enabled = true;
        //        nud_X.Enabled = false;
        //        nud_Y.Enabled = false;
        //        settings.NumberOfCellsX = 8;
        //        settings.NumberOfCellsY = 8;
        //    }
        //    if(settings.GameMode == GameSettings.GAMEMODE.Extended)
        //    {
        //        btn_Delete.Enabled = false;
        //        btn_Load.Enabled = false;
        //        btn_SaveGame.Enabled = false;
        //        nud_X.Enabled = true;
        //        nud_Y.Enabled = true;
        //    }
        //}

        //private void nud_X_ValueChanged(object sender, EventArgs e)
        //{
        //    settings.NumberOfCellsX = (int)nud_X.Value;
        //    gameView.InitGameView(GameGrid, settings.NumberOfCellsX, settings.NumberOfCellsY);
        //    btn_NextGeneration.Enabled = false;
        //}

        //private void nud_Y_ValueChanged(object sender, EventArgs e)
        //{
        //    settings.NumberOfCellsY = (int)nud_Y.Value;
        //    gameView.InitGameView(GameGrid, settings.NumberOfCellsX, settings.NumberOfCellsY);
        //    btn_NextGeneration.Enabled = false;
        //}

        //private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    About about = new About();
        //    about.Show();
        //}



        //private void ReloadData()
        //{
        //    // Databinding Listbox
        //    gameDatas = new BindingList<GameData>();
        //    gameDatas = LoadGame.LoadAll();
        //    lbx_SavedGames.DataSource = gameDatas;
        //}

    }
}
