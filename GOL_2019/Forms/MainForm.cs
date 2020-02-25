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
            gameView.UpdateGameView(gameLogic.Grid ,PB_MainView);

            currentGame = new GameData();
        }

        private void btn_NextGeneration_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
            gameLogic.Iterate();

            gameView.UpdateGameView(gameLogic.Grid, PB_MainView);
        }

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
    }
}
