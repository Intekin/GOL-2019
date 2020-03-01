using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace GOL_2019
{
    public partial class Form1 : Form
    {
        GameLogic gameLogic;
        GameView gameView;
        Thread thread;

        bool running = false;

        public Form1()
        {
            InitializeComponent();
            InitBaseSettings();
        }

        private void InitBaseSettings()
        {
            gameView = new GameView();

            nud_X.Value = GameSettings.Width;
            nud_Y.Value = GameSettings.Height;

            nud_CellsAlive.Value = GameSettings.InitialCellsAlive;

            gameView.InitGameView(PB_MainView, GameSettings.Width, GameSettings.Height);
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = true;

            GameSettings.Width = (int)nud_X.Value;
            GameSettings.Height = (int)nud_Y.Value;
            GameSettings.InitialCellsAlive = (int)nud_CellsAlive.Value;

            gameLogic = new GameLogic(GameSettings.Width, GameSettings.Height, GameSettings.InitialCellsAlive);
            gameView.InitGameView(PB_MainView, GameSettings.Width, GameSettings.Height);
            //gameView.UpdateGameView(gameLogic.Grid ,PB_MainView);

            running = true;

            thread = new Thread(new ThreadStart(GameLoop));
            thread.Start();            
        }

        private void GameLoop()
        {
            while (running)
            {
                gameLogic.Iterate();
                gameView.UpdateGameView(gameLogic.Grid, PB_MainView);
                Thread.Sleep(GameSettings.UpdateInterval);
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            // Calling Iterate() updates gameLogic.GameGrid
            //gameLogic.Iterate();
            //gameView.UpdateGameView(gameLogic.Grid, PB_MainView);

            running = false;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
        }
    }
}
